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
    /// Handy thing to "key" ElectroCraft axis & item & property info.
    /// Key formation obvious from constructor.
    /// </summary>
    /// <remarks>
    /// </remarks>
    public class DaK
    {
        private ECGroup _group;
        private ECAxis _axis;
        private ECItem _item;
        private string _nam;
        private uint _key;
        private string[] _subPropNams = null;
        private string[] _compositePropNams = null;

        public ECGroup Group { get { return _group; } }
        public ECAxis Axis { get { return _axis; } }
        public ECItem Item { get { return _item; } }
        public string Nam { get { return _nam; } }
        public uint Key { get { return _key; } }
        public string PropNam
        {
        	get
            {
                return _axis.Nam + "_" + _nam;
        	}
        }
        public string[] SubPropNams { get { return _subPropNams; } }        
        public string[] CompositePropNams { get { return _compositePropNams; } }        

        public DaK(ECGroup group, ECAxis axis, ECItem item, string nam)
        {
            _group = group;
            _axis = axis;
            _item = item;
            _nam = nam;
            _key = KeyFrom(_group, _axis, _item);
        }

        public DaK(ECGroup group, ECAxis axis, ECItem item, string nam, string[] subpropnams)
        {
            _group = group;
            _axis = axis;
            _item = item;
            _nam = nam;
            _subPropNams = subpropnams;
            _key = KeyFrom(_group, _axis, _item);
        }

        public DaK(ECGroup group, ECAxis axis, ECItem item, string nam, string[] subpropnams, string[] compositepropnams)
        {
            _group = group;
            _axis = axis;
            _item = item;
            _nam = nam;
            _subPropNams = subpropnams;
            _compositePropNams = compositepropnams;
            _key = KeyFrom(_group, _axis, _item);
        }

        public static uint KeyFrom(ECGroup group, ECAxis axis, ECItem item)
        {
            return KeyFrom(group.Num, axis.Num, item.Num);
        }

        public static uint KeyFrom(uint group, uint axis, uint itemnum)
        {
            return (((group << 24) & 0x07000000) | ((axis << 16) & 0x00FF0000) | (itemnum & 0x0000FFFF));
        }

    }
}

