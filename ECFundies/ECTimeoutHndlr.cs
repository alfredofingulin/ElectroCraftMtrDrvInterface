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

    sealed class ECTimeoutHndlr
    {
        private static volatile ECTimeoutHndlr _instance;
        private static object _syncRoot = new Object();
        
        private static Dictionary<uint, ECTimeout> _eCTimeoutStore;
        
        private ECTimeoutHndlr()
        {
            _eCTimeoutStore = new Dictionary<uint, ECTimeout>(4);
        }
        
        public static ECTimeoutHndlr Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new ECTimeoutHndlr();
                        }
                    }
                }
                return _instance;
            }
            // no set
        }
        
        public void Populate(ECAxis axis, string[] proplist)
        {
            if (axis != null)
            {
                _eCTimeoutStore.Add(axis.Num, new ECTimeout(axis, proplist));
            }
        }
        
        public void Report(ECMsg m)
        {
            _eCTimeoutStore[m.K.Axis.Num].HadResult(m.Stat);
        }

        public void ShouldFire(ECAxis axis, out string[] proplist)
        {
            if (_eCTimeoutStore[axis.Num].Fire)
            {
                proplist = _eCTimeoutStore[axis.Num].PropList;
            }
            else
            {
                proplist = null;
            }
        }
        
        public void Fired(ECAxis axis)
        {
            _eCTimeoutStore[axis.Num].Fire = false;
        }
        
        public bool IsTimedOut(ECAxis axis)
        {
            return _eCTimeoutStore[axis.Num].IsTimedOut;
        }
        
        public bool ShouldFlush()
        {
            bool r = false;
            foreach (uint i in _eCTimeoutStore.Keys)
            {
                if (!r) 
                {
                    r = _eCTimeoutStore[i].Flush;
                }
            }
            return r;
        }
        
        public void Flushed()
        {
            foreach (uint i in _eCTimeoutStore.Keys)
            {
                _eCTimeoutStore[i].Flush = false;
            }
        }
        
    }

}

