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
using System.Collections.Generic;

namespace ECFundies
{

    /// <summary>
    /// Timeout policy encapsulator.
    /// </summary>
    class ECTimeout
    {
        private ECAxis _axis = null;
        private int _count = 0;
        private bool _fire = false;
        private bool _flush = false;
        private bool _isTimedOut = false;
        private string[] _propList = null;

        public ECAxis Axis { get { return _axis; } }
        public int Count { get { return _count; } }
        public bool Fire { get { return _fire; } set { _fire = value; } }
        public bool Flush { get { return _flush; } set { _flush = value; } }
        public bool IsTimedOut { get { return _isTimedOut; } }
        public string[] PropList { get { return _propList; } }
        
        public ECTimeout(ECAxis axis, string[] proplist)
        {
            _axis = axis;
            _propList = proplist;
        }
        
        /// <summary>
        /// 3 timeouts in a row raises timeout error;
        /// need 6 successes in a row to reverse;
        /// reflush every three.
        /// </summary>
        public void HadResult(char m_Stat)
        {
            //
            // timeout state:
            //     successful?
            //         dec count
            //         < 0?
            //             no-timeout declared
            //             on that axis only
            //             fire property
            //     else assumed timed out
            //         inc count
            //         > 6?
            //             set to 3
            //             fire property
            //             pause to flush queue
            // else no-timeout state: 
            //     successful?
            //         dec count
            //         < 0?
            //             set to 0
            //     else assume timeout
            //         inc count
            //         > 3?
            //             timeout declared
            //             on that axis only
            //             fire property
            //
            if (_isTimedOut)
            {
                if (m_Stat == 'C')
                {
                    if (--_count < 0)
                    {
                        _count = 0;
                        _fire = true;
                        _flush = false;
                        _isTimedOut = false;
                    }
                }
                else if (m_Stat == 'T')
                {
                    if (++_count > 6)
                    {
                        _count = 3;
                        _fire = true;
                        _flush = true;
                    }
                }
            }
            else
            {
                if (m_Stat == 'C')
                {
                    if (--_count < 0)
                    {
                        _count = 0;
                    }
                }
                else if (m_Stat == 'T')
                {
                    if (++_count > 3)
                    {
                        _fire = true;
                        _flush = false;
                        _isTimedOut = true;
                    }
                }
            }
        }
                
    }

}

