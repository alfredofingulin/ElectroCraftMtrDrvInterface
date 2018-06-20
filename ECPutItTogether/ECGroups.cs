// An ECGroups definition.  
// Use this as a templete to create your own.
// Your app will have it's own names and definitions.

using System;
using System.Collections.Generic;
using ECFundies;

namespace ECPutItTogether
{

    /// <summary>
    /// Loookit the namespace.
    /// </remarks>
    public static class ECGroups
    {
        public static ECGroup None = new ECGroup(
            0, "None",
            null );
        public static ECGroup LeftRight = new ECGroup(
            1, "LeftRight", 
            new ECAxis[] { ECAxises.X, ECAxises.Xpri } );
    }
}

