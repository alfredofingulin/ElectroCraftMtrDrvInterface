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
    /// Because the List collection is too much for ECMsgs. 
    /// </summary>
    public class ECMsgList
    {

    	protected ECMsg[] myECMsgs = null;
    	protected int myIdx = 0;
    	
        public ECMsgList(int ecmsglength)
        {
            myECMsgs = new ECMsg[ecmsglength];
        }

        public ECMsgList(ECMsg[] theecmsgs)
        {
        	myECMsgs = theecmsgs;
        }
         
        public int Idx { get { return myIdx; } set { myIdx = value; } }
        public int Length {
            get {
                int r = 0;
                if (myECMsgs != null) {
                    r = myECMsgs.Length;
                }
                return r;
            }
        }

        /// <summary>
        /// Set in a ECMsg whereever the hell the index is.
        /// </summary>
        public void SetIn(ref ECMsg aecmsg)
        {
            if (myECMsgs != null)
            {
                myECMsgs [myIdx] = aecmsg;
                if (++myIdx >= myECMsgs.Length) 
                {
                    myIdx = 0;
                }
            }
        }

        /// <summary>
        /// Set in a ECMsg to a specific index.
        /// </summary>
        public void SetIn(ref ECMsg aecmsg, int at)
        {
            if ((myECMsgs != null) && (at <= (myECMsgs.Length - 1)))
            {
                myIdx = at;
                SetIn (ref aecmsg);
            }
        }

        /// <summary>
        /// Set in multiple ECMsgs starting at an index with wraparound.
        /// </summary>
        public void SetIn(ref ECMsg[] ecmsgs, int quant, int at)
        {
            if ((myECMsgs != null) && (quant <= myECMsgs.Length) && (at <= (myECMsgs.Length - 1)))
            {
                myIdx = at;
                for (int i = 0; i < quant; i++) 
                {
                    SetIn (ref ecmsgs [i]);
                }
            }
        }

        /// <summary>
        /// Set in multiple ECMsgs starting at an index but don't wraparound.
        /// </summary>
        public void SetIn(ref ECMsg[] ecmsgs, int quant, int at, ref bool wouldwrap)
        {
            wouldwrap = false;
            if ((myECMsgs != null) && (quant <= myECMsgs.Length) && (at <= (myECMsgs.Length - 1)))
            {
                myIdx = at;
                for (int i = 0; (i < quant) && !wouldwrap; i++) 
                {
                    SetIn (ref ecmsgs [i]);
                    if (myIdx == 0) 
                    {
                        wouldwrap = true;
                    }
                }
            }
        }

        /// <summary>
        /// Get out the next ECMsg, updates index.
        /// </summary>
        public ECMsg GetOut()
        {
        	ECMsg r = null;
        	if (myECMsgs != null)
        	{
        		r = myECMsgs[myIdx];
        		if (++myIdx >= myECMsgs.Length)
        		{
        			myIdx = 0;
        		}
        	}
        	return r;
        }

        /// <summary>
        /// Get out the ECMsg at the index, updates index.
        /// </summary>
        public ECMsg GetOut(int at)
        {
            ECMsg r = null;
            if ((myECMsgs != null) && (at <= (myECMsgs.Length - 1)))
            {
                myIdx = at;
                r = GetOut();
            }
            return r;
        }

        /// <summary>
        /// Get out multiple ECMsgs; silently wraps around.
        /// </summary>
        public ECMsg[] GetOut(int quant, int at)
        {
        	ECMsg[] r = null;
            if ((myECMsgs != null) && (quant <= myECMsgs.Length) && (at <= (myECMsgs.Length - 1)))
            {
                r = new ECMsg[quant];
                myIdx = at;
                for (int i = 0; i < quant; i++)
                {
                    r[i] = GetOut();
                }
            }
            if ((myECMsgs != null) && (quant <= myECMsgs.Length))
            {
        	}
        	return r;
        }
        
        /// <summary>
        /// Get out ECMsgs.  May return less than quant; never wrapsaround.
        /// </summary>
        public ECMsg[] GetOut(int quant, int at, ref bool wouldwrap)
        {
        	ECMsg[] r = null;
            wouldwrap = false;
            if ((myECMsgs != null) && (quant <= myECMsgs.Length) && (at <= (myECMsgs.Length - 1)))
            {
                r = new ECMsg[quant];
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

