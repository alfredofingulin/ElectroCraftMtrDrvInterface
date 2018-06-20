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
    /// ElectroCraft message builder adapter.
    /// Unified interface to ECMsg, ECMBBase, and MBDataModel.
    /// </summary>
    public class MBAdaptBase
    {
        protected DaK myK;
        protected ECMBBase myEmb;

        public MBAdaptBase(DaK k)
        {
            myK = k;
        }

        public MBAdaptBase(DaK k, ECMBBase emb)
        {
            myK = k;
            myEmb = emb;
        }

        public ECMBBase GetEmb() { return myEmb; }

        public virtual ECMsg NewMsg()
        {
            return new ECMsg(myK);
        }

        public virtual void SetCreate(ref ECMsg m, uint rawdata)
        {
            if (m.K.Item.Num == myK.Item.Num)
            {
                myEmb.SetCreate(ref m, rawdata);
            }
        }
        public virtual void SetCreate(ref ECMsg m, int gquant, uint rawdata)
        {
            if (m.K.Item.Num == myK.Item.Num)
            {
                myEmb.SetCreate(ref m, gquant, rawdata);
            }
        }

        public virtual void GetCreate(ref ECMsg m)
        {
            if (m.K.Item.Num == myK.Item.Num)
            {
                myEmb.GetCreate(ref m);
            }
        }
        public virtual void GetCreate(ref ECMsg m, int gquant)
        {
            if (m.K.Item.Num == myK.Item.Num)
            {
                myEmb.GetCreate(ref m, gquant);
            }
        }
        public virtual void GetRawdata(ref ECMsg m, int offsetinrply, out uint rawdata)
        {
			if (m.K.Item.Num == myK.Item.Num) 
			{
				myEmb.GetRawdata (ref m, offsetinrply, out rawdata);
			} 
			else 
			{
				rawdata = 0;
			}
        }

    }

}

