// Here's where group, axis, data item, and sub data items are tied together.
// Use this as a templete to create your own.
// Your app will have it's own names and definitions.

using System;
using System.Collections.Generic;
using ECFundies;

namespace ECPutItTogether
{

    /// <summary>
    /// Nothing but keys and property names for the wall sheathing machine app.
    /// Namespace is a hint.
    /// </summary>
    public static class DaKs
    {

        public static DaK X_Func = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.INDEXVALUE, "Func");
        public static DaK Xpri_Func = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.INDEXVALUE, "Func");
        public static DaK Y_Func = new DaK(ECGroups.None, ECAxises.Y, ECItems.INDEXVALUE, "Func");
        public static DaK X_StM = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.STARTMOTION, "StM");
        public static DaK Xpri_StM = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.STARTMOTION, "StM");
        public static DaK Y_StM = new DaK(ECGroups.None, ECAxises.Y, ECItems.STARTMOTION, "StM");
        public static DaK X_Move = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.MOVEDISTANCEVALUE, "Move");
        public static DaK Xpri_Move = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.MOVEDISTANCEVALUE, "Move");
        public static DaK Y_Move = new DaK(ECGroups.None, ECAxises.Y, ECItems.MOVEDISTANCEVALUE, "Move");

        public static DaK X_Wall_Len = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.WallDim, "Wall_Len");
        public static DaK Xpri_Wall_Len = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.WallDim, "Wall_Len");
        public static DaK Y_Wall_Hgt = new DaK(ECGroups.None, ECAxises.Y, ECItems.WallDim, "Wall_Hgt");
        public static DaK X_Stitch = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.FireSpacing, "Stitch");
        public static DaK Xpri_Stitch = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.FireSpacing, "Stitch");
        public static DaK Y_Field = new DaK(ECGroups.None, ECAxises.Y, ECItems.FireSpacing, "Field");
        // deprecated public static DaK Wall_Len = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.WallDim, "Wall_Len");
        // deprecated public static DaK Wall_Len_Xpri = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.WallDim, "Wall_Len");
        // deprecated public static DaK Wall_Hgt = new DaK(ECGroups.None, ECAxises.Y, ECItems.WallDim, "Wall_Hgt");
        // deprecated public static DaK Stitch = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.FireSpacing, "Stitch");
        // deprecated public static DaK Stitch_Xpri = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.FireSpacing, "Stitch");
        // deprecated public static DaK Field = new DaK(ECGroups.None, ECAxises.Y, ECItems.FireSpacing, "Field");

        public static DaK X_Sys_Cfg = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.SYSTEMCONFIG, "Sys_Cfg",
            new[] {
                "StitcherArm",
                "TopStitcher",
                "BottomStitcher",
                "BSFM",
                "TSFM",
                "BSUD",
                "TSUD",
                "MdFS"
            }
            );
        public static DaK Xpri_Sys_Cfg = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.SYSTEMCONFIG, "Sys_Cfg",
            new[] {
                "StitcherArm",
                "TopStitcher",
                "BottomStitcher",
                "BSFM",
                "TSFM",
                "BSUD",
                "TSUD",
                "MdFS"
            }
            );
        public static DaK Y_Sys_Cfg = new DaK(ECGroups.None, ECAxises.Y, ECItems.SYSTEMCONFIG, "Sys_Cfg",
            new[] {
                "FieldJoinMode",
                "SeamJoinMode",
                "BSFM",
                "TSFM",
                "BSUD",
                "TSUD",
                "MdFS"
            }
            );
        public static DaK X_Bridg_Spd = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.AXISSPEED, "Bridg_Spd");
        public static DaK Xpri_Bridg_Spd = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.AXISSPEED, "Bridg_Spd");
        public static DaK Y_Crg_Spd = new DaK(ECGroups.None, ECAxises.Y, ECItems.AXISSPEED, "Crg_Spd");
        public static DaK X_Sys_St = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.SYSTEMSTATE, "Sys_St",
            new[] {
                "BRF",
                "TRF",
                "BUD",
                "TUD"
            }
            );
        public static DaK Xpri_Sys_St = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.SYSTEMSTATE, "Sys_St",
            new[] {
                "BRF",
                "TRF",
                "BUD",
                "TUD"
            }
            );
        public static DaK Y_Sys_St = new DaK(ECGroups.None, ECAxises.Y, ECItems.SYSTEMSTATE, "Sys_St",
            new[] {
                "CUP",
                "FSRF",
                "FSUD",
                "FSDi"
            }
            );
        public static DaK Y_Seams = new DaK(ECGroups.None, ECAxises.Y, ECItems.SEAMSPACING, "Seams");
        public static DaK Y_F1st_Nail = new DaK(ECGroups.None, ECAxises.Y, ECItems.FIRSTNAILLOC, "F1st_Nail");
        // deprecated public static DaK Sys_Cfg = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.SYSTEMCONFIG, "Sys_Cfg",
        // deprecated     new[] {
        // deprecated     "StitcherArm",
        // deprecated     "TopStitcher",
        // deprecated     "BottomStitcher",
        // deprecated     "BtmStiFM",
        // deprecated     "TopStiFM",
        // deprecated     "BtmStiUD",
        // deprecated     "TopStiUD",
        // deprecated     "JnMdFS"
        // deprecated     }
        // deprecated     );
        // deprecated public static DaK Sys_Cfg_Xpri = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.SYSTEMCONFIG, "Sys_Cfg",
        // deprecated     new[] {
        // deprecated     "StitcherArm",
        // deprecated     "TopStitcher",
        // deprecated     "BottomStitcher",
        // deprecated     "BtmStiFM",
        // deprecated     "TopStiFM",
        // deprecated     "BtmStiUD",
        // deprecated     "TopStiUD",
        // deprecated     "JnMdFS"
        // deprecated     }
        // deprecated     );
        // deprecated public static DaK Sys_Cfg_Y = new DaK(ECGroups.None, ECAxises.Y, ECItems.SYSTEMCONFIG, "Sys_Cfg",
        // deprecated     new[] {
        // deprecated     "StitcherArm",
        // deprecated     "TopStitcher",
        // deprecated     "BottomStitcher",
        // deprecated     "BtmStiFM",
        // deprecated     "TopStiFM",
        // deprecated     "BtmStiUD",
        // deprecated     "TopStiUD",
        // deprecated     "JnMdFS"
        // deprecated     }
        // deprecated     );
        // deprecated public static DaK Bridg_Spd = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.AXISSPEED, "Bridg_Spd");
        // deprecated public static DaK Bridg_Spd_Xpri = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.AXISSPEED, "Bridg_Spd");
        // deprecated public static DaK Crg_Spd = new DaK(ECGroups.None, ECAxises.Y, ECItems.AXISSPEED, "Crg_Spd");
        // deprecated public static DaK Sys_St = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.SYSTEMSTATE, "Sys_St",
        // deprecated     new[] {
        // deprecated     "BtmRF",
        // deprecated     "TopRF",
        // deprecated     "BtmUD",
        // deprecated     "TopUD"
        // deprecated     }
        // deprecated     );
        // deprecated public static DaK Sys_St_Xpri = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.SYSTEMSTATE, "Sys_St",
        // deprecated     new[] {
        // deprecated     "BtmRF",
        // deprecated     "TopRF",
        // deprecated     "BtmUD",
        // deprecated     "TopUD"
        // deprecated     }
        // deprecated     );
        // deprecated public static DaK Sys_St_Y = new DaK(ECGroups.None, ECAxises.Y, ECItems.SYSTEMSTATE, "Sys_St",
        // deprecated     new[] {
        // deprecated     "CrgdUP",
        // deprecated     "FSM",
        // deprecated     "FSUD",
        // deprecated     "FSDi"
        // deprecated     }
        // deprecated     );
        // deprecated public static DaK Seams = new DaK(ECGroups.None, ECAxises.Y, ECItems.FireSpacing, "Seams");
        // deprecated public static DaK F1st_Nail = new DaK(ECGroups.None, ECAxises.Y, ECItems.FIRSTNAILLOC, "F1st_Nail");

        public static DaK X_SR32 = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.SR32, "SR32",
            new[] {
                "SR32forEstop",
                "Rdy",
                "SwOn",
                "OpEn",
                "SFlt",
                "MtPw",
                "QStp",
                "SwOnD",
                "MPLW",
                "MPLE",
                "R09",
                "MCmp",
                "IntLt",
                "OpML",
                "OpMH",
                "LEvt",
                "AxisOn",
                "EndI",
                "PT1",
                "PT2",
                "PT3",
                "PT4",
                "AuRu",
                "LSwP",
                "LSwN",
                "PCaps",
                "TrGr",
                "I2TMt",
                "I2TDr",
                "InGr",
                "FrzCt",
                "InCam",
                "DrvFlt"
            },
            new[] {
                "Estop"
            }
            );
        public static DaK Xpri_SR32 = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.SR32, "SR32",
            new[] {
                "SR32forEstop",
                "Rdy",
                "SwOn",
                "OpEn",
                "SFlt",
                "MtPw",
                "QStp",
                "SwOnD",
                "MPLW",
                "MPLE",
                "R09",
                "MCmp",
                "IntLt",
                "OpML",
                "OpMH",
                "LEvt",
                "AxisOn",
                "EndI",
                "PT1",
                "PT2",
                "PT3",
                "PT4",
                "AuRu",
                "LSwP",
                "LSwN",
                "PCaps",
                "TrGr",
                "I2TMt",
                "I2TDr",
                "InGr",
                "FrzCt",
                "InCam",
                "DrvFlt"
            },
            new[] {
                "Estop"
            }
            );
        public static DaK Y_SR32 = new DaK(ECGroups.None, ECAxises.Y, ECItems.SR32, "SR32",
            new[] {
                "SR32forEstop",
                "Rdy",
                "SwOn",
                "OpEn",
                "SFlt",
                "MtPw",
                "QStp",
                "SwOnD",
                "MPLW",
                "MPLE",
                "R09",
                "MCmp",
                "IntLt",
                "OpML",
                "OpMH",
                "LEvt",
                "AxisOn",
                "EndI",
                "PT1",
                "PT2",
                "PT3",
                "PT4",
                "AuRu",
                "LSwP",
                "LSwN",
                "PCaps",
                "TrGr",
                "I2TMt",
                "I2TDr",
                "InGr",
                "FrzCt",
                "InCam",
                "DrvFlt"
            },
            new[] {
                "Estop"
            }
            );

        // deprecated public static DaK X_SRH = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.SRH, "SRH");
        // deprecated public static DaK X_SRL = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.SRL, "SRL");
        // deprecated public static DaK Xpri_SRH = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.SRH, "SRH");
        // deprecated public static DaK Xpri_SRL = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.SRL, "SRL");
        // deprecated public static DaK Y_SRH = new DaK(ECGroups.None, ECAxises.Y, ECItems.SRH, "SRH");
        // deprecated public static DaK Y_SRL = new DaK(ECGroups.None, ECAxises.Y, ECItems.SRL, "SRL");

        public static DaK X_Dig_In = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.DIGIN_STATUS, "Dig_In",
            new[] {
                "LSw1",
                "ARS",
                "ARStp"
            }
            );
        public static DaK Xpri_Dig_In = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.DIGIN_STATUS, "Dig_In",
            new[] {
                "LSw2"
            }
            );
        public static DaK Y_Dig_In = new DaK(ECGroups.None, ECAxises.Y, ECItems.DIGIN_STATUS, "Dig_In",
            new[] {
                "JyRL",
                "JyS",
                "JyStp",
                "JyCmd"
            }
            );
        public static DaK X_Dig_Out = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.DIGOUT_STATUS, "Dig_Out",
            new[] {
                "StFi",
                "StBk",
                "StRL",
                "Horn"
            }
            );
        public static DaK Xpri_Dig_Out = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.DIGOUT_STATUS, "Dig_Out",
            new[] {
                "StFi",
                "StBk",
                "StRL"
            }
            );
        public static DaK Y_Dig_Out = new DaK(ECGroups.None, ECAxises.Y, ECItems.DIGOUT_STATUS, "Dig_Out",
            new[] {
                "FSFi",
                "FSBk",
                "FSRL"
            }
            );
        public static DaK X_MER = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.MER, "MER",
            new[] {
                "MERforEstop",
                "CANE",
                "Shrt",
                "SetE",
                "CtlE",
                "ComE",
                "MtPoW",
                "PLSw",
                "NLSw",
                "OvrI",
                "I2T",
                "MOvrT",
                "DOvrT",
                "OvrV",
                "UndV",
                "CmdE",
                "DisIn"
            },
            new[] {
                "Estop"
            }
            );
        public static DaK Xpri_MER = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.MER, "MER",
            new[] {
                "MERforEstop",
                "CANE",
                "Shrt",
                "SetE",
                "CtlE",
                "ComE",
                "MtPoW",
                "PLSw",
                "NLSw",
                "OvrI",
                "I2T",
                "MOvrT",
                "DOvrT",
                "OvrV",
                "UndV",
                "CmdE",
                "DisIn"
            },
            new[] {
                "Estop"
            }
            );
        public static DaK Y_MER = new DaK(ECGroups.None, ECAxises.Y, ECItems.MER, "MER",
            new[] {
                "MERforEstop",
                "CANE",
                "Shrt",
                "SetE",
                "CtlE",
                "ComE",
                "MtPoW",
                "PLSw",
                "NLSw",
                "OvrI",
                "I2T",
                "MOvrT",
                "DOvrT",
                "OvrV",
                "UndV",
                "CmdE",
                "DisIn"
            },
            new[] {
                "Estop"
            }
           );
        public static DaK X_MER_Msk = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.MER_MASK, "MER_Msk");
        public static DaK Xpri_MER_Msk = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.MER_MASK, "MER_Msk");
        public static DaK Y_MER_Msk = new DaK(ECGroups.None, ECAxises.Y, ECItems.MER_MASK, "MER_Msk");
        public static DaK X_Drv_Err = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.DER, "Drv_Err");
        public static DaK Xpri_Drv_Err = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.DER, "Drv_Err");
        public static DaK Y_Drv_Err = new DaK(ECGroups.None, ECAxises.Y, ECItems.DER, "Drv_Err");

        public static DaK X_Bridg_Loc = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.APOS, "Bridg_Loc");
        public static DaK Xpri_Bridg_Loc = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.APOS, "Bridg_Loc");
        public static DaK Y_Crg_Loc = new DaK(ECGroups.None, ECAxises.Y, ECItems.APOS, "Crg_Loc");
        public static DaK X_Bridg_Pos_Err = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.POSERR, "Bridg_Pos_Err");
        public static DaK Xpri_Bridg_Pos_Err = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.POSERR, "Bridg_Pos_Err");
        public static DaK Y_Crg_Pos_Err = new DaK(ECGroups.None, ECAxises.Y, ECItems.POSERR, "Crg_Pos_Err");
        // deprecated public static DaK Bridg_Loc = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.APOS, "Bridg_Loc");
        // deprecated public static DaK Bridg_Loc_Xpri = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.APOS, "Bridg_Loc");
        // deprecated public static DaK Crg_Loc = new DaK(ECGroups.None, ECAxises.Y, ECItems.APOS, "Crg_Loc");
        // deprecated public static DaK Bridg_Pos_Err = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.POSERR, "Bridg_Pos_Err");
        // deprecated public static DaK Bridg_Pos_Err_Xpri = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.POSERR, "Bridg_Pos_Err");
        // deprecated public static DaK Crg_Pos_Err = new DaK(ECGroups.None, ECAxises.Y, ECItems.POSERR, "Crg_Pos_Err");

        public static DaK X_Mtr_I = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.IQ, "Mtr_I");
        public static DaK Xpri_Mtr_I = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.IQ, "Mtr_I");
        public static DaK Y_Mtr_I = new DaK(ECGroups.None, ECAxises.Y, ECItems.IQ, "Mtr_I");
        public static DaK X_Mtr_S = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.AD4, "Mtr_S");
        public static DaK Xpri_Mtr_S = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.AD4, "Mtr_S");
        public static DaK Y_Mtr_S = new DaK(ECGroups.None, ECAxises.Y, ECItems.AD4, "Mtr_S");
        public static DaK X_Drv_Tmp = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.AD7, "Drv_Tmp");
        public static DaK Xpri_Drv_Tmp = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.AD7, "Drv_Tmp");
        public static DaK Y_Drv_Tmp = new DaK(ECGroups.None, ECAxises.Y, ECItems.AD7, "Drv_Tmp");
        public static DaK X_Ref = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.UQREF, "Ref");
        public static DaK Xpri_Ref = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.UQREF, "Ref");
        public static DaK Y_Ref = new DaK(ECGroups.None, ECAxises.Y, ECItems.UQREF, "Ref");

        public static DaK X_Bridg_Joy = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.AD5, "Bridg_Joy");
        public static DaK Xpri_Bridg_Joy = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.AD5, "Bridg_Joy");
        public static DaK Y_Crg_Joy = new DaK(ECGroups.None, ECAxises.Y, ECItems.AD5, "Crg_Joy");
        // deprecated public static DaK Bridg_Joy = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.AD5, "Bridg_Joy");
        // deprecated public static DaK Joy_Xpri = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.AD5, "Joy");
        // deprecated public static DaK Crg_Joy = new DaK(ECGroups.None, ECAxises.Y, ECItems.AD5, "Crg_Joy");

        public static DaK X_AxisOn = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.AXISON, "AxisOn");
        public static DaK Xpri_AxisOn = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.AXISON, "AxisOn");
        public static DaK Y_AxisOn = new DaK(ECGroups.None, ECAxises.Y, ECItems.AXISON, "AxisOn");
        public static DaK X_AxisOff = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.AXISOFF, "AxisOff");
        public static DaK Xpri_AxisOff = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.AXISOFF, "AxisOff");
        public static DaK Y_AxisOff = new DaK(ECGroups.None, ECAxises.Y, ECItems.AXISOFF, "AxisOff");
        public static DaK X_Reset = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.RESET, "Reset");
        public static DaK Xpri_Reset = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.RESET, "Reset");
        public static DaK Y_Reset = new DaK(ECGroups.None, ECAxises.Y, ECItems.RESET, "Reset");
        public static DaK X_HomePos = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.HOMEPOS, "HomePos");
        public static DaK X_CSPD = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.CSPD, "CSPD");
        public static DaK X_CACC = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.CACC, "CACC");
        public static DaK X_CDEC = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.CDEC, "CDEC");
        public static DaK X_AxisAccel = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.AxisAccel, "AxisAccel");
        public static DaK X_CPOS = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.CPOS, "CPOS");
        public static DaK X_TPOS = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.TPOS, "TPOS");
        public static DaK X_TSPD = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.TSPD, "TSPD");
        public static DaK X_TACC = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.TACC, "TACC");
        public static DaK X_POSTRIGG1 = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.POSTRIGG1, "POSTRIGG1");
        public static DaK Xpri_HomePos = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.HOMEPOS, "HomePos");
        public static DaK Xpri_CSPD = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.CSPD, "CSPD");
        public static DaK Xpri_CACC = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.CACC, "CACC");
        public static DaK Xpri_CDEC = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.CDEC, "CDEC");
        public static DaK Xpri_AxisAccel = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.AxisAccel, "AxisAccel");
        public static DaK Xpri_CPOS = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.CPOS, "CPOS");
        public static DaK Xpri_TPOS = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.TPOS, "TPOS");
        public static DaK Xpri_TSPD = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.TSPD, "TSPD");
        public static DaK Xpri_TACC = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.TACC, "TACC");
        public static DaK Xpri_POSTRIGG1 = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.POSTRIGG1, "POSTRIGG1");
        public static DaK Y_HomePos = new DaK(ECGroups.None, ECAxises.Y, ECItems.HOMEPOS, "HomePos");
        public static DaK Y_CSPD = new DaK(ECGroups.None, ECAxises.Y, ECItems.CSPD, "CSPD");
        public static DaK Y_CACC = new DaK(ECGroups.None, ECAxises.Y, ECItems.CACC, "CACC");
        public static DaK Y_CDEC = new DaK(ECGroups.None, ECAxises.Y, ECItems.CDEC, "CDEC");
        public static DaK Y_AxisAccel = new DaK(ECGroups.None, ECAxises.Y, ECItems.AxisAccel, "AxisAccel");
        public static DaK Y_CPOS = new DaK(ECGroups.None, ECAxises.Y, ECItems.CPOS, "CPOS");
        public static DaK Y_TPOS = new DaK(ECGroups.None, ECAxises.Y, ECItems.TPOS, "TPOS");
        public static DaK Y_TSPD = new DaK(ECGroups.None, ECAxises.Y, ECItems.TSPD, "TSPD");
        public static DaK Y_TACC = new DaK(ECGroups.None, ECAxises.Y, ECItems.TACC, "TACC");
        public static DaK Y_POSTRIGG1 = new DaK(ECGroups.None, ECAxises.Y, ECItems.POSTRIGG1, "POSTRIGG1");
        public static DaK X_ProgramRev = new DaK(ECGroups.LeftRight, ECAxises.X, ECItems.PROGRAMREV, "ProgramRev");
        public static DaK Xpri_ProgramRev = new DaK(ECGroups.LeftRight, ECAxises.Xpri, ECItems.PROGRAMREV, "ProgramRev");
        public static DaK Y_ProgramRev = new DaK(ECGroups.None, ECAxises.Y, ECItems.PROGRAMREV, "ProgramRev");

    }

}

