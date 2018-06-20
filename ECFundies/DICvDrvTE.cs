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
    /// ElectroCraft Data Item for drive temperature.
    /// </summary>
    public class DICvDrvTE : DICnvtrBase
    {

        public DICvDrvTE()
            : base('E', WSMStrings.Deg_F)
        {
        }

        public override bool ConvertIn(string val, ref uint rd)
        {
            float t;
            bool r = Single.TryParse(val, out t);
            if (r)
            {
                t = ((t - 32.0f) * 1453.9f) / 9.0f;
                rd = (uint)((int)t);
            }
            return r;
        }

        public override string ConvertOut(uint rd)
        {
            float t_f = ((float)((int)rd));
            string r;
            t_f = (t_f * 9.0f) / 1453.9f + 32.0f;
            r = t_f.ToString("N1");
            return r;
        }

    }

}

