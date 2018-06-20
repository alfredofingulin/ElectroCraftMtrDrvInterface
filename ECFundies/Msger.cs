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
    /// Handy thing to tear up/down ElectroCraft message data aka byte streams.
    /// </summary>
    public static class Msger
    {
        public static void AddGroup(uint group, out byte h, out byte l)
        {
            h = (byte)(0x10 | ((group >> 4) & 0x0000000F));
            l = (byte)((group << 4) & 0x000000F0);
        }
        public static void AddAxis(uint axis, out byte h, out byte l)
        {
            h = (byte)((axis >> 4) & 0x0000000F);
            l = (byte)((axis << 4) & 0x000000F0);
        }
        public static void AddHost(uint hostaxis, out byte h, out byte l)
        {
            h = (byte)((hostaxis >> 4) & 0x0000000F);
            l = (byte)(0x01 | ((hostaxis << 4) & 0x000000F0));
        }
        public static uint GroupOf(byte h, byte l)
        {
            if ((h & 0x10) > 0)
            {
                return (((((uint)h)) << 4) & 0x000000F0) | ((((uint)l) >> 4) & 0x0000000F);
            }
            else
            {
                return 0;
            }
        }
        public static uint AxisOf(byte h, byte l)
        {
            if ((h & 0x10) == 0)
            {
                return (((((uint)h)) << 4) & 0x000000F0) | ((((uint)l) >> 4) & 0x0000000F);
            }
            else
            {
                return 0;
            }
        }
        public static uint HostOf(byte h, byte l)
        {
            if ((l & 0x01) > 0)
            {
                return (((((uint)h)) << 4) & 0x000000F0) | ((((uint)l) >> 4) & 0x0000000F);
            }
            else
            {
                return 0;
            }
        }
        public static void AddData(uint d, out byte h, out byte l)
        {
            h = (byte)((d >> 8) & 0x000000FF);
            l = (byte)(d & 0x000000FF);
        }
        public static uint RemData(byte h, byte l)
        {
            uint t = ((((uint)h) << 8) & 0x0000FF00) | (((uint)l) & 0x000000FF);
            if (t >= 0x8000)
            {
                t |= 0xffff0000;
            }
            return (uint)t;
        }
        public static void AddData(uint d, out byte h, out byte hl, out byte lh, out byte l)
        {
            h = (byte)((d >> 24) & 0x000000FF);
            hl = (byte)((d >> 16) & 0x000000FF);
            lh = (byte)((d >> 8) & 0x000000FF);
            l = (byte)(d & 0x000000FF);
        }
        public static uint RemData(byte h, byte hl, byte lh, byte l)
        {
            uint t = (((uint)h) << 24) | ((((uint)hl) << 16) & 0x00FF0000) | ((((uint)lh) << 8) & 0x0000FF00) | (((uint)l) & 0x000000FF);
            return (uint)t;
        }
        public static byte Chksum(byte[] d)
        {
            return Chksum(d, 0);
        }
        public static byte Chksum(byte[] d, int offset)
        {
            byte c = 0;
            int e = d[offset] & 0x000000FF;
            for (int i = 0; i <= e; i++)
            {
                c += d[i + offset];
            }
            return c;
        }
    }

}

