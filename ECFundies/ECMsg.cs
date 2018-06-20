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
    /// Encapsulate a request and reply, but is NOT a complete creational.
    /// Access the fields directly.  Yes, that's dangerous, but lower overhead.
    /// </summary>
    public class ECMsg
    {
        public DaK K = null;  // null is unknown, non-null begins the journey
        public char Tag = '?';  // 'S'et, 'G'et, 'U'nsolicited, '?'unknown
        public char Stat = '?';  // '?'unknown, receive 'T'imeout, s'Y'nc err, chec'K'sum err,  transmit & receive 'C'omplete
        public byte[] ReqMsg = null;
        public byte[] RplyMsg = null;

        public ECMsg(DaK k)
        {
            K = k;
        }

        public void SetUp(char tag, int reqlen, int rplylen)
        {
            Tag = tag;
            ReqMsg = new byte[reqlen];
            RplyMsg = new byte[rplylen];
        }

    }

}

