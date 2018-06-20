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
    /// Sub Data item interface adapter.
    /// Unified interface to SubDaIDataModel using DaIBase.
    /// </summary>
    public class SubDaIAdaptBase
    {
        protected string myK;
        protected SubDaIBase mySubDaii;
        protected DaIBase mySrc;

        public SubDaIAdaptBase(string k, DaIBase src)
        {
            myK = k;
            mySrc = src;
        }

        public SubDaIAdaptBase(string k, DaIBase src, SubDaIBase subdaii)
        {
            myK = k;
            mySrc = src;
            mySubDaii = subdaii;
        }

        public SubDaIBase GetSubDaIi() { return mySubDaii; }
        public DaIBase GetSrc() { return mySrc; }

        public virtual string PropNam() { return mySubDaii.PropNam(mySrc); }
        public virtual string LongName() { return mySubDaii.LongName; }
        public virtual string ShortName() { return mySubDaii.ShortName; }
        public virtual char GetMeasSys() { return mySubDaii.MeasSys; }
        public virtual void SetMeasSys(char val) { mySubDaii.MeasSys = val; }
        public virtual string MeasUnits() { return mySubDaii.MeasUnits; }
        public virtual bool SetIn(string val) { return mySubDaii.SetIn(val, mySrc); }
        public virtual bool SetIn(uint val) { return mySubDaii.SetIn(val, mySrc); }
        public virtual void GetOut(out string o) { mySubDaii.GetOut(out o, mySrc); }
        public virtual void GetOut(out uint o) { mySubDaii.GetOut(out o, mySrc); }
        public virtual string ForeGColor() { return mySubDaii.ForeGColor(mySrc); }
        public virtual string BackGColor() { return mySubDaii.BackGColor(mySrc); }

    }

}

