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
    /// Ties together Axis in a Group semi-collection.
    /// Defines the number and name used for the Axis Group.
    /// </remarks>
    public class ECGroup
    {
        private uint _num;
        private string _nam;
        private ECAxis[] _axises;
        
        public uint Num { get { return _num; } }
        public string Nam { get { return _nam; } }
        public int Quant 
        {
            get 
            {
                int r = 0;
                if (_axises != null) 
                {
                    r = _axises.Length;
                }
                return r;
            }
        }
        
        public ECGroup(uint num, string nam, ECAxis[] axises)
        {
            _num = num;
            _nam = nam;
            _axises = axises;
        }
        
        public bool MemberOf(ECAxis axis)
        {
            bool r = false;
            if (_axises != null)
            {
                for(int i = 0; (i <_axises.Length) && (!r); i++)
                {
                    if (_axises[i] == axis)
                    {
                        r = true;
                    }
                }
            }
            return r;
        }
        
        public ECAxis MemberOf(uint num)
        {
            ECAxis r = null;
            if (_axises != null)
            {
                for(int i = 0; (i <_axises.Length) && (r == null); i++)
                {
                    if (_axises[i].Num == num)
                    {
                        r = _axises[i];
                    }
                }
            }
            return r;
        }
        
        public ECAxis MemberOf(string nam)
        {
            ECAxis r = null;
            if (_axises != null)
            {
                for(int i = 0; (i <_axises.Length) && (r == null); i++)
                {
                    if (_axises[i].Nam == nam)
                    {
                        r = _axises[i];
                    }
                }
            }
            return r;
        }
        
    }

}

