// An ECAxises definition.  
// Use this as a templete to create your own.
// Your app will have it's own names and definitions.

using System;
using ECFundies;

namespace ECPutItTogether
{
    /// <summary>
    /// Note the namespace.
    /// </summary>
    public static class ECAxises
    {
        public static ECAxis None = new ECAxis(0, "None");
        public static ECAxis OMI = new ECAxis(255, "HMI");
        public static ECAxis X = new ECAxis(1, "X");
        public static ECAxis Xpri = new ECAxis(2, "Xpri");
        public static ECAxis Y = new ECAxis(3, "Y");
        public static ECAxis Anon = new ECAxis(0xFFFFFFFE, "Anon");
        public static ECAxis All = new ECAxis(0xFFFFFFFF, "All");
    }
}

