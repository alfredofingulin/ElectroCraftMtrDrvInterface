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
    /// ElectroCraft message builder base class.
    /// Tools to finish ECMsg creation.
    /// Not quite abstract 'cause we want a base public class to toss in a dictionary.
    /// </summary>
    public class ECMBBase
    {
        protected ECItem myItem;
        protected uint myAxis;

        public uint MyAxis { get { return myAxis; } set { myAxis = value; } }

        public ECMBBase(ECItem item)
        {
            myItem = item;
        }

        public ECMBBase(ECItem item, uint defaultaxis)
        {
            myItem = item;
            myAxis = defaultaxis;
        }

        public virtual void SetCreate(ref ECMsg m, uint rawdata)
        {
            throw new Exception("Override expected.");
        }
        public virtual void SetCreate(ref ECMsg m, int gquant, uint rawdata)
        {
            throw new Exception("Override expected.");
        }

        public virtual void GetCreate(ref ECMsg m)
        {
            throw new Exception("Override expected.");
        }
        public virtual void GetCreate(ref ECMsg m, int gquant)
        {
            throw new Exception("Override expected.");
        }
        public virtual void GetRawdata(ref ECMsg m, int offsetinrply, out uint rawdata)
        {
            throw new Exception("Override expected.");
        }

    }

}

