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
    /// "Standardizes" property names suffixes
    /// congruent with *ViewModel usage.
    /// </summary>
    /// <remarks>
    /// - LongName : _LongName
    /// - ShortName : _ShortName
    /// - MeasUnits : _MeasUnits
    /// - Set/GetMeasSys : NOT SUPPORTED
    /// - ConvertIn/Out : NOT SUPPORTED
    /// - SetIn/GetOut : _Data
    /// - ForeGColor/BackGColor : _ForeGColor/_BackGColor
    /// - relay commands : _Command, _CanExecute, _CommandHelper
    public static class PropStd
    {
        public static string LongName(string p)
        {
            return p + "_LongName";
        }
        public static string ShortName(string p)
        {
            return p + "_ShortName";
        }
        public static string MeasUnits(string p)
        {
            return p + "_MeasUnits";
        }
        public static string Data(string p)
        {
            return p + "_Data";
        }
        public static string ForeGColor(string p)
        {
            return p + "_ForeGColor";
        }
        public static string BackGColor(string p)
        {
            return p + "_BackGColor";
        }
        public static string Command(string p)
        {
            return p + "_Command";
        }
        public static string CanExecute(string p)
        {
            return p + "_CanExecute";
        }
        public static string CommandHelper(string p)
        {
            return p + "_CommandHelper";
        }

    }
}

