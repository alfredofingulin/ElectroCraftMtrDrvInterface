// Your app creates a singleton data model like this one for sub data items.

using System;
using System.Collections.Generic;
using ECFundies;

namespace ECPutItTogether
{

    /// <summary>
    /// Puts all the sub data items in one spot, accessable by name.
    /// Thread-safe singleton.
    /// Ties together two namespaces.
    /// </summary>
    public sealed class SubDaIDataModel
    {
        private static volatile SubDaIDataModel _instance;
        private static object _syncRoot = new Object();

        private static Dictionary<string, SubDaIBase> _subDaIStore;

        public void GetSubDaIStore(ref Dictionary<string, SubDaIBase> towhere) { towhere = _subDaIStore; }

        private SubDaIDataModel()
        {
            _subDaIStore = new Dictionary<string, SubDaIBase>(256);

            _subDaIStore.Add(
                "ARS",
                new SubDaIBase(
                    "ARS",
                    new DICvSuperBit(1, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "ARStp",
                new SubDaIBase(
                    "ARStp",
                    new DICvSuperBit(2, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "AuRu",
                new SubDaIBase(
                    "AuRu",
                    new DICvSuperBit(21, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "AxisOn",
                new SubDaIBase(
                    "AxisOn",
                    new DICvSuperBit(15, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "BottomStitcher",
                new SubDaIBase(
                    "BottomStitcher",
                    "Bottom Stitcher",
                    "Btm Stitch",
                    new DICvStitchStat(4, 1),
                    null
                )
            );

            _subDaIStore.Add(
                "BRF",
                new SubDaIBase(
                    "BRF",
                    new DICvSuperBit(1, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "BSFM",
                new SubDaIBase(
                    "BSFM",
                    new DICvSuperBit(1, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "BSUD",
                new SubDaIBase(
                    "BSUD",
                    new DICvSuperBit(4, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "BUD",
                new SubDaIBase(
                    "BUD",
                    new DICvSuperBit(4, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "CANE",
                new SubDaIBase(
                    "CANE",
                    new DICvSuperBit(0, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "CmdE",
                new SubDaIBase(
                    "CmdE",
                    new DICvSuperBit(14, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "ComE",
                new SubDaIBase(
                    "ComE",
                    new DICvSuperBit(4, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "CtlE",
                new SubDaIBase(
                    "CtlE",
                    new DICvSuperBit(3, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "CUP",
                new SubDaIBase(
                    "CUP",
                    new DICvSuperBit(0, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "DisIn",
                new SubDaIBase(
                    "DisIn",
                    new DICvSuperBit(15, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "DOvrT",
                new SubDaIBase(
                    "DOvrT",
                    new DICvSuperBit(11, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "DrvFlt",
                new SubDaIBase(
                    "DrvFlt",
                    new DICvSuperBit(31, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "EndI",
                new SubDaIBase(
                    "EndI",
                    new DICvSuperBit(16, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "FieldJoinMode",
                new SubDaIBase(
                    "FieldJoinMode",
                    "Field Mode",
                    "Field",
                    new DICvSuperBit(2, "Off", "On", null, null, "Orange", "Green"),
                    null
                )
            );

            _subDaIStore.Add(
                "FrzCt",
                new SubDaIBase(
                    "FrzCt",
                    new DICvSuperBit(29, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "FSBk",
                new SubDaIBase(
                    "FSBk",
                    new DICvSuperBit(1, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "FSDi",
                new SubDaIBase(
                    "FSDi",
                    new DICvSuperBit(7, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "FSFi",
                new SubDaIBase(
                    "FSFi",
                    new DICvSuperBit(0, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "FSRF",
                new SubDaIBase(
                    "FSRF",
                    new DICvSuperBit(3, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "FSRL",
                new SubDaIBase(
                    "FSRL",
                    new DICvSuperBit(2, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "FSUD",
                new SubDaIBase(
                    "FSUD",
                    new DICvSuperBit(6, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "Horn",
                new SubDaIBase(
                    "Horn",
                    new DICvSuperBit(3, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "I2T",
                new SubDaIBase(
                    "I2T",
                    new DICvSuperBit(9, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "I2TDr",
                new SubDaIBase(
                    "I2TDr",
                    new DICvSuperBit(27, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "I2TMt",
                new SubDaIBase(
                    "I2TMt",
                    new DICvSuperBit(26, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "InCam",
                new SubDaIBase(
                    "InCam",
                    new DICvSuperBit(30, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "InGr",
                new SubDaIBase(
                    "InGr",
                    new DICvSuperBit(28, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "IntLt",
                new SubDaIBase(
                    "IntLt",
                    new DICvSuperBit(11, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "JyCmd",
                new SubDaIBase(
                    "JyCmd",
                    new DICvSuperBit(3, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "JyRL",
                new SubDaIBase(
                    "JyRL",
                    new DICvSuperBit(0, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "JyS",
                new SubDaIBase(
                    "JyS",
                    new DICvSuperBit(1, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "JyStp",
                new SubDaIBase(
                    "JyStp",
                    new DICvSuperBit(2, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "LEvt",
                new SubDaIBase(
                    "LEvt",
                    new DICvSuperBit(14, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "LSw1",
                new SubDaIBase(
                    "LSw1",
                    new DICvSuperBit(0, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "LSw2",
                new SubDaIBase(
                    "LSw2",
                    new DICvSuperBit(0, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "LSwN",
                new SubDaIBase(
                    "LSwN",
                    new DICvSuperBit(23, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "LSwP",
                new SubDaIBase(
                    "LSwP",
                    new DICvSuperBit(22, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "MCmp",
                new SubDaIBase(
                    "MCmp",
                    new DICvSuperBit(10, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "MERforEstop",
                new SubDaIBase(
                    "MERforEstop",
                    new DICvToDo(),
                    null
                )
            );

            _subDaIStore.Add(
                "MdFS",
                new SubDaIBase(
                    "MdFS",
                    new DICvSuperBit(8, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "MOvrT",
                new SubDaIBase(
                    "MOvrT",
                    new DICvSuperBit(10, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "MPLE",
                new SubDaIBase(
                    "MPLE",
                    new DICvSuperBit(8, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "MPLW",
                new SubDaIBase(
                    "MPLW",
                    new DICvSuperBit(7, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "MtPoW",
                new SubDaIBase(
                    "MtPoW",
                    new DICvSuperBit(5, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "MtPw",
                new SubDaIBase(
                    "MtPw",
                    new DICvSuperBit(4, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "NLSw",
                new SubDaIBase(
                    "NLSw",
                    new DICvSuperBit(7, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "OpEn",
                new SubDaIBase(
                    "OpEn",
                    new DICvSuperBit(2, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "OpMH",
                new SubDaIBase(
                    "OpMH",
                    new DICvSuperBit(13, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "OpML",
                new SubDaIBase(
                    "OpML",
                    new DICvSuperBit(12, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "OvrI",
                new SubDaIBase(
                    "OvrI",
                    new DICvSuperBit(8, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "OvrV",
                new SubDaIBase(
                    "OvrV",
                    new DICvSuperBit(12, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "PCaps",
                new SubDaIBase(
                    "PCaps",
                    new DICvSuperBit(24, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "PLSw",
                new SubDaIBase(
                    "PLSw",
                    new DICvSuperBit(6, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "PT1",
                new SubDaIBase(
                    "PT1",
                    new DICvSuperBit(17, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "PT2",
                new SubDaIBase(
                    "PT2",
                    new DICvSuperBit(18, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "PT3",
                new SubDaIBase(
                    "PT3",
                    new DICvSuperBit(19, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "PT4",
                new SubDaIBase(
                    "PT4",
                    new DICvSuperBit(20, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "QStp",
                new SubDaIBase(
                    "QStp",
                    new DICvSuperBit(5, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "R09",
                new SubDaIBase(
                    "R09",
                    new DICvSuperBit(9, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "Rdy",
                new SubDaIBase(
                    "Rdy",
                    new DICvSuperBit(0, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "SeamJoinMode",
                new SubDaIBase(
                    "SeamJoinJoinMode",
                    "Seam Mode",
                    "Seam",
                    new DICvSuperBit(2, "On", "Off", null, null, "Green", "Orange"),
                    null
                )
            );

            _subDaIStore.Add(
                "SetE",
                new SubDaIBase(
                    "SetE",
                    new DICvSuperBit(2, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "SFlt",
                new SubDaIBase(
                    "SFlt",
                    new DICvSuperBit(3, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "Shrt",
                new SubDaIBase(
                    "Shrt",
                    new DICvSuperBit(1, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "SR32forEstop",
                new SubDaIBase(
                    "SR32forEstop",
                    new DICvToDo(),
                    null
                )
            );

            _subDaIStore.Add(
                "StBk",
                new SubDaIBase(
                    "StBk",
                    new DICvSuperBit(1, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "StFi",
                new SubDaIBase(
                    "StFi",
                    new DICvSuperBit(0, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "StitcherArm",
                new SubDaIBase(
                    "StitcherArm",
                    "Stitcher Enable/Disable",
                    "Stitch En/Dis",
                    new DICvStitchArm(0x00000006),
                    null
                )
            );

            _subDaIStore.Add(
                "StRL",
                new SubDaIBase(
                    "StRL",
                    new DICvSuperBit(2, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "SwOn",
                new SubDaIBase(
                    "SwOn",
                    new DICvSuperBit(1, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "SwOnD",
                new SubDaIBase(
                    "SwOnD",
                    new DICvSuperBit(6, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "TopStitcher",
                new SubDaIBase(
                    "TopStitcher",
                    "Top Stitcher",
                    "Top Stitch",
                    new DICvStitchStat(5, 2),
                    null
                )
            );

            _subDaIStore.Add(
                "TRF",
                new SubDaIBase(
                    "TRF",
                    new DICvSuperBit(2, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "TrGr",
                new SubDaIBase(
                    "TrGr",
                    new DICvSuperBit(25, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "TSFM",
                new SubDaIBase(
                    "TSFM",
                    new DICvSuperBit(2, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "TSUD",
                new SubDaIBase(
                    "TSUD",
                    new DICvSuperBit(5, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "TUD",
                new SubDaIBase(
                    "TUD",
                    new DICvSuperBit(5, "1", "0"),
                    null
                )
            );

            _subDaIStore.Add(
                "UndV",
                new SubDaIBase(
                    "UndV",
                    new DICvSuperBit(13, "1", "0"),
                    null
                )
            );

        }

        public static SubDaIDataModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new SubDaIDataModel();
                        }
                    }
                }
                return _instance;
            }
            // no Set
        }

        /// <summary>
        /// Use a data key to return a data item interface.
        /// Null means that item isn't in the dictionary.
        /// </summary>
        public void HandleOn(string kval, out SubDaIBase subdaii)
        {
            _subDaIStore.TryGetValue(kval, out subdaii);
        }

    }

}

