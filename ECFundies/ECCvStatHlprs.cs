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
    /// 'Cause you can't really place the SR32 and MER stuff in a DICv*.
    /// It's too... wierd?
    /// </summary>
    public static class ECCvStatHlprs
    {

        private static string[] _sr32Bit2Mne = {
			"Rdy",
			"SwOn",
			"OpEn",
			"SFlt",
			"MtPw",
			"QStp",
			"SwOnD",
			"MPLW",
			"MPLE",
			"R09",
			"MCmp",
			"IntLt",
			"OpML",
			"OpMH",
			"LEvt",
			"AxisOn",  // 0 is off
			"EndI",
			"PT1",
			"PT2",
			"PT3",
			"PT4",
			"AuRu",
			"LSwP",
			"LSwN",
			"PCaps",
			"TrGr",
			"I2TMt",
			"I2TDr",
			"InGr",
			"FrzCt",
			"InCam",
			"DrvFlt"
        };
        private static string[] _merBit2Mne = {
			"CANE",
			"Shrt",
			"SetE",
			"CtlE",
			"ComE",
			"MtPoW",
			"PLSw",
			"NLSw",
			"OvrI",
			"I2T",
			"MOvrT",
			"DOvrT",
			"OvrV",
			"UndV",
			"CmdE",
			"DisIn"
        };
        
    	public static string SR32ToString(uint rd, bool tsmode)
    	{
            string o = "";
            if (tsmode)
            {
            	o = o + "TSM ";
            }
            if ((rd & 0x00008000) == 0x00008000)
            {
                o = o + "AxisOn ";
            }
            else
            {
                o = o + "AxisOff ";
            }
            // note bit 31 is always next
            if (tsmode)
            {
                uint rdmsk = 0x80000000;
                int i;
				for (i = 31; i > 15; i--)
				{
					if ((rd & rdmsk) == rdmsk)
					{
						o = o + _sr32Bit2Mne[i];
					}
					rdmsk = rdmsk >> 1;
				}
				// skip 15 always done first
				rdmsk = 0x00006000;
				for (i = 14; i > 0; i--)
				{
					if ((rd & rdmsk) == rdmsk)
					{
						o = o + _sr32Bit2Mne[i];
					}
					rdmsk = rdmsk >> 1;
				}
            }
            else if ((rd & 0x80000000) == 0x80000000)  // bit 31 under investigation
            {
				o = o + _sr32Bit2Mne[31];
            }
            return o;
    	}

    	public static string SR32ToBackGColor(uint rd)
    	{
			string o = "Red";
            if ((rd & 0x00008000) == 0x00008000)
            {
                o = "Green";
            }
            return o;
    	}

    	public static string MERToString(uint rd, bool tsmode)
    	{
    		string o = "";
    		if (!tsmode)
    		{
    			o = o + " ";
				uint rdmsk = 0x00008000;
				int i;
				for (i = 15; i > 0; i--)
				{
					if ((rd & rdmsk) == rdmsk)
					{
						o = o + _merBit2Mne[i];
					}
					rdmsk = rdmsk >> 1;
				}
    		}
            return o;
    	}

    	public static string MERToBackGColor(uint rd)
    	{
    		string r = "";
    		return r;
    	}
    	
    	public static string MERToPwr(uint rd)
    	{
    		string o;
			if ((rd & 0x00008000) == 0x00008000)
			{
				o = "PwrOff ";
			}
			else
			{
				o = "PwrOn ";
			}
    		return o;
    	}

    }

}

