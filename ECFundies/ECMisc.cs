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
    /// Various ElectroCraft misc.
    /// </summary>
    /// <remarks>
    /// ElectroCraft 32 bit fixed point 
    /// has whole in upper 16 bits, frac in lower 16.
    /// </remarks>
    public static class ECMisc
    {

        public static int FloatToECFPInt(float d)
        {
            int w = (int)d;
            int f = (int)((d - ((float)w)) * 65536f);
            return (w << 16) | f;
        }

        public static float ECFPIntToFloat(int d)
        {
            int w = d >> 16;
            float r = ((float)(d & 0xFFFF)) / 65536f;
            r = r + (float)w;
            return r;
        }

    }

}

