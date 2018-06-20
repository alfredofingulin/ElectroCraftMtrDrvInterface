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
    /// Because the List collection is too much for DaKs. 
    /// </summary>
    public class DaKList
    {

    	protected DaK[] myDaKs = null;
    	protected int myIdx = 0;
    	
        public DaKList(int daklength)
        {
            myDaKs = new DaK[daklength];
        }

        public DaKList(DaK[] thedaks)
        {
        	myDaKs = thedaks;
        }
         
        public int Idx { get { return myIdx; } set { myIdx = value; } }
        public int Length {
            get {
                int r = 0;
                if (myDaKs != null) {
                    r = myDaKs.Length;
                }
                return r;
            }
        }

        /// <summary>
        /// Set in a DaK whereever the hell the index is.
        /// </summary>
        public void SetIn(ref DaK adak)
        {
            if (myDaKs != null)
            {
                myDaKs [myIdx] = adak;
                if (++myIdx >= myDaKs.Length) 
                {
                    myIdx = 0;
                }
            }
        }

        /// <summary>
        /// Set in a DaK to a specific index.
        /// </summary>
        public void SetIn(ref DaK adak, int at)
        {
            if ((myDaKs != null) && (at <= (myDaKs.Length - 1)))
            {
                myIdx = at;
                SetIn (ref adak);
            }
        }

        /// <summary>
        /// Set in multiple DaKs starting at an index with wraparound.
        /// </summary>
        public void SetIn(ref DaK[] daks, int quant, int at)
        {
            if ((myDaKs != null) && (quant <= myDaKs.Length) && (at <= (myDaKs.Length - 1)))
            {
                myIdx = at;
                for (int i = 0; i < quant; i++) 
                {
                    SetIn (ref daks [i]);
                }
            }
        }

        /// <summary>
        /// Set in multiple DaKs starting at an index but don't wraparound.
        /// </summary>
        public void SetIn(ref DaK[] daks, int quant, int at, ref bool wouldwrap)
        {
            wouldwrap = false;
            if ((myDaKs != null) && (quant <= myDaKs.Length) && (at <= (myDaKs.Length - 1)))
            {
                myIdx = at;
                for (int i = 0; (i < quant) && !wouldwrap; i++) 
                {
                    SetIn (ref daks [i]);
                    if (myIdx == 0) 
                    {
                        wouldwrap = true;
                    }
                }
            }
        }

        /// <summary>
        /// Get out the next DaK, updates index.
        /// </summary>
        public DaK GetOut()
        {
        	DaK r = null;
        	if (myDaKs != null)
        	{
        		r = myDaKs[myIdx];
        		if (++myIdx >= myDaKs.Length)
        		{
        			myIdx = 0;
        		}
        	}
        	return r;
        }

        /// <summary>
        /// Get out the DaK at the index, updates index.
        /// </summary>
        public DaK GetOut(int at)
        {
            DaK r = null;
            if ((myDaKs != null) && (at <= (myDaKs.Length - 1)))
            {
                myIdx = at;
                r = GetOut();
            }
            return r;
        }

        /// <summary>
        /// Get out multiple DaKs; silently wraps around.
        /// </summary>
        public DaK[] GetOut(int quant, int at)
        {
        	DaK[] r = null;
            if ((myDaKs != null) && (quant <= myDaKs.Length) && (at <= (myDaKs.Length - 1)))
            {
                r = new DaK[quant];
                myIdx = at;
                for (int i = 0; i < quant; i++)
                {
                    r[i] = GetOut();
                }
            }
            if ((myDaKs != null) && (quant <= myDaKs.Length))
            {
        	}
        	return r;
        }
        
        /// <summary>
        /// Get out DaKs.  May return less than quant; never wrapsaround.
        /// </summary>
        public DaK[] GetOut(int quant, int at, ref bool wouldwrap)
        {
        	DaK[] r = null;
            wouldwrap = false;
            if ((myDaKs != null) && (quant <= myDaKs.Length) && (at <= (myDaKs.Length - 1)))
            {
                r = new DaK[quant];
                myIdx = at;
                for (int i = 0; (i < quant) && !wouldwrap; i++) 
                {
                    r [i] = GetOut ();
                    if (myIdx == 0) 
                    {
                        wouldwrap = true;
                    }
                }
            }
        	return r;
        }
        
    }
}

