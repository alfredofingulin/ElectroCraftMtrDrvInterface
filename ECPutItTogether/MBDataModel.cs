// Your app creates a singleton data model like this one for messages.

using System;
using System.Collections.Generic;
using ECFundies;

namespace ECPutItTogether
{

    /// <summary>
    /// Puts all the message builders in one spot, accessable by item number.
    /// Thread-safe singleton.
    /// Ties together two namespaces.
    /// </summary>
    public sealed class MBDataModel
    {
        private static volatile MBDataModel _instance;
        private static object _syncRoot = new Object();

        private static Dictionary<uint, ECMBBase> _msgBldrStore;

        public void GetMsgBldrStore(ref Dictionary<uint, ECMBBase> towhere) { towhere = _msgBldrStore; }

        private MBDataModel()
        {
            _msgBldrStore = new Dictionary<uint, ECMBBase>(256);

            _msgBldrStore.Add(ECItems.SR32.Num, new ECMB32Mem(ECItems.SR32, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.APOS.Num, new ECMB32Mem(ECItems.APOS, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.STARTMOTION.Num, new ECMB32Mem(ECItems.STARTMOTION, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.MOVEDISTANCEVALUE.Num, new ECMB32Mem(ECItems.MOVEDISTANCEVALUE, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.WallDim.Num, new ECMB32Mem(ECItems.WallDim, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.FireSpacing.Num, new ECMB32Mem(ECItems.FireSpacing, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.AXISSPEED.Num, new ECMB32Mem(ECItems.AXISSPEED, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.SEAMSPACING.Num, new ECMB32Mem(ECItems.SEAMSPACING, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.FIRSTNAILLOC.Num, new ECMB32Mem(ECItems.FIRSTNAILLOC, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.HOMEPOS.Num, new ECMB32Mem(ECItems.HOMEPOS, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.CSPD.Num, new ECMB32Mem(ECItems.CSPD, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.CACC.Num, new ECMB32Mem(ECItems.CACC, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.CDEC.Num, new ECMB32Mem(ECItems.CDEC, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.AxisAccel.Num, new ECMB32Mem(ECItems.AxisAccel, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.CPOS.Num, new ECMB32Mem(ECItems.CPOS, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.TPOS.Num, new ECMB32Mem(ECItems.TPOS, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.TSPD.Num, new ECMB32Mem(ECItems.TSPD, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.TACC.Num, new ECMB32Mem(ECItems.TACC, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.POSTRIGG1.Num, new ECMB32Mem(ECItems.POSTRIGG1, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.PROGRAMREV.Num, new ECMB32Mem(ECItems.PROGRAMREV, ECAxises.OMI.Num));

            _msgBldrStore.Add(ECItems.INDEXVALUE.Num, new ECMB16Mem(ECItems.INDEXVALUE, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.SYSTEMCONFIG.Num, new ECMB16Mem(ECItems.SYSTEMCONFIG, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.SYSTEMSTATE.Num, new ECMB16Mem(ECItems.SYSTEMSTATE, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.DIGIN_STATUS.Num, new ECMB16Mem(ECItems.DIGIN_STATUS, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.DIGOUT_STATUS.Num, new ECMB16Mem(ECItems.DIGOUT_STATUS, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.MER.Num, new ECMB16Mem(ECItems.MER, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.MER_MASK.Num, new ECMB16Mem(ECItems.MER_MASK, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.DER.Num, new ECMB16Mem(ECItems.DER, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.POSERR.Num, new ECMB16Mem(ECItems.POSERR, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.IQ.Num, new ECMB16Mem(ECItems.IQ, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.AD4.Num, new ECMB16Mem(ECItems.AD4, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.AD7.Num, new ECMB16Mem(ECItems.AD7, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.UQREF.Num, new ECMB16Mem(ECItems.UQREF, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.AD5.Num, new ECMB16Mem(ECItems.AD5, ECAxises.OMI.Num));

            // deprecated _msgBldrStore.Add(ECItems.SRL.Num, new ECMB16Unsol(ECItems.SRL, ECAxises.OMI.Num));
            // deprecated _msgBldrStore.Add(ECItems.SRH.Num, new ECMB16Unsol(ECItems.SRH, ECAxises.OMI.Num));

            _msgBldrStore.Add(ECItems.AXISON.Num, new ECMBSimpleInstr(ECItems.AXISON, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.AXISOFF.Num, new ECMBSimpleInstr(ECItems.AXISOFF, ECAxises.OMI.Num));
            _msgBldrStore.Add(ECItems.RESET.Num, new ECMBSimpleInstr(ECItems.RESET, ECAxises.OMI.Num));
        }

        public static MBDataModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new MBDataModel();
                        }
                    }
                }
                return _instance;
            }
            // no Set
        }

        /// <summary>
        /// Use an item number to return a EC message builder.
        /// Use that to construct serial channel messages to a drive.
        /// Null means that item isn't in the dictionary.
        /// </summary>
        /// <returns>
        /// A message builder for the itemnum.
        /// </returns>
        public void HandleOn(uint itemnum, out ECMBBase msgbldr)
        {
            _msgBldrStore.TryGetValue(itemnum, out msgbldr);
        }

    }

}

