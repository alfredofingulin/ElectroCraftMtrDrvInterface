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
    /// ElectroCraft Data Item for damn neary any single bit item.
    /// </summary>
    public class DICvSuperBit : DICnvtrBase
    {
    	
    	protected int myBitPos;
    	protected uint myRdMsk;
    	protected string myWhen1;
    	protected string myWhen0;
        protected string myForeGColorWhen1;
        protected string myBackGColorWhen1;
        protected string myForeGColorWhen0;
        protected string myBackGColorWhen0;

        public DICvSuperBit(int bitpos, string when1, string when0)
            : base('X', "")
        {
            myBitPos = bitpos;
            myRdMsk = (uint)(0x00000001 << myBitPos);
            myWhen1 = when1;
            myWhen0 = when0;
        }

        public DICvSuperBit(int bitpos, string when1, string when0, 
            string foregcolorwhen1, string foregcolorwhen0, string backgcolorwhen1, string backgcolorwhen0)
            : base('X', "")
        {
            myBitPos = bitpos;
            myRdMsk = (uint)(0x00000001 << myBitPos);
            myWhen1 = when1;
            myWhen0 = when0;
            myForeGColorWhen1 = foregcolorwhen1; 
            myBackGColorWhen1 = backgcolorwhen1;
            myForeGColorWhen0 = foregcolorwhen0;
            myBackGColorWhen0 = backgcolorwhen0;
        }

        public override bool ConvertIn(string val, ref uint rd)
        {
        	bool r = true;
        	if (val == myWhen1)
        	{
        		rd = rd | myRdMsk;
        	}
        	else if (val == myWhen0)
        	{
        		rd = rd & ~myRdMsk;
        	}
            else
            {
            	r = false;
            }
            return r;
        }

        public override string ConvertOut(uint rd)
        {
        	if ((rd & myRdMsk) > 0)
        	{
        		return myWhen1;
        	}
        	else
        	{
        		return myWhen0;
        	}
        }

        public override string ForeGColor(uint rd)
        {
            if ((rd & myRdMsk) > 0)
            {
                return myForeGColorWhen1;
            }
            else
            {
                return myForeGColorWhen0;
            }
        }

        public override string BackGColor(uint rd)
        {
            if ((rd & myRdMsk) > 0)
            {
                return myBackGColorWhen1;
            }
            else
            {
                return myBackGColorWhen0;
            }
        }

    }

}

