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
    /// ElectroCraft "sub" data item base class.
    /// </summary>
    public class SubDaIBase : AbstDaI
    {
        private string _key = null;

        public SubDaIBase(string key,
            string longname,
            string shortname,
            DICnvtrBase cnvtr0,
            DICnvtrBase cnvtr1)
            : base(longname, shortname, cnvtr0, cnvtr1)
        {
            _key = key;
        }
      
        public SubDaIBase(string key,
            DICnvtrBase cnvtr0,
            DICnvtrBase cnvtr1)
            : base(key, key, cnvtr0, cnvtr1)
        {
            _key = key;
        }

        public string Key { get { return _key; } }

        public string PropNam(DaIBase src) { return src.PropNam + "_" + _key; }

        public bool SetIn(string val, DaIBase src)
        {
            bool r = false;
            DICnvtrBase cv = GetCv();
            if (cv != null)
            {
                uint myrd;
                src.GetOut(out myrd);
                r = cv.ConvertIn(val, ref myrd);
                src.SetIn(myrd);
            }
            // implied else is do nothing
            return r;
        }

        public virtual bool SetIn(uint val, DaIBase src)
        {
            throw new Exception("Override expected.");
        }

        public void GetOut(out string o, DaIBase src)
        {
            DICnvtrBase cv = GetCv();
            if (cv != null)
            {
                uint myrd;
                src.GetOut(out myrd);
                o = cv.ConvertOut(myrd);
            }
            else
            {
                o = "";
            }
        }

        public virtual void GetOut(out uint o, DaIBase src)
        {
            throw new Exception("Override expected.");
        }

        public string ForeGColor(DaIBase src)
        {
            DICnvtrBase cv = GetCv();
            if (cv != null)
            {
                uint myrd;
                src.GetOut(out myrd);
                return cv.ForeGColor(myrd);
            }
            else
            {
                return null;
            }
        }

        public string BackGColor(DaIBase src)
        {
            DICnvtrBase cv = GetCv();
            if (cv != null)
            {
                uint myrd;
                src.GetOut(out myrd);
                return cv.BackGColor(myrd);
            }
            else
            {
                return null;
            }
        }

    }

}

