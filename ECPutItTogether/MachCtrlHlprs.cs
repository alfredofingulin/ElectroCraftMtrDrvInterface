// Some examples of MBAdapter, used to build ElectroCraft messages.
// Typically called from MVVM execution actions.
// SPVMECMediate.Instance.*, not covered in this glob,
// actually sends and receives using ECSerialPort.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECFundies;

namespace ECPutItTogether
{

    /// <summary>
    /// A bunch of brutarian machine control methods.  Trying to keep these in one spot.
    /// Brutally uses SPVMECMediate.  Unique to this namespece.
    /// </summary>
    public static class MachCtrlHlprs
    {

        public static void PeriodicUpdate_On()
        {
            SPVMECMediate.Instance.ConduitsFlowing = true;
        }

        public static void PeriodicUpdate_Off()
        {
            SPVMECMediate.Instance.ConduitsFlowing = true;
        }

        /// <summary>
        /// Reset axises individually (groups don't generate unsolicited stat changes); order matters: Y X' X.
        /// </summary>
        public static void XAxis_Reset()
        {
            MBAdapter mba;

            mba = new MBAdapter(DaKs.Xpri_Reset);
            ECMsg mxpr = mba.NewMsg();
            mba.SetCreate(ref mxpr, 0);
            SPVMECMediate.Instance.Tx(mxpr);

            mba = new MBAdapter(DaKs.X_Reset);
            ECMsg mxr = mba.NewMsg();
            mba.SetCreate(ref mxr, 0);
            SPVMECMediate.Instance.Tx(mxr);
        }

        /// <summary>
        /// Reset axises individually (groups don't generate unsolicited stat changes); order matters: Y X' X.
        /// </summary>
        public static void YAxis_Reset()
        {
            MBAdapter mba;

            mba = new MBAdapter(DaKs.Y_Reset);
            ECMsg myr = mba.NewMsg();
            mba.SetCreate(ref myr, 0);
            SPVMECMediate.Instance.Tx(myr);

        }

        /// <summary>
        /// Turn on axises individually (groups don't generate unsolicited stat changes); order matters: Y X' X.
        /// </summary>
        public static void AllAxis_On()
        {
            MBAdapter mba;

            mba = new MBAdapter(DaKs.Y_AxisOn);
            ECMsg myo = mba.NewMsg();
            mba.SetCreate(ref myo, 0);
            SPVMECMediate.Instance.Tx(myo);

            mba = new MBAdapter(DaKs.Xpri_AxisOn);
            ECMsg mxpo = mba.NewMsg();
            mba.SetCreate(ref mxpo, 0);
            SPVMECMediate.Instance.Tx(mxpo);

            mba = new MBAdapter(DaKs.X_AxisOn);
            ECMsg mxo = mba.NewMsg();
            mba.SetCreate(ref mxo, 0);
            SPVMECMediate.Instance.Tx(mxo);
        }

        /// <summary>
        /// Turn off axises individually (groups don't generate unsolicited stat changes); order matters: X' X Y.
        /// </summary>
        public static void AllAxis_Off()
        {
            MBAdapter mba;

            mba = new MBAdapter(DaKs.Xpri_AxisOff);
            ECMsg mxp = mba.NewMsg();
            mba.SetCreate(ref mxp, 0);
            SPVMECMediate.Instance.Tx(mxp);

            mba = new MBAdapter(DaKs.X_AxisOff);
            ECMsg mx = mba.NewMsg();
            mba.SetCreate(ref mx, 0);
            SPVMECMediate.Instance.Tx(mx);

            mba = new MBAdapter(DaKs.Y_AxisOff);
            ECMsg my = mba.NewMsg();
            mba.SetCreate(ref my, 0);
            SPVMECMediate.Instance.Tx(my);
        }

