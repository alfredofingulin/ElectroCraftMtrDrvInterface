// 
// MIT License
// 
// Copyright (c) 2017, 2018 Alfred O Fingulin  FinguPublic@gmail.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 

using System;
using System.Collections.Concurrent;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace ECFundies
{

    /// <summary>
    /// This wraps Serial Port for ElectroCraft communications
    /// It's a singleton.
    /// </summary>
    /// <remarks>
    /// This implements two thread safe queues 
    /// and task that moves data to/from the serial port.
    /// It's dependant on ECMsg object fields.
    /// </remarks>
    sealed class ECSerialPort
    {
        private static volatile ECSerialPort _instance;
        private static object _syncRoot = new Object();

        private static string _commPort2Use;

        private static ConcurrentQueue<ECMsg> _in_q;
        private static ConcurrentQueue<ECMsg> _out_q;

        private static byte[] _xbf;  // xfer buffer
        private static int _xbf_cntdwn;  // num of bytes remaining to xfer /after/ initial 0x4F; usually final _xbf_i - 1
        private static int _xbf_i_lenpos;  // index to length position in reply, usually after 0x4F aka [0] but not there during brief replies
        private static int _xbf_i;  // next free byte in xbf, reflects buffer count actually used
        private static char _xbf_stat;  // similar to ECMsg.Stat

        private static ECMsg _xmsg;

        private Task _transactTask;

        private static SerialPort _sp;
/// <todo>        private static DemoMode _dm; </todo>

        private enum TakeDataState { Initial, Unsol, Brief, Typical, GroupExtended, GroupExtendedContinue, UnsolCleanup, Cleanup, Done };
        private static TakeDataState RxTakState;

        /// <summary>
        /// Set up all instances we need, but defer port instansiation
        /// until open is invoked.
        /// </summary>
        private ECSerialPort()
        {
            _commPort2Use = "";
            _in_q = new ConcurrentQueue<ECMsg>();
            _out_q = new ConcurrentQueue<ECMsg>();
            _xbf = new byte[256];
            _transactTask = new Task(TransactTask);
            _transactTask.Start();
        }

        /// <summary>
        /// Ensure this is a singleton.
        /// Uses thread-safe double-lock scheme.
        /// </summary> 
        public static ECSerialPort Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new ECSerialPort();
                        }
                    }
                }
                return _instance;
            }
            // no set
        }

        /// <summary>
        /// Specify the port before Open-ing!  Close before changing!
        /// </summary>
        public string CommPort2Use
        {
            get
            {
                return _commPort2Use;
            }
            set
            {
                if (_sp == null)
                {
                    _commPort2Use = value;
                }
                else
                {
                    throw new Exception("Need to Close before set.");
                }
            }
        }

        /// <summary>
        /// Open the CommPort2Use.
        /// </summary>
        /// <remarks>
        /// Defaults of 9600, no parity, 8 bits data, 1 stop bit, no handshake are good.
        /// Went to a different timeout, tho.
        /// </remarks>
        public void Open()
        {
            if (_commPort2Use != "DemoMode")  // demo mode port allows open
            {
                if (_sp == null)  // not demo? then better not already be open or be a bad port
                {
                    _sp = new SerialPort(_commPort2Use);
                    _sp.BaudRate = 38400;  // 9600;
                    _sp.WriteTimeout = 150;  // 300;
                    _sp.ReadTimeout = 150;  // 300;
                    _sp.Open();
                }
                else
                {
                    throw new Exception("Already Open-ed, or CommPort2Use invalid, or not demo.");
                }
            }
            else
            {
/// <todo>                _dm = new DemoMode(); </todo>
            }
        }

        /// <summary>
        /// Close CommPort2Use and lose all messages (flushes the queues).
        /// </summary>
        public void Close()
        {
            if (_sp != null)
            {
                CatchUp();
                _sp.Close();
                _sp = null;
                FlushQs();
            }
            else if (_commPort2Use == "DemoMode")
            {
                CatchUp();
/// <todo>                _dm = null; </todo>
                FlushQs();
            }
        }

        /// <summary>
        /// If the port is open, restarts transactions and presents an req/rply message.
        /// </summary>
        /// <remarks>
        /// Note ordering; the dispatcher makes the choice on when to keep processing.
        /// </remarks>
        public void Enq(ECMsg m)
        {
            if ((_sp != null) || (_commPort2Use == "DemoMode"))
            {
                if (_transactTask.IsCompleted)
                {
                    _transactTask = new Task(TransactTask);
                    _transactTask.Start();
                }
                _in_q.Enqueue(m);
            }
        }

        /// <summary>
        /// If the port is open, remove an req/rply message and keep transactions going.
        /// </summary>
        /// <remarks>
        /// Note ordering; the dispatcher makes the choice on when to keep processing.
        /// </remarks>
        public bool TryDeq(out ECMsg m)
        {
            bool r;
            if ((_sp != null) || (_commPort2Use == "DemoMode"))
            {
                r = _out_q.TryDequeue(out m);
                if (_transactTask.IsCompleted)
                {
                    _transactTask = new Task(TransactTask);
                    _transactTask.Start();
                }
            }
            else
            {
                m = null;
                r = false;
            }
            return r;
        }

        /// <summary>
        /// Waits for all messages to catch up.
        /// </summary>
        public void CatchUp()
        {
            _transactTask.Wait();
        }

        /// <summary>
        /// Obvious.
        /// </summary>
        public void FlushQs()
        {
            ECMsg m;
            while (_in_q.TryDequeue(out m)) { }
            while (_out_q.TryDequeue(out m)) { }
        }

        /// <summary>
        /// Synchronously regains sync with the drive.  This will screw up your threading and response time.
        /// Use only in an emergency.  You must CatchUp, empty the queues, and ensure a single thread
        /// is using this.
        /// </summary>
        /// <remarks>
        /// Implements resync scheme described in ElectroCraft doc
        /// A11229_MotionPRO_UM-Rev1 physical pages 112 & 113.
        /// </remarks>
        /// <returns>
        /// true on resync, false otherwise.
        /// </returns>
        public bool ReSync()
        {
            bool r = false;
            byte[] tbf = { 0x0d };
            byte rbf = 0;
            for (int i = 0; !r && (i < 15); i++)
            {
                _sp.Write(tbf, 0, 1);
                if (Rx1Byte(ref rbf) && (rbf == 0x0d))
                {
                    r = true;
                }
            }
            return r;
        }

        /// <summary>
        /// Synchronously transmits and receives an _xmsg.
        /// </summary>
        private void TransactTask()
        {
            if (_sp != null)
            {
                while (_in_q.TryDequeue(out _xmsg))
                {
                    Tx();
                    Rx();
                    _out_q.Enqueue(_xmsg);
                }
            }
            else
            {
                while (_in_q.TryDequeue(out _xmsg))
                {
/// <todo>                    _dm.Handle(_xmsg); </todo>
                    _out_q.Enqueue(_xmsg);
                }
            }
        }

        /// <summary>
        /// Synchronously xmits an _xmsg.
        /// </summary>
        private void Tx()
        {
            _sp.Write(_xmsg.ReqMsg, 0, _xmsg.ReqMsg.Length);
        }

        /// <summary>
        /// Synchronously recvs an _xmsg; will pack up an unsolicited message.
        /// </summary>
        private void Rx()
        {
            RxTakState = TakeDataState.Initial;

            while (RxTakState != TakeDataState.Done)
            {
                switch (RxTakState)
                {
                    case TakeDataState.Initial:
                        Rx_TakInitial();
                        break;
                    case TakeDataState.Unsol:
                        Rx_TakUnsol();
                        break;
                    case TakeDataState.Brief:
                        Rx_TakBrief();
                        break;
                    case TakeDataState.Typical:
                        Rx_TakTypical();
                        break;
                    case TakeDataState.GroupExtended:
                        Rx_TakGroupExtended();
                        break;
                    case TakeDataState.GroupExtendedContinue:
                        Rx_TakGroupExtendedContinue();
                        break;
                    case TakeDataState.UnsolCleanup:
                        Rx_TakUnsolCleanup();
                        break;
                    case TakeDataState.Cleanup:
                        Rx_TakCleanup();
                        break;
                    default:
                        ;
                        break;
                }

            }
        }

        private void Rx_TakInitial()
        {
            _xbf_cntdwn = 0;
            _xbf_i = _xbf_i_lenpos = 0;
            _xbf_stat = '?';

            if (!Rx1Byte(ref _xbf[_xbf_i++]))
            {
                // first byte has timed out; bail.
                // _xbf_cntdwn undefined, strictly speaking
                _xbf_i_lenpos = _xbf_i;
                _xbf_stat = 'T';
                RxTakState = TakeDataState.Cleanup;
            }
            else if (_xbf[_xbf_i - 1] == 0x4F)
            {
                // first byte is 0x4F, may be a brief or typical response
                // _xbf_cntdwn may be defined in brief state
                // _xbf_i_lenpos may be defined in brief state
                RxTakState = TakeDataState.Brief;
            }
            else if (_xbf[_xbf_i - 1] <= 0x0C)
            {
                // else if the first byte is 0x0C or less, then unsolicited in progress
                // move the length around to the next byte, fake a 0x4F in the first byte, 
                // update counters accordingly
                _xbf[_xbf_i_lenpos = _xbf_i] = _xbf[_xbf_i - 1];
                _xbf[_xbf_i - 1] = 0x4F;
                _xbf_cntdwn = _xbf[_xbf_i_lenpos] + 1;  // checksum too
                ++_xbf_i;
                RxTakState = TakeDataState.Unsol;
            }
            else
            {
                // else some kind of sync problem has occured; bail.
                // _xbf_cntdwn undefined, strictly speaking
                _xbf_i_lenpos = _xbf_i;
                _xbf_stat = 'Y';
                RxTakState = TakeDataState.Cleanup;
            }
        }

        private void Rx_TakUnsol()
        {
            if (Rx1Byte(ref _xbf[_xbf_i++]))
            {
                if (--_xbf_cntdwn == 0)
                {
                    Rx_TestCS();
                    RxTakState = TakeDataState.UnsolCleanup;
                }
                // implied else is stay in take unsolicited state
            }
            else
            {
                // timed out; time to bail.
                _xbf_stat = 'T';
                RxTakState = TakeDataState.Cleanup;
            }
        }

        private void Rx_TakBrief()
        {
            if (_xmsg.RplyMsg.Length == 1)
            {
                // the reply length is 1, we're done; no, really, we are
                _xbf_stat = 'C';
                RxTakState = TakeDataState.Cleanup;
            }
            else if (Rx1Byte(ref _xbf[_xbf_i++]))
            {
                // get the count without errors, continue to typical
                _xbf_i_lenpos = _xbf_i - 1;
                _xbf_cntdwn = _xbf[_xbf_i_lenpos] + 1;  // checksum too
                RxTakState = TakeDataState.Typical;
            }
            else
            {
                // else we timed out and this is over
                // _xbf_cntdwn undefined, strictly speaking
                _xbf_i_lenpos = _xbf_i;
                _xbf_stat = 'T';
                RxTakState = TakeDataState.Cleanup;
            }
        }

        private void Rx_TakTypical()
        {
            if (Rx1Byte(ref _xbf[_xbf_i++]))
            {
                if (--_xbf_cntdwn == 0)
                {
                    // if we've gotten all bytes, verify checksum
                    Rx_TestCS();
                    if (_xbf_i <= _xmsg.RplyMsg.Length)
                    {
                        // if the current index is the expected reply length,
                        // then we're done; not a group message reply
                        RxTakState = TakeDataState.Cleanup;
                    }
                    else
                    {
                        // it's a group message reply; take more bytes
                        // reverse what checksum test did
                        _xbf_stat = '?';
                        RxTakState = TakeDataState.GroupExtended;
                    }
                }
                // implied else is stay in take typical state
                // take more bytes
            }
            else
            {
                // timed out; time to bail.
                _xbf_stat = 'T';
                RxTakState = TakeDataState.Cleanup;
            }
        }

        private void Rx_TakGroupExtended()
        {
            if (Rx1Byte(ref _xbf[_xbf_i++]))
            {
                // take the count for the next reply in the group
                // note the index doesn't change.
                _xbf_i_lenpos = _xbf_i - 1;
                _xbf_cntdwn = _xbf[_xbf_i_lenpos] + 1;  // checksum too
                RxTakState = TakeDataState.GroupExtendedContinue;
            }
            else
            {
                // timed out; time to bail.
                _xbf_stat = 'T';
                RxTakState = TakeDataState.Cleanup;
            }
        }

        private void Rx_TakGroupExtendedContinue()
        {
            if (Rx1Byte(ref _xbf[_xbf_i++]))
            {
                if (--_xbf_cntdwn == 0)
                {
                    // if we've gotten all bytes, verify checksum
                    Rx_TestCS();
                    if (_xbf_i <= _xmsg.RplyMsg.Length)
                    {
                        // if the current index is the expected reply length,
                        // then we're done; group complete
                        RxTakState = TakeDataState.Cleanup;
                    }
                    else
                    {
                        // it's a group message reply; take more bytes
                        // reverse what checksum test did
                        _xbf_stat = '?';
                        RxTakState = TakeDataState.GroupExtended;
                    }
                }
                else
                {
                    // timed out; time to bail.
                    _xbf_stat = 'T';
                    RxTakState = TakeDataState.Cleanup;
                }
            }
        }
        private void Rx_TakUnsolCleanup()
        {
            // unsolicited goes around a few things and restarts
            // it has to build a new ECM message and output it
            // then back to servicing the original msg
            ECMsg m = new ECMsg(null);
            m.SetUp('U', 0, _xbf_i);  // indexs + 1 'cause there's 0x4F precursor...
            Array.Copy(_xbf, m.RplyMsg, m.RplyMsg.Length);
            m.Stat = _xbf_stat;
            _out_q.Enqueue(m);
            RxTakState = TakeDataState.Initial;
        }

        private void Rx_TakCleanup()
        {
            // everything operates on _xmsg
            Array.Copy(_xbf, _xmsg.RplyMsg, _xmsg.RplyMsg.Length);
            _xmsg.Stat = _xbf_stat;
            RxTakState = TakeDataState.Done;
        }

        /// <summary>
        /// Get 1 "byte".
        /// </summary>
        /// <returns>
        /// True valid false it's not.
        /// </returns>
        private bool Rx1Byte(ref byte b)
        {
            bool r = true;
            try
            {
                b = (byte)_sp.ReadByte();
            }
            catch (TimeoutException) { r = false; }
            return r;
        }

        /// <summary>
        /// Use _xbf* to calc checksum and fill in results.
        /// </summary>
        private void Rx_TestCS()
        {
            if (_xbf[_xbf_i - 1] == Msger.Chksum(_xbf, _xbf_i_lenpos))
            {
                _xbf_stat = 'C';
            }
            else
            {
                _xbf_stat = 'K';
            }
        }

    }
}

