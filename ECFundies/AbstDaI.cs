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
    /// Abstract ElectroCraft data item.
    /// </summary>
    /// <remarks>
    /// Why?  Because some base classes may need different accessor signatures.
    /// Note some things, once set, can not be changed; that's intentional.
    /// </remarks>
    public abstract class AbstDaI
    {
        private string _longName = "";
        private string _shortName = "";
        private char _measSys = ' ';
        private Dictionary<char, DICnvtrBase> _cnvtrStore = new Dictionary<char, DICnvtrBase>(4);

        /// <summary>
        /// Unique key is deferred.
        /// May have long/short names;
        /// conversions may be null or X.
        /// </summary>
        public AbstDaI(
            string longname,
            string shortname,
            DICnvtrBase cnvtr0,
            DICnvtrBase cnvtr1)
        {
            _longName = longname;
            _shortName = shortname;
            if (cnvtr0 != null)
            {
                AddCv(cnvtr0);
            }
            if (cnvtr1 != null)
            {
                AddCv(cnvtr1);
            }
        }

        public string LongName { get { return _longName; }  /* no set */ }
        public string ShortName { get { return _shortName; }  /* no set */ }

        /// <summary>
        /// Measurement system can be 
        /// - 'E' english
        /// - 'M' metric
        /// - 'X' don't care
        /// - ' ' undefined
        /// Has side-effect of changing conversion calculation and measurement units string 
        /// by selecting a DICnvtrBase.
        /// </summary>
        public char MeasSys { get { return _measSys; } set { _measSys = value; } }
        
        /// <summary>
        /// Use current measurement system and get the convertor for it.
        /// </summary>
        public DICnvtrBase GetCv()
        {
            DICnvtrBase cv = null;
            _cnvtrStore.TryGetValue(_measSys, out cv);
            if (cv == null)
            {
                _cnvtrStore.TryGetValue('X', out cv);
            }
            return cv;
        }
        
        /// <summary>
        /// Add another convertor.
        /// </summary>
        public void AddCv(DICnvtrBase cv)
        {
            _cnvtrStore.Add(cv.MeasSys, cv);
        }
        
        /// <summary>
        /// Remove convertor.
        /// </summary>
        public void RemCv(DICnvtrBase cv)
        {
            _cnvtrStore.Remove(cv.MeasSys);
        }
        
        public string MeasUnits
        {
            get
            {
                DICnvtrBase cv = GetCv();
                if (cv == null)
                {
                    return "";
                }
                else
                {
                    return cv.MeasUnits;
                }
            }
        }

    }

}

