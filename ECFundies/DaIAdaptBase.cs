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
    /// Data item interface adapter.
    /// Unified interface to Dak and DaIDataModel.
    /// </summary>
    public class DaIAdaptBase
    {
        protected DaK myK;
        protected DaIBase myDaii;

        public DaIAdaptBase(DaK k)
        {
            myK = k;
        }                 

        public DaIAdaptBase(DaK k, DaIBase daii)
        {
            myK = k;
            myDaii = daii;
        }                 

        public DaIBase GetDaIi() { return myDaii; }

        public virtual string PropNam() { return myDaii.PropNam; }
        public virtual string LongName() { return myDaii.LongName; }
        public virtual string ShortName() { return myDaii.ShortName; }
        public virtual char GetMeasSys() { return myDaii.MeasSys; }
        public virtual void SetMeasSys(char val) { myDaii.MeasSys = val; }
        public virtual string MeasUnits() { return myDaii.MeasUnits; }
        public virtual bool SetIn(string val) { return myDaii.SetIn(val); }
        public virtual bool SetIn(uint val) { return myDaii.SetIn(val); }
        public virtual void GetOut(out string o) { myDaii.GetOut(out o); }
        public virtual void GetOut(out uint o) { myDaii.GetOut(out o); }
        public virtual string ForeGColor() { return myDaii.ForeGColor(); }
        public virtual string BackGColor() { return myDaii.BackGColor(); }

    }

}

