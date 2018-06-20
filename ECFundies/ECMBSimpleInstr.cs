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
    /// Build messages to execute simple instructions,
    /// where the itemnum is the instruction.
    /// </summary>
    public class ECMBSimpleInstr : ECMBBase
    {

        public ECMBSimpleInstr(ECItem item)
            : base(item)
        {
        }

		public ECMBSimpleInstr(ECItem item, uint defaultaxis)
			: base(item, defaultaxis)
		{
		}

        public override void SetCreate(ref ECMsg m, uint rawdata)
        {
            m.SetUp('S', 6, 1);
            m.ReqMsg[0] = 4;  // length
            Msger.AddAxis(m.K.Axis.Num, out m.ReqMsg[1], out m.ReqMsg[2]);
            Msger.AddData(myItem.Num, out m.ReqMsg[3], out m.ReqMsg[4]);  // Opcode is myItem.Num
            m.ReqMsg[5] = Msger.Chksum(m.ReqMsg);
            m.RplyMsg[0] = 0;  // clear reply for safety
        }
        public override void SetCreate(ref ECMsg m, int gquant, uint rawdata)
        {
            m.SetUp('S', 6, 1);
            m.ReqMsg[0] = 4;  // length
            Msger.AddGroup(m.K.Group.Num, out m.ReqMsg[1], out m.ReqMsg[2]);
            Msger.AddData(myItem.Num, out m.ReqMsg[3], out m.ReqMsg[4]);  // Opcode is myItem.Num
            m.ReqMsg[5] = Msger.Chksum(m.ReqMsg);
            m.RplyMsg[0] = 0;  // clear reply for safety
        }

        // there are no Get equivelents, so these are not overridden.

    }

}

