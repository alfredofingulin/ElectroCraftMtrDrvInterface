// An ECItems definition.  
// Use this as a templete to create your own.
// Your app will have it's own names and definitions.

using System;
using ECFundies;

namespace ECPutItTogether
{

    /// <summary>
    /// Note the namespace.
    /// </summary>
    public static class ECItems
    {
        // Note some are duplicated with different names peculiar to an axis.
        public static ECItem INDEXVALUE = new ECItem("INDEXVALUE", 0x03B0);  // Set [X X'] [Y] Get [X] [X'] [Y] | 16 bits | 
        public static ECItem STARTMOTION = new ECItem("STARTMOTION", 0x03B1);  // Set [X X'] [Y] Get [X] [X'] [Y] | 32 bits | 
        public static ECItem MOVEDISTANCEVALUE = new ECItem("MOVEDISTANCEVALUE", 0x03B3);  // Set [X X'] [Y] Get [X] [X'] [Y] | 32 bits | 
        public static ECItem WallDim = new ECItem("WallDim", 0x03B5);  // Set [X X'] Get [X] [X'] | 32 bits | *old set/get | X X' Y common name used only for messages; WALLLENGTH and WALLHEIGHT will work too.
        public static ECItem FireSpacing = new ECItem("FireSpacing", 0x03B7);  // Set [X X'] Get [X] [X'] | 32 bits | *old set/get | X X' Y common name used only for messages); STITCHERSPACING and FIELDSPACING will work too.
        public static ECItem SYSTEMCONFIG = new ECItem("SYSTEMCONFIG", 0x03B9);  // Set [X X'] [Y] Get [X] [X'] [Y] | 16 bits | 
        public static ECItem AXISSPEED = new ECItem("AXISSPEED", 0x03BC);  // Set [X X'] [Y] Get [X] [X'] [Y] | 32 bits (signif16.frac16) | *old set/get
        public static ECItem SYSTEMSTATE = new ECItem("SYSTEMSTATE", 0x03BE);  // Set [X X'] [Y] Get [X] [X'] [Y] | 16 bits | 
        public static ECItem SEAMSPACING = new ECItem("SEAMSPACING", 0x03C1);  // Set [Y] Get [Y] | 32 bits | *old not implemented
        public static ECItem FIRSTNAILLOC = new ECItem("FIRSTNAILLOC", 0x03C3);  // Set [Y] Get [Y] | 32 bits | *old set/get
        public static ECItem PROGRAMREV = new ECItem("PROGRAMREV", 0x03BF);  // Set [no] Get [X] [X'] [Y] | 32 bits | *old set/get
        // These are common to all EC motion control programs.
        // We use 'em, but configuration is peculiar to an axis (eg DIG*, AD5 joystick...)
        public static ECItem SR32 = new ECItem("SR32", 0x090E);  // Set [no] Get [X] [X'] [Y] | 32 bits | *old set/get
        public static ECItem SRL = new ECItem("SRL", 0x010E);  // 16 bits data  *old set/get  unsolicited only
        public static ECItem SRH = new ECItem("SRH", 0x010F);  // 16 bits data  *old set/get  unsolicited only
        public static ECItem DIGIN_STATUS = new ECItem("DIGIN_STATUS", 0x0908);  // Set [no] Get [X] [X'] [Y] | 16 bits | *old set/get
        public static ECItem DIGOUT_STATUS = new ECItem("DIGOUT_STATUS", 0x09B8);  // Set [no] Get [X] [X'] [Y] | 16 bits | *old set/get
        public static ECItem MER = new ECItem("MER", 0x08FC);  // Set [no] Get [X] [X'] [Y] | 16 bits | *old set/get
        public static ECItem MER_MASK = new ECItem("MER_MASK", 0x0965);  // Set [X] [X'] [Y] Get [X] [X'] [Y] | 16 bits | 
        public static ECItem DER = new ECItem("DER", 0x03AD);  // Set [no] Get [X] [X'] [Y] | 16 bits | 
        public static ECItem APOS = new ECItem("APOS", 0x0228);  // Set [no] Get [X] [X'] [Y] | 32 bits | *old set/get
        public static ECItem POSERR = new ECItem("POSERR", 0x022A);  // Set [no] Get [X] [X'] [Y] | 16 bits | 
        public static ECItem IQ = new ECItem("IQ", 0x0230);  // Set [no] Get [X] [X'] [Y] | 16 bits | Motor_Current | *old set/get
        public static ECItem AD4 = new ECItem("AD4", 0x0240);  // Set [no] Get [X] [X'] [Y] | 16 bits | DC_Supply_Motor | *old set/get
        public static ECItem AD7 = new ECItem("AD7", 0x0243);  // Set [no] Get [X] [X'] [Y] | 16 bits | Drive_Temperature | *old set/get
        public static ECItem UQREF = new ECItem("UQREF", 0x0232);  // Set [no] Get [X] [X'] [Y] | 16 bits | Voltage_Reference
        public static ECItem AD5 = new ECItem("AD5", 0x0241);  // Set [no] Get [X] [X'] [Y] | 16 bits | joystick, Analogue_Input | *old set/get
        public static ECItem CSPD = new ECItem("CSPD", 0x02A0);  // Set [?] Get [X] [X'] [Y] | 32 bits (signif16.frac16) | some kind of speed | static
        public static ECItem CACC = new ECItem("CACC", 0x02A2);  // Set [?] Get [X] [X'] [Y] | 32 bits (signif16.frac16) | some kind of acceleration | static
        public static ECItem CDEC = new ECItem("CDEC", 0x0858);  // Set [?] Get [X] [X'] [Y] | 32 bits (signif16.frac16) | some kind of decceleration | static
        public static ECItem AxisAccel = new ECItem("AxisAccel", 0x03BA);  // Set [?] Get [X] [X'] [Y] | 32 bits (signif16.frac16) | some kind of speed | static
        public static ECItem HOMEPOS = new ECItem("HOMEPOS", 0x0992);  // Set [?] Get [X] [X'] [Y] | 32 bits | where the axis thinks home is, in counts | static
        public static ECItem CPOS = new ECItem("CPOS", 0x029E);  // Set [?] Get [X] [X'] [Y] | 32 bits | a position? | dynamic
        public static ECItem TPOS = new ECItem("TPOS", 0x02B2);  // Set [?] Get [X] [X'] [Y] | 32 bits | target position | dynamic
        public static ECItem TSPD = new ECItem("TSPD", 0x02B4);  // Set [?] Get [X] [X'] [Y] | 32 bits (signif16.frac16) | target speed | dynamic
        public static ECItem TACC = new ECItem("TACC", 0x02B6);  // Set [?] Get [X] [X'] [Y] | 32 bits (signif16.frac16) | target acceleration | dynamic
        public static ECItem POSTRIGG1 = new ECItem("POSTRIGG1", 0x091A);  // Set [?] Get [X] [X'] [Y] | 32 bits | nail fire position | dynamic
        // These are drive "instructions".
        public static ECItem AXISON = new ECItem("AXISON", 0x0102);  // Drive "instruction."
        public static ECItem AXISOFF = new ECItem("AXISOFF", 0x0002);  // Drive "instruction."
        public static ECItem RESET = new ECItem("RESET", 0x0402);  // Drive "instruction."

    }

}

