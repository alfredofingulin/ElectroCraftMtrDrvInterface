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

namespace ECFundies
{

    /// <summary>
    /// ElectroCraft data item converter base class.
    /// Not quite abstract 'cause we want a base public class to toss in a dictionary.
    /// </summary>
    public class DICnvtrBase
    {
        protected char myMeasSys;  // measurement system for this conversion
        protected string myMeasUnits;  // units for this conversion
        
        public char MeasSys { get { return myMeasSys; } }
        public string MeasUnits { get { return myMeasUnits; } }

        public DICnvtrBase(char meassys, string measunits)
        {
            myMeasSys = meassys;
            myMeasUnits = measunits;
        }

        /// <summary>
        /// String to raw data in the measurement system,
        /// formated for measurement units, report go/no-go.
        /// </summary>
        public virtual bool ConvertIn(string val, ref uint rd)
        {
            throw new Exception("Override expected.");
        }
        
        /// <summary>
        /// Raw data to a formated string in the measurement system,
        /// formated for measurement units, report go/no-go.
        /// </summary>
        public virtual string ConvertOut(uint rd)
        {
            throw new Exception("Override expected.");
        }

        /// <summary>
        /// Raw data to a to a foreground color.
        /// </summary>
        public virtual string ForeGColor(uint rd)
        {
            throw new Exception("Override expected.");
        }
        
        /// <summary>
        /// Raw data to a to a background color.
        /// </summary>
        public virtual string BackGColor(uint rd)
        {
            throw new Exception("Override expected.");
        }
        
    }

}