        /// <summary>
        /// Actually sends motion messages to X; X sends 'em on to X'.
        /// </summary>
        public static void XGroup_Home()
        {
            MBAdapter mba;

            mba = new MBAdapter(DaKs.X_Func);
            ECMsg mf = mba.NewMsg();
            mba.SetCreate(ref mf, 3);
            SPVMECMediate.Instance.Tx(mf);

            mba = new MBAdapter(DaKs.X_StM);
            ECMsg ms = mba.NewMsg();
            mba.SetCreate(ref ms, 1);
            SPVMECMediate.Instance.Tx(ms);
        }

        public static void YAxis_Home()
        {
            MBAdapter mba;

            mba = new MBAdapter(DaKs.Y_Func);
            ECMsg mf = mba.NewMsg();
            mba.SetCreate(ref mf, 3);
            SPVMECMediate.Instance.Tx(mf);

            mba = new MBAdapter(DaKs.Y_StM);
            ECMsg ms = mba.NewMsg();
            mba.SetCreate(ref ms, 1);
            SPVMECMediate.Instance.Tx(ms);
        }

        public static void AllAxis_Get_ProgramRev()
        {
            MBAdapter mba;

            mba = new MBAdapter(DaKs.Y_ProgramRev);
            ECMsg mgy = mba.NewMsg();
            mba.GetCreate(ref mgy);
            SPVMECMediate.Instance.Tx(mgy);

            mba = new MBAdapter(DaKs.Xpri_ProgramRev);
            ECMsg mgxp = mba.NewMsg();
            mba.GetCreate(ref mgxp);
            SPVMECMediate.Instance.Tx(mgxp);

            mba = new MBAdapter(DaKs.X_ProgramRev);
            ECMsg mgx = mba.NewMsg();
            mba.GetCreate(ref mgx);
            SPVMECMediate.Instance.Tx(mgx);
        }

        public static void AllAxis_Get_StitchSeamField()
        {
            MBAdapter mba;

            mba = new MBAdapter(DaKs.Y_Sys_Cfg);
            ECMsg mgy = mba.NewMsg();
            mba.GetCreate(ref mgy);
            SPVMECMediate.Instance.Tx(mgy);

            mba = new MBAdapter(DaKs.Xpri_Sys_Cfg);
            ECMsg mgxp = mba.NewMsg();
            mba.GetCreate(ref mgxp);
            SPVMECMediate.Instance.Tx(mgxp);

            mba = new MBAdapter(DaKs.X_Sys_Cfg);
            ECMsg mgx = mba.NewMsg();
            mba.GetCreate(ref mgx);
            SPVMECMediate.Instance.Tx(mgx);
        }

        public static void XAxis_Get_LenSpSpd()
        {
            MBAdapter mba;

            mba = new MBAdapter(DaKs.X_Wall_Len);
            ECMsg mxlen = mba.NewMsg();
            mba.GetCreate(ref mxlen);
            SPVMECMediate.Instance.Tx(mxlen);

            mba = new MBAdapter(DaKs.Xpri_Wall_Len);
            ECMsg mxplen = mba.NewMsg();
            mba.GetCreate(ref mxplen);
            SPVMECMediate.Instance.Tx(mxplen);

            mba = new MBAdapter(DaKs.X_Stitch);
            ECMsg mxsp = mba.NewMsg();
            mba.GetCreate(ref mxsp);
            SPVMECMediate.Instance.Tx(mxsp);

            mba = new MBAdapter(DaKs.Xpri_Stitch);
            ECMsg mxpsp = mba.NewMsg();
            mba.GetCreate(ref mxpsp);
            SPVMECMediate.Instance.Tx(mxpsp);

            mba = new MBAdapter(DaKs.X_Bridg_Spd);
            ECMsg mxspd = mba.NewMsg();
            mba.GetCreate(ref mxspd);
            SPVMECMediate.Instance.Tx(mxspd);

            mba = new MBAdapter(DaKs.Xpri_Bridg_Spd);
            ECMsg mxpspd = mba.NewMsg();
            mba.GetCreate(ref mxpspd);
            SPVMECMediate.Instance.Tx(mxpspd);
        }


    }
}
