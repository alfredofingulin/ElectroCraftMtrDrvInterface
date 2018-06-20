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
    /// Build messages to Set/Get 16-bit data in memory,
    /// where the itemnum is the memory location.
    /// </summary>
    public class ECMB16Mem : ECMBBase
    {

        public ECMB16Mem(ECItem item)
            : base(item)
        {
        }
		
		public ECMB16Mem(ECItem item, uint defaultaxis)
			: base(item, defaultaxis)
		{
		}

        public override void SetCreate(ref ECMsg m, uint rawdata)
        {
            m.SetUp('S', 10, 1);
            m.ReqMsg[0] = 8;  // length
            Msger.AddAxis(m.K.Axis.Num, out m.ReqMsg[1], out m.ReqMsg[2]);
            Msger.AddData(0x9004, out m.ReqMsg[3], out m.ReqMsg[4]);  // Opcode
            Msger.AddData(myItem.Num, out m.ReqMsg[5], out m.ReqMsg[6]);  // Address is myItem.Num
            Msger.AddData(rawdata, out m.ReqMsg[7], out m.ReqMsg[8]);
            m.ReqMsg[9] = Msger.Chksum(m.ReqMsg);
            m.RplyMsg[0] = 0;  // clear reply for safety
        }
        public override void SetCreate(ref ECMsg m, int gquant, uint rawdata)
        {
            m.SetUp('S', 10, 1);
            m.ReqMsg[0] = 8;  // length
            Msger.AddGroup(m.K.Group.Num, out m.ReqMsg[1], out m.ReqMsg[2]);
            Msger.AddData(0x9004, out m.ReqMsg[3], out m.ReqMsg[4]);  // Opcode
            Msger.AddData(myItem.Num, out m.ReqMsg[5], out m.ReqMsg[6]);  // Address is myItem.Num
            Msger.AddData(rawdata, out m.ReqMsg[7], out m.ReqMsg[8]);
            m.ReqMsg[9] = Msger.Chksum(m.ReqMsg);
            m.RplyMsg[0] = 0;  // clear reply for safety
        }

        public override void GetCreate(ref ECMsg m)
        {
            m.SetUp('G', 10, 1 + 12);
            m.ReqMsg[0] = 8;  // length
            Msger.AddAxis(m.K.Axis.Num, out m.ReqMsg[1], out m.ReqMsg[2]);
            Msger.AddData(0xB004, out m.ReqMsg[3], out m.ReqMsg[4]);  // Opcode
            Msger.AddHost(myAxis, out m.ReqMsg[5], out m.ReqMsg[6]);  // host/relay axis
            Msger.AddData(myItem.Num, out m.ReqMsg[7], out m.ReqMsg[8]);  // Address is myItem.Num
            m.ReqMsg[9] = Msger.Chksum(m.ReqMsg);
            m.RplyMsg[0] = 0;  // clear reply for safety
        }
        public override void GetCreate(ref ECMsg m, int gquant)
        {
            m.SetUp('G', 10, 1 + (gquant * 12));
            m.ReqMsg[0] = 8;  // length
            Msger.AddGroup(m.K.Group.Num, out m.ReqMsg[1], out m.ReqMsg[2]);
            Msger.AddData(0xB004, out m.ReqMsg[3], out m.ReqMsg[4]);  // Opcode
            Msger.AddHost(myAxis, out m.ReqMsg[5], out m.ReqMsg[6]);  // host/relay axis
            Msger.AddData(myItem.Num, out m.ReqMsg[7], out m.ReqMsg[8]);  // Address is myItem.Num
            m.ReqMsg[9] = Msger.Chksum(m.ReqMsg);
            m.RplyMsg[0] = 0;  // clear reply for safety
        }
        public override void GetRawdata(ref ECMsg m, int offsetinrply, out uint rawdata)
        {
            rawdata = Msger.RemData(m.RplyMsg[offsetinrply + 9], m.RplyMsg[offsetinrply + 10]);
        }

    }

}

