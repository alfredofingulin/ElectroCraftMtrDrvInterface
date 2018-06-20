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
    /// ElectroCraft data item base class.
    /// </summary>
    public class DaIBase : AbstDaI
    {
        private DaK _key;
        private uint _rd = 0;

        public DaIBase(DaK key,
            string longname,
            string shortname,
            DICnvtrBase cnvtr0,
            DICnvtrBase cnvtr1)
            : base(longname, shortname, cnvtr0, cnvtr1)
        {
            _key = key;
        }

        public DaK Key { get { return _key; } }

        public string PropNam { get { return _key.PropNam; } }

        /// <summary>
        /// Set the value from a string or raw data.  Does not send it to ElectroCraft drive!
        /// Note the default on raw data is to store it without modification.
        /// </summary>
        /// <returns>
        /// true - string/raw data valid, value set
        /// false - string/raw data screwed up somehow, value unchanged
        /// </returns>
        public bool SetIn(string val)
        {
            bool r = false;
            DICnvtrBase cv = GetCv();
            if (cv != null)
            {
                r = cv.ConvertIn(val, ref _rd);
            }
            // implied else is do nothing
            return r;
        }

        /// <summary> 
        /// Simple way is the best way.
        /// </summary>
        public bool SetIn(uint val)
        {
            _rd = val;
            return true;
        }

        /// <summary>
        /// Current value as represented by measurement system and units;
        /// does not include the unit string itself.
        /// Raw data version is just that.
        /// Note the default on raw data is to serve it without modification.
        /// </summary>
        public void GetOut(out string o)
        {
            DICnvtrBase cv = GetCv();
            if (cv != null)
            {
                o = cv.ConvertOut(_rd);
            }
            else
            {
                o = "";
            }
        }

        /// <summary> 
        /// Simple way is the best way.
        /// </summary>
        public void GetOut(out uint o)
        {
            o = _rd;
        }
        
        /// <summary>
        /// Recommended foreground color for the present data.
        /// </summary>
        public string ForeGColor()
        {
            DICnvtrBase cv = GetCv();
            if (cv != null)
            {
                return cv.ForeGColor(_rd);
            }
            else
            {
                return null;  // doesn't override existing color
            }
        }

        /// <summary>
        /// Recommended background color for the present data.
        /// </summary>
        public string BackGColor()
        {
            DICnvtrBase cv = GetCv();
            if (cv != null)
            {
                return cv.BackGColor(_rd);
            }
            else
            {
                return null;  // doesn't override existing color
            }
        }

    }

}

