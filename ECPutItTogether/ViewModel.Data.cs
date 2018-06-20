// This huge-ass example is an MVVM properties data file
// using DaiAdapter and SubDaIAdapter.
// You can auto-gen from populated DataModel-s.

//  x_TestTools begin

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ECFundies;
namespace ECPutItTogether
{
    public partial class ViewModel : ObservableObject, ISPVMECConduit
    {

        partial void Data_ctor () {}

public string X_Func_LongName{ get { return (new DaIAdapter(DaKs.X_Func)).LongName(); } }
public string X_Func_ShortName{ get { return (new DaIAdapter(DaKs.X_Func)).ShortName(); } }
public string X_Func_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Func)).MeasUnits(); } }
public string X_Func_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Func)).ForeGColor(); } }
public string X_Func_BackGColor{ get { return (new DaIAdapter(DaKs.X_Func)).BackGColor(); } }
public string X_Func_Data{ get { string o; (new DaIAdapter(DaKs.X_Func)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Func)).SetIn(value); OnPropertyChanged("X_Func_Data"); } }
public string Xpri_Func_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Func)).LongName(); } }
public string Xpri_Func_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Func)).ShortName(); } }
public string Xpri_Func_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Func)).MeasUnits(); } }
public string Xpri_Func_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Func)).ForeGColor(); } }
public string Xpri_Func_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Func)).BackGColor(); } }
public string Xpri_Func_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Func)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Func)).SetIn(value); OnPropertyChanged("Xpri_Func_Data"); } }
public string Y_Func_LongName{ get { return (new DaIAdapter(DaKs.Y_Func)).LongName(); } }
public string Y_Func_ShortName{ get { return (new DaIAdapter(DaKs.Y_Func)).ShortName(); } }
public string Y_Func_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Func)).MeasUnits(); } }
public string Y_Func_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Func)).ForeGColor(); } }
public string Y_Func_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Func)).BackGColor(); } }
public string Y_Func_Data{ get { string o; (new DaIAdapter(DaKs.Y_Func)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Func)).SetIn(value); OnPropertyChanged("Y_Func_Data"); } }
public string X_StM_LongName{ get { return (new DaIAdapter(DaKs.X_StM)).LongName(); } }
public string X_StM_ShortName{ get { return (new DaIAdapter(DaKs.X_StM)).ShortName(); } }
public string X_StM_MeasUnits{ get { return (new DaIAdapter(DaKs.X_StM)).MeasUnits(); } }
public string X_StM_ForeGColor{ get { return (new DaIAdapter(DaKs.X_StM)).ForeGColor(); } }
public string X_StM_BackGColor{ get { return (new DaIAdapter(DaKs.X_StM)).BackGColor(); } }
public string X_StM_Data{ get { string o; (new DaIAdapter(DaKs.X_StM)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_StM)).SetIn(value); OnPropertyChanged("X_StM_Data"); } }
public string Xpri_StM_LongName{ get { return (new DaIAdapter(DaKs.Xpri_StM)).LongName(); } }
public string Xpri_StM_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_StM)).ShortName(); } }
public string Xpri_StM_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_StM)).MeasUnits(); } }
public string Xpri_StM_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_StM)).ForeGColor(); } }
public string Xpri_StM_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_StM)).BackGColor(); } }
public string Xpri_StM_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_StM)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_StM)).SetIn(value); OnPropertyChanged("Xpri_StM_Data"); } }
public string Y_StM_LongName{ get { return (new DaIAdapter(DaKs.Y_StM)).LongName(); } }
public string Y_StM_ShortName{ get { return (new DaIAdapter(DaKs.Y_StM)).ShortName(); } }
public string Y_StM_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_StM)).MeasUnits(); } }
public string Y_StM_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_StM)).ForeGColor(); } }
public string Y_StM_BackGColor{ get { return (new DaIAdapter(DaKs.Y_StM)).BackGColor(); } }
public string Y_StM_Data{ get { string o; (new DaIAdapter(DaKs.Y_StM)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_StM)).SetIn(value); OnPropertyChanged("Y_StM_Data"); } }
public string X_Move_LongName{ get { return (new DaIAdapter(DaKs.X_Move)).LongName(); } }
public string X_Move_ShortName{ get { return (new DaIAdapter(DaKs.X_Move)).ShortName(); } }
public string X_Move_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Move)).MeasUnits(); } }
public string X_Move_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Move)).ForeGColor(); } }
public string X_Move_BackGColor{ get { return (new DaIAdapter(DaKs.X_Move)).BackGColor(); } }
public string X_Move_Data{ get { string o; (new DaIAdapter(DaKs.X_Move)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Move)).SetIn(value); OnPropertyChanged("X_Move_Data"); } }
public string Xpri_Move_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Move)).LongName(); } }
public string Xpri_Move_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Move)).ShortName(); } }
public string Xpri_Move_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Move)).MeasUnits(); } }
public string Xpri_Move_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Move)).ForeGColor(); } }
public string Xpri_Move_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Move)).BackGColor(); } }
public string Xpri_Move_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Move)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Move)).SetIn(value); OnPropertyChanged("Xpri_Move_Data"); } }
public string Y_Move_LongName{ get { return (new DaIAdapter(DaKs.Y_Move)).LongName(); } }
public string Y_Move_ShortName{ get { return (new DaIAdapter(DaKs.Y_Move)).ShortName(); } }
public string Y_Move_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Move)).MeasUnits(); } }
public string Y_Move_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Move)).ForeGColor(); } }
public string Y_Move_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Move)).BackGColor(); } }
public string Y_Move_Data{ get { string o; (new DaIAdapter(DaKs.Y_Move)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Move)).SetIn(value); OnPropertyChanged("Y_Move_Data"); } }
public string X_Wall_Len_LongName{ get { return (new DaIAdapter(DaKs.X_Wall_Len)).LongName(); } }
public string X_Wall_Len_ShortName{ get { return (new DaIAdapter(DaKs.X_Wall_Len)).ShortName(); } }
public string X_Wall_Len_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Wall_Len)).MeasUnits(); } }
public string X_Wall_Len_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Wall_Len)).ForeGColor(); } }
public string X_Wall_Len_BackGColor{ get { return (new DaIAdapter(DaKs.X_Wall_Len)).BackGColor(); } }
public string X_Wall_Len_Data{ get { string o; (new DaIAdapter(DaKs.X_Wall_Len)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Wall_Len)).SetIn(value); OnPropertyChanged("X_Wall_Len_Data"); } }
public string Xpri_Wall_Len_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Wall_Len)).LongName(); } }
public string Xpri_Wall_Len_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Wall_Len)).ShortName(); } }
public string Xpri_Wall_Len_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Wall_Len)).MeasUnits(); } }
public string Xpri_Wall_Len_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Wall_Len)).ForeGColor(); } }
public string Xpri_Wall_Len_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Wall_Len)).BackGColor(); } }
public string Xpri_Wall_Len_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Wall_Len)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Wall_Len)).SetIn(value); OnPropertyChanged("Xpri_Wall_Len_Data"); } }
public string Y_Wall_Hgt_LongName{ get { return (new DaIAdapter(DaKs.Y_Wall_Hgt)).LongName(); } }
public string Y_Wall_Hgt_ShortName{ get { return (new DaIAdapter(DaKs.Y_Wall_Hgt)).ShortName(); } }
public string Y_Wall_Hgt_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Wall_Hgt)).MeasUnits(); } }
public string Y_Wall_Hgt_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Wall_Hgt)).ForeGColor(); } }
public string Y_Wall_Hgt_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Wall_Hgt)).BackGColor(); } }
public string Y_Wall_Hgt_Data{ get { string o; (new DaIAdapter(DaKs.Y_Wall_Hgt)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Wall_Hgt)).SetIn(value); OnPropertyChanged("Y_Wall_Hgt_Data"); } }
public string X_Stitch_LongName{ get { return (new DaIAdapter(DaKs.X_Stitch)).LongName(); } }
public string X_Stitch_ShortName{ get { return (new DaIAdapter(DaKs.X_Stitch)).ShortName(); } }
public string X_Stitch_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Stitch)).MeasUnits(); } }
public string X_Stitch_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Stitch)).ForeGColor(); } }
public string X_Stitch_BackGColor{ get { return (new DaIAdapter(DaKs.X_Stitch)).BackGColor(); } }
public string X_Stitch_Data{ get { string o; (new DaIAdapter(DaKs.X_Stitch)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Stitch)).SetIn(value); OnPropertyChanged("X_Stitch_Data"); } }
public string Xpri_Stitch_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Stitch)).LongName(); } }
public string Xpri_Stitch_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Stitch)).ShortName(); } }
public string Xpri_Stitch_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Stitch)).MeasUnits(); } }
public string Xpri_Stitch_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Stitch)).ForeGColor(); } }
public string Xpri_Stitch_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Stitch)).BackGColor(); } }
public string Xpri_Stitch_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Stitch)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Stitch)).SetIn(value); OnPropertyChanged("Xpri_Stitch_Data"); } }
public string Y_Field_LongName{ get { return (new DaIAdapter(DaKs.Y_Field)).LongName(); } }
public string Y_Field_ShortName{ get { return (new DaIAdapter(DaKs.Y_Field)).ShortName(); } }
public string Y_Field_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Field)).MeasUnits(); } }
public string Y_Field_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Field)).ForeGColor(); } }
public string Y_Field_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Field)).BackGColor(); } }
public string Y_Field_Data{ get { string o; (new DaIAdapter(DaKs.Y_Field)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Field)).SetIn(value); OnPropertyChanged("Y_Field_Data"); } }
public string X_Sys_Cfg_LongName{ get { return (new DaIAdapter(DaKs.X_Sys_Cfg)).LongName(); } }
public string X_Sys_Cfg_ShortName{ get { return (new DaIAdapter(DaKs.X_Sys_Cfg)).ShortName(); } }
public string X_Sys_Cfg_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Sys_Cfg)).MeasUnits(); } }
public string X_Sys_Cfg_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Sys_Cfg)).ForeGColor(); } }
public string X_Sys_Cfg_BackGColor{ get { return (new DaIAdapter(DaKs.X_Sys_Cfg)).BackGColor(); } }
public string X_Sys_Cfg_Data{ get { string o; (new DaIAdapter(DaKs.X_Sys_Cfg)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Sys_Cfg)).SetIn(value); OnPropertyChanged("X_Sys_Cfg_Data"); } }
public string X_Sys_Cfg_StitcherArm_LongName{ get { return (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).LongName(); } }
public string X_Sys_Cfg_StitcherArm_ShortName{ get { return (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string X_Sys_Cfg_StitcherArm_MeasUnits{ get { return (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string X_Sys_Cfg_StitcherArm_ForeGColor{ get { return (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string X_Sys_Cfg_StitcherArm_BackGColor{ get { return (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string X_Sys_Cfg_StitcherArm_Data{ get { string o; (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_Cfg_StitcherArm_Data"); OnPropertyChanged("X_Sys_Cfg_Data"); } }
public string X_Sys_Cfg_TopStitcher_LongName{ get { return (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).LongName(); } }
public string X_Sys_Cfg_TopStitcher_ShortName{ get { return (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string X_Sys_Cfg_TopStitcher_MeasUnits{ get { return (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string X_Sys_Cfg_TopStitcher_ForeGColor{ get { return (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string X_Sys_Cfg_TopStitcher_BackGColor{ get { return (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string X_Sys_Cfg_TopStitcher_Data{ get { string o; (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_Cfg_TopStitcher_Data"); OnPropertyChanged("X_Sys_Cfg_Data"); } }
public string X_Sys_Cfg_BottomStitcher_LongName{ get { return (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).LongName(); } }
public string X_Sys_Cfg_BottomStitcher_ShortName{ get { return (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string X_Sys_Cfg_BottomStitcher_MeasUnits{ get { return (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string X_Sys_Cfg_BottomStitcher_ForeGColor{ get { return (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string X_Sys_Cfg_BottomStitcher_BackGColor{ get { return (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string X_Sys_Cfg_BottomStitcher_Data{ get { string o; (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_Cfg_BottomStitcher_Data"); OnPropertyChanged("X_Sys_Cfg_Data"); } }
public string X_Sys_Cfg_BSFM_LongName{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).LongName(); } }
public string X_Sys_Cfg_BSFM_ShortName{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string X_Sys_Cfg_BSFM_MeasUnits{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string X_Sys_Cfg_BSFM_ForeGColor{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string X_Sys_Cfg_BSFM_BackGColor{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string X_Sys_Cfg_BSFM_Data{ get { string o; (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_Cfg_BSFM_Data"); OnPropertyChanged("X_Sys_Cfg_Data"); } }
public string X_Sys_Cfg_TSFM_LongName{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).LongName(); } }
public string X_Sys_Cfg_TSFM_ShortName{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string X_Sys_Cfg_TSFM_MeasUnits{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string X_Sys_Cfg_TSFM_ForeGColor{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string X_Sys_Cfg_TSFM_BackGColor{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string X_Sys_Cfg_TSFM_Data{ get { string o; (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_Cfg_TSFM_Data"); OnPropertyChanged("X_Sys_Cfg_Data"); } }
public string X_Sys_Cfg_BSUD_LongName{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).LongName(); } }
public string X_Sys_Cfg_BSUD_ShortName{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string X_Sys_Cfg_BSUD_MeasUnits{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string X_Sys_Cfg_BSUD_ForeGColor{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string X_Sys_Cfg_BSUD_BackGColor{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string X_Sys_Cfg_BSUD_Data{ get { string o; (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_Cfg_BSUD_Data"); OnPropertyChanged("X_Sys_Cfg_Data"); } }
public string X_Sys_Cfg_TSUD_LongName{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).LongName(); } }
public string X_Sys_Cfg_TSUD_ShortName{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string X_Sys_Cfg_TSUD_MeasUnits{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string X_Sys_Cfg_TSUD_ForeGColor{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string X_Sys_Cfg_TSUD_BackGColor{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string X_Sys_Cfg_TSUD_Data{ get { string o; (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_Cfg_TSUD_Data"); OnPropertyChanged("X_Sys_Cfg_Data"); } }
public string X_Sys_Cfg_MdFS_LongName{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).LongName(); } }
public string X_Sys_Cfg_MdFS_ShortName{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string X_Sys_Cfg_MdFS_MeasUnits{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string X_Sys_Cfg_MdFS_ForeGColor{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string X_Sys_Cfg_MdFS_BackGColor{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string X_Sys_Cfg_MdFS_Data{ get { string o; (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.X_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_Cfg_MdFS_Data"); OnPropertyChanged("X_Sys_Cfg_Data"); } }
public string Xpri_Sys_Cfg_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).LongName(); } }
public string Xpri_Sys_Cfg_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).ShortName(); } }
public string Xpri_Sys_Cfg_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).MeasUnits(); } }
public string Xpri_Sys_Cfg_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).ForeGColor(); } }
public string Xpri_Sys_Cfg_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).BackGColor(); } }
public string Xpri_Sys_Cfg_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).SetIn(value); OnPropertyChanged("Xpri_Sys_Cfg_Data"); } }
public string Xpri_Sys_Cfg_StitcherArm_LongName{ get { return (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Xpri_Sys_Cfg_StitcherArm_ShortName{ get { return (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_Cfg_StitcherArm_MeasUnits{ get { return (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_Cfg_StitcherArm_ForeGColor{ get { return (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_Cfg_StitcherArm_BackGColor{ get { return (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_Cfg_StitcherArm_Data{ get { string o; (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("StitcherArm", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_Cfg_StitcherArm_Data"); OnPropertyChanged("Xpri_Sys_Cfg_Data"); } }
public string Xpri_Sys_Cfg_TopStitcher_LongName{ get { return (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Xpri_Sys_Cfg_TopStitcher_ShortName{ get { return (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_Cfg_TopStitcher_MeasUnits{ get { return (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_Cfg_TopStitcher_ForeGColor{ get { return (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_Cfg_TopStitcher_BackGColor{ get { return (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_Cfg_TopStitcher_Data{ get { string o; (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TopStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_Cfg_TopStitcher_Data"); OnPropertyChanged("Xpri_Sys_Cfg_Data"); } }
public string Xpri_Sys_Cfg_BottomStitcher_LongName{ get { return (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Xpri_Sys_Cfg_BottomStitcher_ShortName{ get { return (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_Cfg_BottomStitcher_MeasUnits{ get { return (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_Cfg_BottomStitcher_ForeGColor{ get { return (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_Cfg_BottomStitcher_BackGColor{ get { return (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_Cfg_BottomStitcher_Data{ get { string o; (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BottomStitcher", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_Cfg_BottomStitcher_Data"); OnPropertyChanged("Xpri_Sys_Cfg_Data"); } }
public string Xpri_Sys_Cfg_BSFM_LongName{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Xpri_Sys_Cfg_BSFM_ShortName{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_Cfg_BSFM_MeasUnits{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_Cfg_BSFM_ForeGColor{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_Cfg_BSFM_BackGColor{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_Cfg_BSFM_Data{ get { string o; (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_Cfg_BSFM_Data"); OnPropertyChanged("Xpri_Sys_Cfg_Data"); } }
public string Xpri_Sys_Cfg_TSFM_LongName{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Xpri_Sys_Cfg_TSFM_ShortName{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_Cfg_TSFM_MeasUnits{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_Cfg_TSFM_ForeGColor{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_Cfg_TSFM_BackGColor{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_Cfg_TSFM_Data{ get { string o; (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_Cfg_TSFM_Data"); OnPropertyChanged("Xpri_Sys_Cfg_Data"); } }
public string Xpri_Sys_Cfg_BSUD_LongName{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Xpri_Sys_Cfg_BSUD_ShortName{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_Cfg_BSUD_MeasUnits{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_Cfg_BSUD_ForeGColor{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_Cfg_BSUD_BackGColor{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_Cfg_BSUD_Data{ get { string o; (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_Cfg_BSUD_Data"); OnPropertyChanged("Xpri_Sys_Cfg_Data"); } }
public string Xpri_Sys_Cfg_TSUD_LongName{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Xpri_Sys_Cfg_TSUD_ShortName{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_Cfg_TSUD_MeasUnits{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_Cfg_TSUD_ForeGColor{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_Cfg_TSUD_BackGColor{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_Cfg_TSUD_Data{ get { string o; (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_Cfg_TSUD_Data"); OnPropertyChanged("Xpri_Sys_Cfg_Data"); } }
public string Xpri_Sys_Cfg_MdFS_LongName{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Xpri_Sys_Cfg_MdFS_ShortName{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_Cfg_MdFS_MeasUnits{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_Cfg_MdFS_ForeGColor{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_Cfg_MdFS_BackGColor{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_Cfg_MdFS_Data{ get { string o; (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Xpri_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_Cfg_MdFS_Data"); OnPropertyChanged("Xpri_Sys_Cfg_Data"); } }
public string Y_Sys_Cfg_LongName{ get { return (new DaIAdapter(DaKs.Y_Sys_Cfg)).LongName(); } }
public string Y_Sys_Cfg_ShortName{ get { return (new DaIAdapter(DaKs.Y_Sys_Cfg)).ShortName(); } }
public string Y_Sys_Cfg_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Sys_Cfg)).MeasUnits(); } }
public string Y_Sys_Cfg_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Sys_Cfg)).ForeGColor(); } }
public string Y_Sys_Cfg_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Sys_Cfg)).BackGColor(); } }
public string Y_Sys_Cfg_Data{ get { string o; (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Sys_Cfg)).SetIn(value); OnPropertyChanged("Y_Sys_Cfg_Data"); } }
public string Y_Sys_Cfg_FieldJoinMode_LongName{ get { return (new SubDaIAdapter("FieldJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Y_Sys_Cfg_FieldJoinMode_ShortName{ get { return (new SubDaIAdapter("FieldJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Y_Sys_Cfg_FieldJoinMode_MeasUnits{ get { return (new SubDaIAdapter("FieldJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Y_Sys_Cfg_FieldJoinMode_ForeGColor{ get { return (new SubDaIAdapter("FieldJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Y_Sys_Cfg_FieldJoinMode_BackGColor{ get { return (new SubDaIAdapter("FieldJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Y_Sys_Cfg_FieldJoinMode_Data{ get { string o; (new SubDaIAdapter("FieldJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("FieldJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Sys_Cfg_FieldJoinMode_Data"); OnPropertyChanged("Y_Sys_Cfg_Data"); } }
public string Y_Sys_Cfg_SeamJoinMode_LongName{ get { return (new SubDaIAdapter("SeamJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Y_Sys_Cfg_SeamJoinMode_ShortName{ get { return (new SubDaIAdapter("SeamJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Y_Sys_Cfg_SeamJoinMode_MeasUnits{ get { return (new SubDaIAdapter("SeamJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Y_Sys_Cfg_SeamJoinMode_ForeGColor{ get { return (new SubDaIAdapter("SeamJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Y_Sys_Cfg_SeamJoinMode_BackGColor{ get { return (new SubDaIAdapter("SeamJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Y_Sys_Cfg_SeamJoinMode_Data{ get { string o; (new SubDaIAdapter("SeamJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SeamJoinMode", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Sys_Cfg_SeamJoinMode_Data"); OnPropertyChanged("Y_Sys_Cfg_Data"); } }
public string Y_Sys_Cfg_BSFM_LongName{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Y_Sys_Cfg_BSFM_ShortName{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Y_Sys_Cfg_BSFM_MeasUnits{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Y_Sys_Cfg_BSFM_ForeGColor{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Y_Sys_Cfg_BSFM_BackGColor{ get { return (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Y_Sys_Cfg_BSFM_Data{ get { string o; (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Sys_Cfg_BSFM_Data"); OnPropertyChanged("Y_Sys_Cfg_Data"); } }
public string Y_Sys_Cfg_TSFM_LongName{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Y_Sys_Cfg_TSFM_ShortName{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Y_Sys_Cfg_TSFM_MeasUnits{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Y_Sys_Cfg_TSFM_ForeGColor{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Y_Sys_Cfg_TSFM_BackGColor{ get { return (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Y_Sys_Cfg_TSFM_Data{ get { string o; (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TSFM", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Sys_Cfg_TSFM_Data"); OnPropertyChanged("Y_Sys_Cfg_Data"); } }
public string Y_Sys_Cfg_BSUD_LongName{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Y_Sys_Cfg_BSUD_ShortName{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Y_Sys_Cfg_BSUD_MeasUnits{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Y_Sys_Cfg_BSUD_ForeGColor{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Y_Sys_Cfg_BSUD_BackGColor{ get { return (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Y_Sys_Cfg_BSUD_Data{ get { string o; (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Sys_Cfg_BSUD_Data"); OnPropertyChanged("Y_Sys_Cfg_Data"); } }
public string Y_Sys_Cfg_TSUD_LongName{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Y_Sys_Cfg_TSUD_ShortName{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Y_Sys_Cfg_TSUD_MeasUnits{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Y_Sys_Cfg_TSUD_ForeGColor{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Y_Sys_Cfg_TSUD_BackGColor{ get { return (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Y_Sys_Cfg_TSUD_Data{ get { string o; (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TSUD", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Sys_Cfg_TSUD_Data"); OnPropertyChanged("Y_Sys_Cfg_Data"); } }
public string Y_Sys_Cfg_MdFS_LongName{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).LongName(); } }
public string Y_Sys_Cfg_MdFS_ShortName{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ShortName(); } }
public string Y_Sys_Cfg_MdFS_MeasUnits{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).MeasUnits(); } }
public string Y_Sys_Cfg_MdFS_ForeGColor{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).ForeGColor(); } }
public string Y_Sys_Cfg_MdFS_BackGColor{ get { return (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).BackGColor(); } }
public string Y_Sys_Cfg_MdFS_Data{ get { string o; (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MdFS", (new DaIAdapter(DaKs.Y_Sys_Cfg)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Sys_Cfg_MdFS_Data"); OnPropertyChanged("Y_Sys_Cfg_Data"); } }
public string X_Bridg_Spd_LongName{ get { return (new DaIAdapter(DaKs.X_Bridg_Spd)).LongName(); } }
public string X_Bridg_Spd_ShortName{ get { return (new DaIAdapter(DaKs.X_Bridg_Spd)).ShortName(); } }
public string X_Bridg_Spd_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Bridg_Spd)).MeasUnits(); } }
public string X_Bridg_Spd_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Bridg_Spd)).ForeGColor(); } }
public string X_Bridg_Spd_BackGColor{ get { return (new DaIAdapter(DaKs.X_Bridg_Spd)).BackGColor(); } }
public string X_Bridg_Spd_Data{ get { string o; (new DaIAdapter(DaKs.X_Bridg_Spd)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Bridg_Spd)).SetIn(value); OnPropertyChanged("X_Bridg_Spd_Data"); } }
public string Xpri_Bridg_Spd_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Spd)).LongName(); } }
public string Xpri_Bridg_Spd_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Spd)).ShortName(); } }
public string Xpri_Bridg_Spd_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Spd)).MeasUnits(); } }
public string Xpri_Bridg_Spd_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Spd)).ForeGColor(); } }
public string Xpri_Bridg_Spd_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Spd)).BackGColor(); } }
public string Xpri_Bridg_Spd_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Bridg_Spd)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Bridg_Spd)).SetIn(value); OnPropertyChanged("Xpri_Bridg_Spd_Data"); } }
public string Y_Crg_Spd_LongName{ get { return (new DaIAdapter(DaKs.Y_Crg_Spd)).LongName(); } }
public string Y_Crg_Spd_ShortName{ get { return (new DaIAdapter(DaKs.Y_Crg_Spd)).ShortName(); } }
public string Y_Crg_Spd_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Crg_Spd)).MeasUnits(); } }
public string Y_Crg_Spd_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Crg_Spd)).ForeGColor(); } }
public string Y_Crg_Spd_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Crg_Spd)).BackGColor(); } }
public string Y_Crg_Spd_Data{ get { string o; (new DaIAdapter(DaKs.Y_Crg_Spd)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Crg_Spd)).SetIn(value); OnPropertyChanged("Y_Crg_Spd_Data"); } }
public string X_Sys_St_LongName{ get { return (new DaIAdapter(DaKs.X_Sys_St)).LongName(); } }
public string X_Sys_St_ShortName{ get { return (new DaIAdapter(DaKs.X_Sys_St)).ShortName(); } }
public string X_Sys_St_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Sys_St)).MeasUnits(); } }
public string X_Sys_St_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Sys_St)).ForeGColor(); } }
public string X_Sys_St_BackGColor{ get { return (new DaIAdapter(DaKs.X_Sys_St)).BackGColor(); } }
public string X_Sys_St_Data{ get { string o; (new DaIAdapter(DaKs.X_Sys_St)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Sys_St)).SetIn(value); OnPropertyChanged("X_Sys_St_Data"); } }
public string X_Sys_St_BRF_LongName{ get { return (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).LongName(); } }
public string X_Sys_St_BRF_ShortName{ get { return (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).ShortName(); } }
public string X_Sys_St_BRF_MeasUnits{ get { return (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).MeasUnits(); } }
public string X_Sys_St_BRF_ForeGColor{ get { return (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).ForeGColor(); } }
public string X_Sys_St_BRF_BackGColor{ get { return (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).BackGColor(); } }
public string X_Sys_St_BRF_Data{ get { string o; (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_St_BRF_Data"); OnPropertyChanged("X_Sys_St_Data"); } }
public string X_Sys_St_TRF_LongName{ get { return (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).LongName(); } }
public string X_Sys_St_TRF_ShortName{ get { return (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).ShortName(); } }
public string X_Sys_St_TRF_MeasUnits{ get { return (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).MeasUnits(); } }
public string X_Sys_St_TRF_ForeGColor{ get { return (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).ForeGColor(); } }
public string X_Sys_St_TRF_BackGColor{ get { return (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).BackGColor(); } }
public string X_Sys_St_TRF_Data{ get { string o; (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_St_TRF_Data"); OnPropertyChanged("X_Sys_St_Data"); } }
public string X_Sys_St_BUD_LongName{ get { return (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).LongName(); } }
public string X_Sys_St_BUD_ShortName{ get { return (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).ShortName(); } }
public string X_Sys_St_BUD_MeasUnits{ get { return (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).MeasUnits(); } }
public string X_Sys_St_BUD_ForeGColor{ get { return (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).ForeGColor(); } }
public string X_Sys_St_BUD_BackGColor{ get { return (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).BackGColor(); } }
public string X_Sys_St_BUD_Data{ get { string o; (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_St_BUD_Data"); OnPropertyChanged("X_Sys_St_Data"); } }
public string X_Sys_St_TUD_LongName{ get { return (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).LongName(); } }
public string X_Sys_St_TUD_ShortName{ get { return (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).ShortName(); } }
public string X_Sys_St_TUD_MeasUnits{ get { return (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).MeasUnits(); } }
public string X_Sys_St_TUD_ForeGColor{ get { return (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).ForeGColor(); } }
public string X_Sys_St_TUD_BackGColor{ get { return (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).BackGColor(); } }
public string X_Sys_St_TUD_Data{ get { string o; (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.X_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Sys_St_TUD_Data"); OnPropertyChanged("X_Sys_St_Data"); } }
public string Xpri_Sys_St_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Sys_St)).LongName(); } }
public string Xpri_Sys_St_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Sys_St)).ShortName(); } }
public string Xpri_Sys_St_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Sys_St)).MeasUnits(); } }
public string Xpri_Sys_St_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Sys_St)).ForeGColor(); } }
public string Xpri_Sys_St_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Sys_St)).BackGColor(); } }
public string Xpri_Sys_St_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Sys_St)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Sys_St)).SetIn(value); OnPropertyChanged("Xpri_Sys_St_Data"); } }
public string Xpri_Sys_St_BRF_LongName{ get { return (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).LongName(); } }
public string Xpri_Sys_St_BRF_ShortName{ get { return (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_St_BRF_MeasUnits{ get { return (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_St_BRF_ForeGColor{ get { return (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_St_BRF_BackGColor{ get { return (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_St_BRF_Data{ get { string o; (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_St_BRF_Data"); OnPropertyChanged("Xpri_Sys_St_Data"); } }
public string Xpri_Sys_St_TRF_LongName{ get { return (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).LongName(); } }
public string Xpri_Sys_St_TRF_ShortName{ get { return (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_St_TRF_MeasUnits{ get { return (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_St_TRF_ForeGColor{ get { return (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_St_TRF_BackGColor{ get { return (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_St_TRF_Data{ get { string o; (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TRF", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_St_TRF_Data"); OnPropertyChanged("Xpri_Sys_St_Data"); } }
public string Xpri_Sys_St_BUD_LongName{ get { return (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).LongName(); } }
public string Xpri_Sys_St_BUD_ShortName{ get { return (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_St_BUD_MeasUnits{ get { return (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_St_BUD_ForeGColor{ get { return (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_St_BUD_BackGColor{ get { return (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_St_BUD_Data{ get { string o; (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("BUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_St_BUD_Data"); OnPropertyChanged("Xpri_Sys_St_Data"); } }
public string Xpri_Sys_St_TUD_LongName{ get { return (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).LongName(); } }
public string Xpri_Sys_St_TUD_ShortName{ get { return (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).ShortName(); } }
public string Xpri_Sys_St_TUD_MeasUnits{ get { return (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).MeasUnits(); } }
public string Xpri_Sys_St_TUD_ForeGColor{ get { return (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).ForeGColor(); } }
public string Xpri_Sys_St_TUD_BackGColor{ get { return (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).BackGColor(); } }
public string Xpri_Sys_St_TUD_Data{ get { string o; (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TUD", (new DaIAdapter(DaKs.Xpri_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Sys_St_TUD_Data"); OnPropertyChanged("Xpri_Sys_St_Data"); } }
public string Y_Sys_St_LongName{ get { return (new DaIAdapter(DaKs.Y_Sys_St)).LongName(); } }
public string Y_Sys_St_ShortName{ get { return (new DaIAdapter(DaKs.Y_Sys_St)).ShortName(); } }
public string Y_Sys_St_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Sys_St)).MeasUnits(); } }
public string Y_Sys_St_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Sys_St)).ForeGColor(); } }
public string Y_Sys_St_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Sys_St)).BackGColor(); } }
public string Y_Sys_St_Data{ get { string o; (new DaIAdapter(DaKs.Y_Sys_St)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Sys_St)).SetIn(value); OnPropertyChanged("Y_Sys_St_Data"); } }
public string Y_Sys_St_CUP_LongName{ get { return (new SubDaIAdapter("CUP", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).LongName(); } }
public string Y_Sys_St_CUP_ShortName{ get { return (new SubDaIAdapter("CUP", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).ShortName(); } }
public string Y_Sys_St_CUP_MeasUnits{ get { return (new SubDaIAdapter("CUP", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).MeasUnits(); } }
public string Y_Sys_St_CUP_ForeGColor{ get { return (new SubDaIAdapter("CUP", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).ForeGColor(); } }
public string Y_Sys_St_CUP_BackGColor{ get { return (new SubDaIAdapter("CUP", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).BackGColor(); } }
public string Y_Sys_St_CUP_Data{ get { string o; (new SubDaIAdapter("CUP", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("CUP", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Sys_St_CUP_Data"); OnPropertyChanged("Y_Sys_St_Data"); } }
public string Y_Sys_St_FSRF_LongName{ get { return (new SubDaIAdapter("FSRF", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).LongName(); } }
public string Y_Sys_St_FSRF_ShortName{ get { return (new SubDaIAdapter("FSRF", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).ShortName(); } }
public string Y_Sys_St_FSRF_MeasUnits{ get { return (new SubDaIAdapter("FSRF", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).MeasUnits(); } }
public string Y_Sys_St_FSRF_ForeGColor{ get { return (new SubDaIAdapter("FSRF", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).ForeGColor(); } }
public string Y_Sys_St_FSRF_BackGColor{ get { return (new SubDaIAdapter("FSRF", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).BackGColor(); } }
public string Y_Sys_St_FSRF_Data{ get { string o; (new SubDaIAdapter("FSRF", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("FSRF", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Sys_St_FSRF_Data"); OnPropertyChanged("Y_Sys_St_Data"); } }
public string Y_Sys_St_FSUD_LongName{ get { return (new SubDaIAdapter("FSUD", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).LongName(); } }
public string Y_Sys_St_FSUD_ShortName{ get { return (new SubDaIAdapter("FSUD", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).ShortName(); } }
public string Y_Sys_St_FSUD_MeasUnits{ get { return (new SubDaIAdapter("FSUD", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).MeasUnits(); } }
public string Y_Sys_St_FSUD_ForeGColor{ get { return (new SubDaIAdapter("FSUD", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).ForeGColor(); } }
public string Y_Sys_St_FSUD_BackGColor{ get { return (new SubDaIAdapter("FSUD", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).BackGColor(); } }
public string Y_Sys_St_FSUD_Data{ get { string o; (new SubDaIAdapter("FSUD", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("FSUD", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Sys_St_FSUD_Data"); OnPropertyChanged("Y_Sys_St_Data"); } }
public string Y_Sys_St_FSDi_LongName{ get { return (new SubDaIAdapter("FSDi", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).LongName(); } }
public string Y_Sys_St_FSDi_ShortName{ get { return (new SubDaIAdapter("FSDi", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).ShortName(); } }
public string Y_Sys_St_FSDi_MeasUnits{ get { return (new SubDaIAdapter("FSDi", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).MeasUnits(); } }
public string Y_Sys_St_FSDi_ForeGColor{ get { return (new SubDaIAdapter("FSDi", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).ForeGColor(); } }
public string Y_Sys_St_FSDi_BackGColor{ get { return (new SubDaIAdapter("FSDi", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).BackGColor(); } }
public string Y_Sys_St_FSDi_Data{ get { string o; (new SubDaIAdapter("FSDi", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("FSDi", (new DaIAdapter(DaKs.Y_Sys_St)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Sys_St_FSDi_Data"); OnPropertyChanged("Y_Sys_St_Data"); } }
public string Y_Seams_LongName{ get { return (new DaIAdapter(DaKs.Y_Seams)).LongName(); } }
public string Y_Seams_ShortName{ get { return (new DaIAdapter(DaKs.Y_Seams)).ShortName(); } }
public string Y_Seams_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Seams)).MeasUnits(); } }
public string Y_Seams_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Seams)).ForeGColor(); } }
public string Y_Seams_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Seams)).BackGColor(); } }
public string Y_Seams_Data{ get { string o; (new DaIAdapter(DaKs.Y_Seams)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Seams)).SetIn(value); OnPropertyChanged("Y_Seams_Data"); } }
public string Y_F1st_Nail_LongName{ get { return (new DaIAdapter(DaKs.Y_F1st_Nail)).LongName(); } }
public string Y_F1st_Nail_ShortName{ get { return (new DaIAdapter(DaKs.Y_F1st_Nail)).ShortName(); } }
public string Y_F1st_Nail_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_F1st_Nail)).MeasUnits(); } }
public string Y_F1st_Nail_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_F1st_Nail)).ForeGColor(); } }
public string Y_F1st_Nail_BackGColor{ get { return (new DaIAdapter(DaKs.Y_F1st_Nail)).BackGColor(); } }
public string Y_F1st_Nail_Data{ get { string o; (new DaIAdapter(DaKs.Y_F1st_Nail)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_F1st_Nail)).SetIn(value); OnPropertyChanged("Y_F1st_Nail_Data"); } }
public string X_SR32_LongName{ get { return (new DaIAdapter(DaKs.X_SR32)).LongName(); } }
public string X_SR32_ShortName{ get { return (new DaIAdapter(DaKs.X_SR32)).ShortName(); } }
public string X_SR32_MeasUnits{ get { return (new DaIAdapter(DaKs.X_SR32)).MeasUnits(); } }
public string X_SR32_ForeGColor{ get { return (new DaIAdapter(DaKs.X_SR32)).ForeGColor(); } }
public string X_SR32_BackGColor{ get { return (new DaIAdapter(DaKs.X_SR32)).BackGColor(); } }
public string X_SR32_Data{ get { string o; (new DaIAdapter(DaKs.X_SR32)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_SR32)).SetIn(value); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_SR32forEstop_LongName{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_SR32forEstop_ShortName{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_SR32forEstop_MeasUnits{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_SR32forEstop_ForeGColor{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_SR32forEstop_BackGColor{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_SR32forEstop_Data{ get { string o; (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_SR32forEstop_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_Rdy_LongName{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_Rdy_ShortName{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_Rdy_MeasUnits{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_Rdy_ForeGColor{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_Rdy_BackGColor{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_Rdy_Data{ get { string o; (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_Rdy_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_SwOn_LongName{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_SwOn_ShortName{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_SwOn_MeasUnits{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_SwOn_ForeGColor{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_SwOn_BackGColor{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_SwOn_Data{ get { string o; (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_SwOn_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_OpEn_LongName{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_OpEn_ShortName{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_OpEn_MeasUnits{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_OpEn_ForeGColor{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_OpEn_BackGColor{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_OpEn_Data{ get { string o; (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_OpEn_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_SFlt_LongName{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_SFlt_ShortName{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_SFlt_MeasUnits{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_SFlt_ForeGColor{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_SFlt_BackGColor{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_SFlt_Data{ get { string o; (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_SFlt_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_MtPw_LongName{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_MtPw_ShortName{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_MtPw_MeasUnits{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_MtPw_ForeGColor{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_MtPw_BackGColor{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_MtPw_Data{ get { string o; (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_MtPw_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_QStp_LongName{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_QStp_ShortName{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_QStp_MeasUnits{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_QStp_ForeGColor{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_QStp_BackGColor{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_QStp_Data{ get { string o; (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_QStp_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_SwOnD_LongName{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_SwOnD_ShortName{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_SwOnD_MeasUnits{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_SwOnD_ForeGColor{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_SwOnD_BackGColor{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_SwOnD_Data{ get { string o; (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_SwOnD_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_MPLW_LongName{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_MPLW_ShortName{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_MPLW_MeasUnits{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_MPLW_ForeGColor{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_MPLW_BackGColor{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_MPLW_Data{ get { string o; (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_MPLW_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_MPLE_LongName{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_MPLE_ShortName{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_MPLE_MeasUnits{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_MPLE_ForeGColor{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_MPLE_BackGColor{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_MPLE_Data{ get { string o; (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_MPLE_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_R09_LongName{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_R09_ShortName{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_R09_MeasUnits{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_R09_ForeGColor{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_R09_BackGColor{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_R09_Data{ get { string o; (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_R09_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_MCmp_LongName{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_MCmp_ShortName{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_MCmp_MeasUnits{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_MCmp_ForeGColor{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_MCmp_BackGColor{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_MCmp_Data{ get { string o; (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_MCmp_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_IntLt_LongName{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_IntLt_ShortName{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_IntLt_MeasUnits{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_IntLt_ForeGColor{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_IntLt_BackGColor{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_IntLt_Data{ get { string o; (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_IntLt_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_OpML_LongName{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_OpML_ShortName{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_OpML_MeasUnits{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_OpML_ForeGColor{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_OpML_BackGColor{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_OpML_Data{ get { string o; (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_OpML_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_OpMH_LongName{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_OpMH_ShortName{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_OpMH_MeasUnits{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_OpMH_ForeGColor{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_OpMH_BackGColor{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_OpMH_Data{ get { string o; (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_OpMH_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_LEvt_LongName{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_LEvt_ShortName{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_LEvt_MeasUnits{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_LEvt_ForeGColor{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_LEvt_BackGColor{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_LEvt_Data{ get { string o; (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_LEvt_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_AxisOn_LongName{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_AxisOn_ShortName{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_AxisOn_MeasUnits{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_AxisOn_ForeGColor{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_AxisOn_BackGColor{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_AxisOn_Data{ get { string o; (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_AxisOn_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_EndI_LongName{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_EndI_ShortName{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_EndI_MeasUnits{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_EndI_ForeGColor{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_EndI_BackGColor{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_EndI_Data{ get { string o; (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_EndI_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_PT1_LongName{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_PT1_ShortName{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_PT1_MeasUnits{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_PT1_ForeGColor{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_PT1_BackGColor{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_PT1_Data{ get { string o; (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_PT1_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_PT2_LongName{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_PT2_ShortName{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_PT2_MeasUnits{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_PT2_ForeGColor{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_PT2_BackGColor{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_PT2_Data{ get { string o; (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_PT2_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_PT3_LongName{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_PT3_ShortName{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_PT3_MeasUnits{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_PT3_ForeGColor{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_PT3_BackGColor{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_PT3_Data{ get { string o; (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_PT3_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_PT4_LongName{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_PT4_ShortName{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_PT4_MeasUnits{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_PT4_ForeGColor{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_PT4_BackGColor{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_PT4_Data{ get { string o; (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_PT4_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_AuRu_LongName{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_AuRu_ShortName{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_AuRu_MeasUnits{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_AuRu_ForeGColor{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_AuRu_BackGColor{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_AuRu_Data{ get { string o; (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_AuRu_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_LSwP_LongName{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_LSwP_ShortName{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_LSwP_MeasUnits{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_LSwP_ForeGColor{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_LSwP_BackGColor{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_LSwP_Data{ get { string o; (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_LSwP_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_LSwN_LongName{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_LSwN_ShortName{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_LSwN_MeasUnits{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_LSwN_ForeGColor{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_LSwN_BackGColor{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_LSwN_Data{ get { string o; (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_LSwN_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_PCaps_LongName{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_PCaps_ShortName{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_PCaps_MeasUnits{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_PCaps_ForeGColor{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_PCaps_BackGColor{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_PCaps_Data{ get { string o; (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_PCaps_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_TrGr_LongName{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_TrGr_ShortName{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_TrGr_MeasUnits{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_TrGr_ForeGColor{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_TrGr_BackGColor{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_TrGr_Data{ get { string o; (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_TrGr_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_I2TMt_LongName{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_I2TMt_ShortName{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_I2TMt_MeasUnits{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_I2TMt_ForeGColor{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_I2TMt_BackGColor{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_I2TMt_Data{ get { string o; (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_I2TMt_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_I2TDr_LongName{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_I2TDr_ShortName{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_I2TDr_MeasUnits{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_I2TDr_ForeGColor{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_I2TDr_BackGColor{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_I2TDr_Data{ get { string o; (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_I2TDr_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_InGr_LongName{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_InGr_ShortName{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_InGr_MeasUnits{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_InGr_ForeGColor{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_InGr_BackGColor{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_InGr_Data{ get { string o; (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_InGr_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_FrzCt_LongName{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_FrzCt_ShortName{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_FrzCt_MeasUnits{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_FrzCt_ForeGColor{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_FrzCt_BackGColor{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_FrzCt_Data{ get { string o; (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_FrzCt_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_InCam_LongName{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_InCam_ShortName{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_InCam_MeasUnits{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_InCam_ForeGColor{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_InCam_BackGColor{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_InCam_Data{ get { string o; (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_InCam_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string X_SR32_DrvFlt_LongName{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).LongName(); } }
public string X_SR32_DrvFlt_ShortName{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ShortName(); } }
public string X_SR32_DrvFlt_MeasUnits{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).MeasUnits(); } }
public string X_SR32_DrvFlt_ForeGColor{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).ForeGColor(); } }
public string X_SR32_DrvFlt_BackGColor{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).BackGColor(); } }
public string X_SR32_DrvFlt_Data{ get { string o; (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.X_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("X_SR32_DrvFlt_Data"); OnPropertyChanged("X_SR32_Data"); } }
public string Xpri_SR32_LongName{ get { return (new DaIAdapter(DaKs.Xpri_SR32)).LongName(); } }
public string Xpri_SR32_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_SR32)).ShortName(); } }
public string Xpri_SR32_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_SR32)).MeasUnits(); } }
public string Xpri_SR32_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_SR32)).ForeGColor(); } }
public string Xpri_SR32_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_SR32)).BackGColor(); } }
public string Xpri_SR32_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_SR32)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_SR32)).SetIn(value); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_SR32forEstop_LongName{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_SR32forEstop_ShortName{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_SR32forEstop_MeasUnits{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_SR32forEstop_ForeGColor{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_SR32forEstop_BackGColor{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_SR32forEstop_Data{ get { string o; (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_SR32forEstop_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_Rdy_LongName{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_Rdy_ShortName{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_Rdy_MeasUnits{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_Rdy_ForeGColor{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_Rdy_BackGColor{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_Rdy_Data{ get { string o; (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_Rdy_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_SwOn_LongName{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_SwOn_ShortName{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_SwOn_MeasUnits{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_SwOn_ForeGColor{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_SwOn_BackGColor{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_SwOn_Data{ get { string o; (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_SwOn_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_OpEn_LongName{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_OpEn_ShortName{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_OpEn_MeasUnits{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_OpEn_ForeGColor{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_OpEn_BackGColor{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_OpEn_Data{ get { string o; (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_OpEn_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_SFlt_LongName{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_SFlt_ShortName{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_SFlt_MeasUnits{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_SFlt_ForeGColor{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_SFlt_BackGColor{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_SFlt_Data{ get { string o; (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_SFlt_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_MtPw_LongName{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_MtPw_ShortName{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_MtPw_MeasUnits{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_MtPw_ForeGColor{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_MtPw_BackGColor{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_MtPw_Data{ get { string o; (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_MtPw_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_QStp_LongName{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_QStp_ShortName{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_QStp_MeasUnits{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_QStp_ForeGColor{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_QStp_BackGColor{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_QStp_Data{ get { string o; (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_QStp_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_SwOnD_LongName{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_SwOnD_ShortName{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_SwOnD_MeasUnits{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_SwOnD_ForeGColor{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_SwOnD_BackGColor{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_SwOnD_Data{ get { string o; (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_SwOnD_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_MPLW_LongName{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_MPLW_ShortName{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_MPLW_MeasUnits{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_MPLW_ForeGColor{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_MPLW_BackGColor{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_MPLW_Data{ get { string o; (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_MPLW_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_MPLE_LongName{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_MPLE_ShortName{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_MPLE_MeasUnits{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_MPLE_ForeGColor{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_MPLE_BackGColor{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_MPLE_Data{ get { string o; (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_MPLE_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_R09_LongName{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_R09_ShortName{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_R09_MeasUnits{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_R09_ForeGColor{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_R09_BackGColor{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_R09_Data{ get { string o; (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_R09_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_MCmp_LongName{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_MCmp_ShortName{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_MCmp_MeasUnits{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_MCmp_ForeGColor{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_MCmp_BackGColor{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_MCmp_Data{ get { string o; (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_MCmp_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_IntLt_LongName{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_IntLt_ShortName{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_IntLt_MeasUnits{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_IntLt_ForeGColor{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_IntLt_BackGColor{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_IntLt_Data{ get { string o; (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_IntLt_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_OpML_LongName{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_OpML_ShortName{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_OpML_MeasUnits{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_OpML_ForeGColor{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_OpML_BackGColor{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_OpML_Data{ get { string o; (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_OpML_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_OpMH_LongName{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_OpMH_ShortName{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_OpMH_MeasUnits{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_OpMH_ForeGColor{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_OpMH_BackGColor{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_OpMH_Data{ get { string o; (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_OpMH_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_LEvt_LongName{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_LEvt_ShortName{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_LEvt_MeasUnits{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_LEvt_ForeGColor{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_LEvt_BackGColor{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_LEvt_Data{ get { string o; (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_LEvt_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_AxisOn_LongName{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_AxisOn_ShortName{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_AxisOn_MeasUnits{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_AxisOn_ForeGColor{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_AxisOn_BackGColor{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_AxisOn_Data{ get { string o; (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_AxisOn_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_EndI_LongName{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_EndI_ShortName{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_EndI_MeasUnits{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_EndI_ForeGColor{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_EndI_BackGColor{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_EndI_Data{ get { string o; (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_EndI_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_PT1_LongName{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_PT1_ShortName{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_PT1_MeasUnits{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_PT1_ForeGColor{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_PT1_BackGColor{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_PT1_Data{ get { string o; (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_PT1_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_PT2_LongName{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_PT2_ShortName{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_PT2_MeasUnits{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_PT2_ForeGColor{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_PT2_BackGColor{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_PT2_Data{ get { string o; (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_PT2_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_PT3_LongName{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_PT3_ShortName{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_PT3_MeasUnits{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_PT3_ForeGColor{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_PT3_BackGColor{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_PT3_Data{ get { string o; (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_PT3_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_PT4_LongName{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_PT4_ShortName{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_PT4_MeasUnits{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_PT4_ForeGColor{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_PT4_BackGColor{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_PT4_Data{ get { string o; (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_PT4_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_AuRu_LongName{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_AuRu_ShortName{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_AuRu_MeasUnits{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_AuRu_ForeGColor{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_AuRu_BackGColor{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_AuRu_Data{ get { string o; (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_AuRu_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_LSwP_LongName{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_LSwP_ShortName{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_LSwP_MeasUnits{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_LSwP_ForeGColor{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_LSwP_BackGColor{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_LSwP_Data{ get { string o; (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_LSwP_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_LSwN_LongName{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_LSwN_ShortName{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_LSwN_MeasUnits{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_LSwN_ForeGColor{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_LSwN_BackGColor{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_LSwN_Data{ get { string o; (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_LSwN_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_PCaps_LongName{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_PCaps_ShortName{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_PCaps_MeasUnits{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_PCaps_ForeGColor{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_PCaps_BackGColor{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_PCaps_Data{ get { string o; (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_PCaps_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_TrGr_LongName{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_TrGr_ShortName{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_TrGr_MeasUnits{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_TrGr_ForeGColor{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_TrGr_BackGColor{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_TrGr_Data{ get { string o; (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_TrGr_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_I2TMt_LongName{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_I2TMt_ShortName{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_I2TMt_MeasUnits{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_I2TMt_ForeGColor{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_I2TMt_BackGColor{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_I2TMt_Data{ get { string o; (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_I2TMt_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_I2TDr_LongName{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_I2TDr_ShortName{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_I2TDr_MeasUnits{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_I2TDr_ForeGColor{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_I2TDr_BackGColor{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_I2TDr_Data{ get { string o; (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_I2TDr_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_InGr_LongName{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_InGr_ShortName{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_InGr_MeasUnits{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_InGr_ForeGColor{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_InGr_BackGColor{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_InGr_Data{ get { string o; (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_InGr_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_FrzCt_LongName{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_FrzCt_ShortName{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_FrzCt_MeasUnits{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_FrzCt_ForeGColor{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_FrzCt_BackGColor{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_FrzCt_Data{ get { string o; (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_FrzCt_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_InCam_LongName{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_InCam_ShortName{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_InCam_MeasUnits{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_InCam_ForeGColor{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_InCam_BackGColor{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_InCam_Data{ get { string o; (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_InCam_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Xpri_SR32_DrvFlt_LongName{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).LongName(); } }
public string Xpri_SR32_DrvFlt_ShortName{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ShortName(); } }
public string Xpri_SR32_DrvFlt_MeasUnits{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).MeasUnits(); } }
public string Xpri_SR32_DrvFlt_ForeGColor{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).ForeGColor(); } }
public string Xpri_SR32_DrvFlt_BackGColor{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).BackGColor(); } }
public string Xpri_SR32_DrvFlt_Data{ get { string o; (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Xpri_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_SR32_DrvFlt_Data"); OnPropertyChanged("Xpri_SR32_Data"); } }
public string Y_SR32_LongName{ get { return (new DaIAdapter(DaKs.Y_SR32)).LongName(); } }
public string Y_SR32_ShortName{ get { return (new DaIAdapter(DaKs.Y_SR32)).ShortName(); } }
public string Y_SR32_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_SR32)).MeasUnits(); } }
public string Y_SR32_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_SR32)).ForeGColor(); } }
public string Y_SR32_BackGColor{ get { return (new DaIAdapter(DaKs.Y_SR32)).BackGColor(); } }
public string Y_SR32_Data{ get { string o; (new DaIAdapter(DaKs.Y_SR32)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_SR32)).SetIn(value); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_SR32forEstop_LongName{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_SR32forEstop_ShortName{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_SR32forEstop_MeasUnits{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_SR32forEstop_ForeGColor{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_SR32forEstop_BackGColor{ get { return (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_SR32forEstop_Data{ get { string o; (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SR32forEstop", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_SR32forEstop_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_Rdy_LongName{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_Rdy_ShortName{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_Rdy_MeasUnits{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_Rdy_ForeGColor{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_Rdy_BackGColor{ get { return (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_Rdy_Data{ get { string o; (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("Rdy", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_Rdy_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_SwOn_LongName{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_SwOn_ShortName{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_SwOn_MeasUnits{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_SwOn_ForeGColor{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_SwOn_BackGColor{ get { return (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_SwOn_Data{ get { string o; (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SwOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_SwOn_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_OpEn_LongName{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_OpEn_ShortName{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_OpEn_MeasUnits{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_OpEn_ForeGColor{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_OpEn_BackGColor{ get { return (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_OpEn_Data{ get { string o; (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OpEn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_OpEn_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_SFlt_LongName{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_SFlt_ShortName{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_SFlt_MeasUnits{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_SFlt_ForeGColor{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_SFlt_BackGColor{ get { return (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_SFlt_Data{ get { string o; (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_SFlt_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_MtPw_LongName{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_MtPw_ShortName{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_MtPw_MeasUnits{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_MtPw_ForeGColor{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_MtPw_BackGColor{ get { return (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_MtPw_Data{ get { string o; (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MtPw", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_MtPw_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_QStp_LongName{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_QStp_ShortName{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_QStp_MeasUnits{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_QStp_ForeGColor{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_QStp_BackGColor{ get { return (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_QStp_Data{ get { string o; (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("QStp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_QStp_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_SwOnD_LongName{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_SwOnD_ShortName{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_SwOnD_MeasUnits{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_SwOnD_ForeGColor{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_SwOnD_BackGColor{ get { return (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_SwOnD_Data{ get { string o; (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SwOnD", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_SwOnD_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_MPLW_LongName{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_MPLW_ShortName{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_MPLW_MeasUnits{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_MPLW_ForeGColor{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_MPLW_BackGColor{ get { return (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_MPLW_Data{ get { string o; (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MPLW", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_MPLW_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_MPLE_LongName{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_MPLE_ShortName{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_MPLE_MeasUnits{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_MPLE_ForeGColor{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_MPLE_BackGColor{ get { return (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_MPLE_Data{ get { string o; (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MPLE", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_MPLE_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_R09_LongName{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_R09_ShortName{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_R09_MeasUnits{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_R09_ForeGColor{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_R09_BackGColor{ get { return (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_R09_Data{ get { string o; (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("R09", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_R09_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_MCmp_LongName{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_MCmp_ShortName{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_MCmp_MeasUnits{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_MCmp_ForeGColor{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_MCmp_BackGColor{ get { return (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_MCmp_Data{ get { string o; (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MCmp", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_MCmp_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_IntLt_LongName{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_IntLt_ShortName{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_IntLt_MeasUnits{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_IntLt_ForeGColor{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_IntLt_BackGColor{ get { return (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_IntLt_Data{ get { string o; (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("IntLt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_IntLt_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_OpML_LongName{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_OpML_ShortName{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_OpML_MeasUnits{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_OpML_ForeGColor{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_OpML_BackGColor{ get { return (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_OpML_Data{ get { string o; (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OpML", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_OpML_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_OpMH_LongName{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_OpMH_ShortName{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_OpMH_MeasUnits{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_OpMH_ForeGColor{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_OpMH_BackGColor{ get { return (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_OpMH_Data{ get { string o; (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OpMH", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_OpMH_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_LEvt_LongName{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_LEvt_ShortName{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_LEvt_MeasUnits{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_LEvt_ForeGColor{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_LEvt_BackGColor{ get { return (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_LEvt_Data{ get { string o; (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("LEvt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_LEvt_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_AxisOn_LongName{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_AxisOn_ShortName{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_AxisOn_MeasUnits{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_AxisOn_ForeGColor{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_AxisOn_BackGColor{ get { return (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_AxisOn_Data{ get { string o; (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("AxisOn", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_AxisOn_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_EndI_LongName{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_EndI_ShortName{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_EndI_MeasUnits{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_EndI_ForeGColor{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_EndI_BackGColor{ get { return (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_EndI_Data{ get { string o; (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("EndI", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_EndI_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_PT1_LongName{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_PT1_ShortName{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_PT1_MeasUnits{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_PT1_ForeGColor{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_PT1_BackGColor{ get { return (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_PT1_Data{ get { string o; (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT1", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_PT1_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_PT2_LongName{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_PT2_ShortName{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_PT2_MeasUnits{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_PT2_ForeGColor{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_PT2_BackGColor{ get { return (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_PT2_Data{ get { string o; (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT2", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_PT2_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_PT3_LongName{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_PT3_ShortName{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_PT3_MeasUnits{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_PT3_ForeGColor{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_PT3_BackGColor{ get { return (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_PT3_Data{ get { string o; (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT3", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_PT3_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_PT4_LongName{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_PT4_ShortName{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_PT4_MeasUnits{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_PT4_ForeGColor{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_PT4_BackGColor{ get { return (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_PT4_Data{ get { string o; (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PT4", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_PT4_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_AuRu_LongName{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_AuRu_ShortName{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_AuRu_MeasUnits{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_AuRu_ForeGColor{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_AuRu_BackGColor{ get { return (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_AuRu_Data{ get { string o; (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("AuRu", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_AuRu_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_LSwP_LongName{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_LSwP_ShortName{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_LSwP_MeasUnits{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_LSwP_ForeGColor{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_LSwP_BackGColor{ get { return (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_LSwP_Data{ get { string o; (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("LSwP", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_LSwP_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_LSwN_LongName{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_LSwN_ShortName{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_LSwN_MeasUnits{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_LSwN_ForeGColor{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_LSwN_BackGColor{ get { return (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_LSwN_Data{ get { string o; (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("LSwN", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_LSwN_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_PCaps_LongName{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_PCaps_ShortName{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_PCaps_MeasUnits{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_PCaps_ForeGColor{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_PCaps_BackGColor{ get { return (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_PCaps_Data{ get { string o; (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PCaps", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_PCaps_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_TrGr_LongName{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_TrGr_ShortName{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_TrGr_MeasUnits{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_TrGr_ForeGColor{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_TrGr_BackGColor{ get { return (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_TrGr_Data{ get { string o; (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("TrGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_TrGr_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_I2TMt_LongName{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_I2TMt_ShortName{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_I2TMt_MeasUnits{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_I2TMt_ForeGColor{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_I2TMt_BackGColor{ get { return (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_I2TMt_Data{ get { string o; (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("I2TMt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_I2TMt_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_I2TDr_LongName{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_I2TDr_ShortName{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_I2TDr_MeasUnits{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_I2TDr_ForeGColor{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_I2TDr_BackGColor{ get { return (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_I2TDr_Data{ get { string o; (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("I2TDr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_I2TDr_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_InGr_LongName{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_InGr_ShortName{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_InGr_MeasUnits{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_InGr_ForeGColor{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_InGr_BackGColor{ get { return (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_InGr_Data{ get { string o; (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("InGr", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_InGr_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_FrzCt_LongName{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_FrzCt_ShortName{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_FrzCt_MeasUnits{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_FrzCt_ForeGColor{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_FrzCt_BackGColor{ get { return (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_FrzCt_Data{ get { string o; (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("FrzCt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_FrzCt_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_InCam_LongName{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_InCam_ShortName{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_InCam_MeasUnits{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_InCam_ForeGColor{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_InCam_BackGColor{ get { return (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_InCam_Data{ get { string o; (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("InCam", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_InCam_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string Y_SR32_DrvFlt_LongName{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).LongName(); } }
public string Y_SR32_DrvFlt_ShortName{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ShortName(); } }
public string Y_SR32_DrvFlt_MeasUnits{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).MeasUnits(); } }
public string Y_SR32_DrvFlt_ForeGColor{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).ForeGColor(); } }
public string Y_SR32_DrvFlt_BackGColor{ get { return (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).BackGColor(); } }
public string Y_SR32_DrvFlt_Data{ get { string o; (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("DrvFlt", (new DaIAdapter(DaKs.Y_SR32)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_SR32_DrvFlt_Data"); OnPropertyChanged("Y_SR32_Data"); } }
public string X_Dig_In_LongName{ get { return (new DaIAdapter(DaKs.X_Dig_In)).LongName(); } }
public string X_Dig_In_ShortName{ get { return (new DaIAdapter(DaKs.X_Dig_In)).ShortName(); } }
public string X_Dig_In_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Dig_In)).MeasUnits(); } }
public string X_Dig_In_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Dig_In)).ForeGColor(); } }
public string X_Dig_In_BackGColor{ get { return (new DaIAdapter(DaKs.X_Dig_In)).BackGColor(); } }
public string X_Dig_In_Data{ get { string o; (new DaIAdapter(DaKs.X_Dig_In)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Dig_In)).SetIn(value); OnPropertyChanged("X_Dig_In_Data"); } }
public string X_Dig_In_LSw1_LongName{ get { return (new SubDaIAdapter("LSw1", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).LongName(); } }
public string X_Dig_In_LSw1_ShortName{ get { return (new SubDaIAdapter("LSw1", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).ShortName(); } }
public string X_Dig_In_LSw1_MeasUnits{ get { return (new SubDaIAdapter("LSw1", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).MeasUnits(); } }
public string X_Dig_In_LSw1_ForeGColor{ get { return (new SubDaIAdapter("LSw1", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).ForeGColor(); } }
public string X_Dig_In_LSw1_BackGColor{ get { return (new SubDaIAdapter("LSw1", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).BackGColor(); } }
public string X_Dig_In_LSw1_Data{ get { string o; (new SubDaIAdapter("LSw1", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("LSw1", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Dig_In_LSw1_Data"); OnPropertyChanged("X_Dig_In_Data"); } }
public string X_Dig_In_ARS_LongName{ get { return (new SubDaIAdapter("ARS", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).LongName(); } }
public string X_Dig_In_ARS_ShortName{ get { return (new SubDaIAdapter("ARS", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).ShortName(); } }
public string X_Dig_In_ARS_MeasUnits{ get { return (new SubDaIAdapter("ARS", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).MeasUnits(); } }
public string X_Dig_In_ARS_ForeGColor{ get { return (new SubDaIAdapter("ARS", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).ForeGColor(); } }
public string X_Dig_In_ARS_BackGColor{ get { return (new SubDaIAdapter("ARS", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).BackGColor(); } }
public string X_Dig_In_ARS_Data{ get { string o; (new SubDaIAdapter("ARS", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("ARS", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Dig_In_ARS_Data"); OnPropertyChanged("X_Dig_In_Data"); } }
public string X_Dig_In_ARStp_LongName{ get { return (new SubDaIAdapter("ARStp", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).LongName(); } }
public string X_Dig_In_ARStp_ShortName{ get { return (new SubDaIAdapter("ARStp", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).ShortName(); } }
public string X_Dig_In_ARStp_MeasUnits{ get { return (new SubDaIAdapter("ARStp", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).MeasUnits(); } }
public string X_Dig_In_ARStp_ForeGColor{ get { return (new SubDaIAdapter("ARStp", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).ForeGColor(); } }
public string X_Dig_In_ARStp_BackGColor{ get { return (new SubDaIAdapter("ARStp", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).BackGColor(); } }
public string X_Dig_In_ARStp_Data{ get { string o; (new SubDaIAdapter("ARStp", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("ARStp", (new DaIAdapter(DaKs.X_Dig_In)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Dig_In_ARStp_Data"); OnPropertyChanged("X_Dig_In_Data"); } }
public string Xpri_Dig_In_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Dig_In)).LongName(); } }
public string Xpri_Dig_In_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Dig_In)).ShortName(); } }
public string Xpri_Dig_In_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Dig_In)).MeasUnits(); } }
public string Xpri_Dig_In_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Dig_In)).ForeGColor(); } }
public string Xpri_Dig_In_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Dig_In)).BackGColor(); } }
public string Xpri_Dig_In_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Dig_In)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Dig_In)).SetIn(value); OnPropertyChanged("Xpri_Dig_In_Data"); } }
public string Xpri_Dig_In_LSw2_LongName{ get { return (new SubDaIAdapter("LSw2", (new DaIAdapter(DaKs.Xpri_Dig_In)).GetDaIi())).LongName(); } }
public string Xpri_Dig_In_LSw2_ShortName{ get { return (new SubDaIAdapter("LSw2", (new DaIAdapter(DaKs.Xpri_Dig_In)).GetDaIi())).ShortName(); } }
public string Xpri_Dig_In_LSw2_MeasUnits{ get { return (new SubDaIAdapter("LSw2", (new DaIAdapter(DaKs.Xpri_Dig_In)).GetDaIi())).MeasUnits(); } }
public string Xpri_Dig_In_LSw2_ForeGColor{ get { return (new SubDaIAdapter("LSw2", (new DaIAdapter(DaKs.Xpri_Dig_In)).GetDaIi())).ForeGColor(); } }
public string Xpri_Dig_In_LSw2_BackGColor{ get { return (new SubDaIAdapter("LSw2", (new DaIAdapter(DaKs.Xpri_Dig_In)).GetDaIi())).BackGColor(); } }
public string Xpri_Dig_In_LSw2_Data{ get { string o; (new SubDaIAdapter("LSw2", (new DaIAdapter(DaKs.Xpri_Dig_In)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("LSw2", (new DaIAdapter(DaKs.Xpri_Dig_In)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Dig_In_LSw2_Data"); OnPropertyChanged("Xpri_Dig_In_Data"); } }
public string Y_Dig_In_LongName{ get { return (new DaIAdapter(DaKs.Y_Dig_In)).LongName(); } }
public string Y_Dig_In_ShortName{ get { return (new DaIAdapter(DaKs.Y_Dig_In)).ShortName(); } }
public string Y_Dig_In_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Dig_In)).MeasUnits(); } }
public string Y_Dig_In_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Dig_In)).ForeGColor(); } }
public string Y_Dig_In_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Dig_In)).BackGColor(); } }
public string Y_Dig_In_Data{ get { string o; (new DaIAdapter(DaKs.Y_Dig_In)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Dig_In)).SetIn(value); OnPropertyChanged("Y_Dig_In_Data"); } }
public string Y_Dig_In_JyRL_LongName{ get { return (new SubDaIAdapter("JyRL", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).LongName(); } }
public string Y_Dig_In_JyRL_ShortName{ get { return (new SubDaIAdapter("JyRL", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).ShortName(); } }
public string Y_Dig_In_JyRL_MeasUnits{ get { return (new SubDaIAdapter("JyRL", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).MeasUnits(); } }
public string Y_Dig_In_JyRL_ForeGColor{ get { return (new SubDaIAdapter("JyRL", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).ForeGColor(); } }
public string Y_Dig_In_JyRL_BackGColor{ get { return (new SubDaIAdapter("JyRL", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).BackGColor(); } }
public string Y_Dig_In_JyRL_Data{ get { string o; (new SubDaIAdapter("JyRL", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("JyRL", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Dig_In_JyRL_Data"); OnPropertyChanged("Y_Dig_In_Data"); } }
public string Y_Dig_In_JyS_LongName{ get { return (new SubDaIAdapter("JyS", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).LongName(); } }
public string Y_Dig_In_JyS_ShortName{ get { return (new SubDaIAdapter("JyS", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).ShortName(); } }
public string Y_Dig_In_JyS_MeasUnits{ get { return (new SubDaIAdapter("JyS", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).MeasUnits(); } }
public string Y_Dig_In_JyS_ForeGColor{ get { return (new SubDaIAdapter("JyS", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).ForeGColor(); } }
public string Y_Dig_In_JyS_BackGColor{ get { return (new SubDaIAdapter("JyS", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).BackGColor(); } }
public string Y_Dig_In_JyS_Data{ get { string o; (new SubDaIAdapter("JyS", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("JyS", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Dig_In_JyS_Data"); OnPropertyChanged("Y_Dig_In_Data"); } }
public string Y_Dig_In_JyStp_LongName{ get { return (new SubDaIAdapter("JyStp", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).LongName(); } }
public string Y_Dig_In_JyStp_ShortName{ get { return (new SubDaIAdapter("JyStp", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).ShortName(); } }
public string Y_Dig_In_JyStp_MeasUnits{ get { return (new SubDaIAdapter("JyStp", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).MeasUnits(); } }
public string Y_Dig_In_JyStp_ForeGColor{ get { return (new SubDaIAdapter("JyStp", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).ForeGColor(); } }
public string Y_Dig_In_JyStp_BackGColor{ get { return (new SubDaIAdapter("JyStp", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).BackGColor(); } }
public string Y_Dig_In_JyStp_Data{ get { string o; (new SubDaIAdapter("JyStp", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("JyStp", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Dig_In_JyStp_Data"); OnPropertyChanged("Y_Dig_In_Data"); } }
public string Y_Dig_In_JyCmd_LongName{ get { return (new SubDaIAdapter("JyCmd", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).LongName(); } }
public string Y_Dig_In_JyCmd_ShortName{ get { return (new SubDaIAdapter("JyCmd", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).ShortName(); } }
public string Y_Dig_In_JyCmd_MeasUnits{ get { return (new SubDaIAdapter("JyCmd", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).MeasUnits(); } }
public string Y_Dig_In_JyCmd_ForeGColor{ get { return (new SubDaIAdapter("JyCmd", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).ForeGColor(); } }
public string Y_Dig_In_JyCmd_BackGColor{ get { return (new SubDaIAdapter("JyCmd", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).BackGColor(); } }
public string Y_Dig_In_JyCmd_Data{ get { string o; (new SubDaIAdapter("JyCmd", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("JyCmd", (new DaIAdapter(DaKs.Y_Dig_In)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Dig_In_JyCmd_Data"); OnPropertyChanged("Y_Dig_In_Data"); } }
public string X_Dig_Out_LongName{ get { return (new DaIAdapter(DaKs.X_Dig_Out)).LongName(); } }
public string X_Dig_Out_ShortName{ get { return (new DaIAdapter(DaKs.X_Dig_Out)).ShortName(); } }
public string X_Dig_Out_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Dig_Out)).MeasUnits(); } }
public string X_Dig_Out_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Dig_Out)).ForeGColor(); } }
public string X_Dig_Out_BackGColor{ get { return (new DaIAdapter(DaKs.X_Dig_Out)).BackGColor(); } }
public string X_Dig_Out_Data{ get { string o; (new DaIAdapter(DaKs.X_Dig_Out)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Dig_Out)).SetIn(value); OnPropertyChanged("X_Dig_Out_Data"); } }
public string X_Dig_Out_StFi_LongName{ get { return (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).LongName(); } }
public string X_Dig_Out_StFi_ShortName{ get { return (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).ShortName(); } }
public string X_Dig_Out_StFi_MeasUnits{ get { return (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).MeasUnits(); } }
public string X_Dig_Out_StFi_ForeGColor{ get { return (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).ForeGColor(); } }
public string X_Dig_Out_StFi_BackGColor{ get { return (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).BackGColor(); } }
public string X_Dig_Out_StFi_Data{ get { string o; (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Dig_Out_StFi_Data"); OnPropertyChanged("X_Dig_Out_Data"); } }
public string X_Dig_Out_StBk_LongName{ get { return (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).LongName(); } }
public string X_Dig_Out_StBk_ShortName{ get { return (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).ShortName(); } }
public string X_Dig_Out_StBk_MeasUnits{ get { return (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).MeasUnits(); } }
public string X_Dig_Out_StBk_ForeGColor{ get { return (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).ForeGColor(); } }
public string X_Dig_Out_StBk_BackGColor{ get { return (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).BackGColor(); } }
public string X_Dig_Out_StBk_Data{ get { string o; (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Dig_Out_StBk_Data"); OnPropertyChanged("X_Dig_Out_Data"); } }
public string X_Dig_Out_StRL_LongName{ get { return (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).LongName(); } }
public string X_Dig_Out_StRL_ShortName{ get { return (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).ShortName(); } }
public string X_Dig_Out_StRL_MeasUnits{ get { return (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).MeasUnits(); } }
public string X_Dig_Out_StRL_ForeGColor{ get { return (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).ForeGColor(); } }
public string X_Dig_Out_StRL_BackGColor{ get { return (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).BackGColor(); } }
public string X_Dig_Out_StRL_Data{ get { string o; (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Dig_Out_StRL_Data"); OnPropertyChanged("X_Dig_Out_Data"); } }
public string X_Dig_Out_Horn_LongName{ get { return (new SubDaIAdapter("Horn", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).LongName(); } }
public string X_Dig_Out_Horn_ShortName{ get { return (new SubDaIAdapter("Horn", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).ShortName(); } }
public string X_Dig_Out_Horn_MeasUnits{ get { return (new SubDaIAdapter("Horn", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).MeasUnits(); } }
public string X_Dig_Out_Horn_ForeGColor{ get { return (new SubDaIAdapter("Horn", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).ForeGColor(); } }
public string X_Dig_Out_Horn_BackGColor{ get { return (new SubDaIAdapter("Horn", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).BackGColor(); } }
public string X_Dig_Out_Horn_Data{ get { string o; (new SubDaIAdapter("Horn", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("Horn", (new DaIAdapter(DaKs.X_Dig_Out)).GetDaIi())).SetIn(value); OnPropertyChanged("X_Dig_Out_Horn_Data"); OnPropertyChanged("X_Dig_Out_Data"); } }
public string Xpri_Dig_Out_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Dig_Out)).LongName(); } }
public string Xpri_Dig_Out_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Dig_Out)).ShortName(); } }
public string Xpri_Dig_Out_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Dig_Out)).MeasUnits(); } }
public string Xpri_Dig_Out_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Dig_Out)).ForeGColor(); } }
public string Xpri_Dig_Out_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Dig_Out)).BackGColor(); } }
public string Xpri_Dig_Out_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Dig_Out)).SetIn(value); OnPropertyChanged("Xpri_Dig_Out_Data"); } }
public string Xpri_Dig_Out_StFi_LongName{ get { return (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).LongName(); } }
public string Xpri_Dig_Out_StFi_ShortName{ get { return (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).ShortName(); } }
public string Xpri_Dig_Out_StFi_MeasUnits{ get { return (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).MeasUnits(); } }
public string Xpri_Dig_Out_StFi_ForeGColor{ get { return (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).ForeGColor(); } }
public string Xpri_Dig_Out_StFi_BackGColor{ get { return (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).BackGColor(); } }
public string Xpri_Dig_Out_StFi_Data{ get { string o; (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("StFi", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Dig_Out_StFi_Data"); OnPropertyChanged("Xpri_Dig_Out_Data"); } }
public string Xpri_Dig_Out_StBk_LongName{ get { return (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).LongName(); } }
public string Xpri_Dig_Out_StBk_ShortName{ get { return (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).ShortName(); } }
public string Xpri_Dig_Out_StBk_MeasUnits{ get { return (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).MeasUnits(); } }
public string Xpri_Dig_Out_StBk_ForeGColor{ get { return (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).ForeGColor(); } }
public string Xpri_Dig_Out_StBk_BackGColor{ get { return (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).BackGColor(); } }
public string Xpri_Dig_Out_StBk_Data{ get { string o; (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("StBk", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Dig_Out_StBk_Data"); OnPropertyChanged("Xpri_Dig_Out_Data"); } }
public string Xpri_Dig_Out_StRL_LongName{ get { return (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).LongName(); } }
public string Xpri_Dig_Out_StRL_ShortName{ get { return (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).ShortName(); } }
public string Xpri_Dig_Out_StRL_MeasUnits{ get { return (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).MeasUnits(); } }
public string Xpri_Dig_Out_StRL_ForeGColor{ get { return (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).ForeGColor(); } }
public string Xpri_Dig_Out_StRL_BackGColor{ get { return (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).BackGColor(); } }
public string Xpri_Dig_Out_StRL_Data{ get { string o; (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("StRL", (new DaIAdapter(DaKs.Xpri_Dig_Out)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_Dig_Out_StRL_Data"); OnPropertyChanged("Xpri_Dig_Out_Data"); } }
public string Y_Dig_Out_LongName{ get { return (new DaIAdapter(DaKs.Y_Dig_Out)).LongName(); } }
public string Y_Dig_Out_ShortName{ get { return (new DaIAdapter(DaKs.Y_Dig_Out)).ShortName(); } }
public string Y_Dig_Out_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Dig_Out)).MeasUnits(); } }
public string Y_Dig_Out_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Dig_Out)).ForeGColor(); } }
public string Y_Dig_Out_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Dig_Out)).BackGColor(); } }
public string Y_Dig_Out_Data{ get { string o; (new DaIAdapter(DaKs.Y_Dig_Out)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Dig_Out)).SetIn(value); OnPropertyChanged("Y_Dig_Out_Data"); } }
public string Y_Dig_Out_FSFi_LongName{ get { return (new SubDaIAdapter("FSFi", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).LongName(); } }
public string Y_Dig_Out_FSFi_ShortName{ get { return (new SubDaIAdapter("FSFi", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).ShortName(); } }
public string Y_Dig_Out_FSFi_MeasUnits{ get { return (new SubDaIAdapter("FSFi", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).MeasUnits(); } }
public string Y_Dig_Out_FSFi_ForeGColor{ get { return (new SubDaIAdapter("FSFi", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).ForeGColor(); } }
public string Y_Dig_Out_FSFi_BackGColor{ get { return (new SubDaIAdapter("FSFi", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).BackGColor(); } }
public string Y_Dig_Out_FSFi_Data{ get { string o; (new SubDaIAdapter("FSFi", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("FSFi", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Dig_Out_FSFi_Data"); OnPropertyChanged("Y_Dig_Out_Data"); } }
public string Y_Dig_Out_FSBk_LongName{ get { return (new SubDaIAdapter("FSBk", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).LongName(); } }
public string Y_Dig_Out_FSBk_ShortName{ get { return (new SubDaIAdapter("FSBk", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).ShortName(); } }
public string Y_Dig_Out_FSBk_MeasUnits{ get { return (new SubDaIAdapter("FSBk", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).MeasUnits(); } }
public string Y_Dig_Out_FSBk_ForeGColor{ get { return (new SubDaIAdapter("FSBk", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).ForeGColor(); } }
public string Y_Dig_Out_FSBk_BackGColor{ get { return (new SubDaIAdapter("FSBk", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).BackGColor(); } }
public string Y_Dig_Out_FSBk_Data{ get { string o; (new SubDaIAdapter("FSBk", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("FSBk", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Dig_Out_FSBk_Data"); OnPropertyChanged("Y_Dig_Out_Data"); } }
public string Y_Dig_Out_FSRL_LongName{ get { return (new SubDaIAdapter("FSRL", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).LongName(); } }
public string Y_Dig_Out_FSRL_ShortName{ get { return (new SubDaIAdapter("FSRL", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).ShortName(); } }
public string Y_Dig_Out_FSRL_MeasUnits{ get { return (new SubDaIAdapter("FSRL", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).MeasUnits(); } }
public string Y_Dig_Out_FSRL_ForeGColor{ get { return (new SubDaIAdapter("FSRL", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).ForeGColor(); } }
public string Y_Dig_Out_FSRL_BackGColor{ get { return (new SubDaIAdapter("FSRL", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).BackGColor(); } }
public string Y_Dig_Out_FSRL_Data{ get { string o; (new SubDaIAdapter("FSRL", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("FSRL", (new DaIAdapter(DaKs.Y_Dig_Out)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_Dig_Out_FSRL_Data"); OnPropertyChanged("Y_Dig_Out_Data"); } }
public string X_MER_LongName{ get { return (new DaIAdapter(DaKs.X_MER)).LongName(); } }
public string X_MER_ShortName{ get { return (new DaIAdapter(DaKs.X_MER)).ShortName(); } }
public string X_MER_MeasUnits{ get { return (new DaIAdapter(DaKs.X_MER)).MeasUnits(); } }
public string X_MER_ForeGColor{ get { return (new DaIAdapter(DaKs.X_MER)).ForeGColor(); } }
public string X_MER_BackGColor{ get { return (new DaIAdapter(DaKs.X_MER)).BackGColor(); } }
public string X_MER_Data{ get { string o; (new DaIAdapter(DaKs.X_MER)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_MER)).SetIn(value); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_MERforEstop_LongName{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_MERforEstop_ShortName{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_MERforEstop_MeasUnits{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_MERforEstop_ForeGColor{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_MERforEstop_BackGColor{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_MERforEstop_Data{ get { string o; (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_MERforEstop_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_CANE_LongName{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_CANE_ShortName{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_CANE_MeasUnits{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_CANE_ForeGColor{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_CANE_BackGColor{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_CANE_Data{ get { string o; (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_CANE_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_Shrt_LongName{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_Shrt_ShortName{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_Shrt_MeasUnits{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_Shrt_ForeGColor{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_Shrt_BackGColor{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_Shrt_Data{ get { string o; (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_Shrt_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_SetE_LongName{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_SetE_ShortName{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_SetE_MeasUnits{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_SetE_ForeGColor{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_SetE_BackGColor{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_SetE_Data{ get { string o; (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_SetE_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_CtlE_LongName{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_CtlE_ShortName{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_CtlE_MeasUnits{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_CtlE_ForeGColor{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_CtlE_BackGColor{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_CtlE_Data{ get { string o; (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_CtlE_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_ComE_LongName{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_ComE_ShortName{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_ComE_MeasUnits{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_ComE_ForeGColor{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_ComE_BackGColor{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_ComE_Data{ get { string o; (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_ComE_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_MtPoW_LongName{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_MtPoW_ShortName{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_MtPoW_MeasUnits{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_MtPoW_ForeGColor{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_MtPoW_BackGColor{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_MtPoW_Data{ get { string o; (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_MtPoW_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_PLSw_LongName{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_PLSw_ShortName{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_PLSw_MeasUnits{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_PLSw_ForeGColor{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_PLSw_BackGColor{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_PLSw_Data{ get { string o; (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_PLSw_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_NLSw_LongName{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_NLSw_ShortName{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_NLSw_MeasUnits{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_NLSw_ForeGColor{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_NLSw_BackGColor{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_NLSw_Data{ get { string o; (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_NLSw_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_OvrI_LongName{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_OvrI_ShortName{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_OvrI_MeasUnits{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_OvrI_ForeGColor{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_OvrI_BackGColor{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_OvrI_Data{ get { string o; (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_OvrI_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_I2T_LongName{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_I2T_ShortName{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_I2T_MeasUnits{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_I2T_ForeGColor{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_I2T_BackGColor{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_I2T_Data{ get { string o; (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_I2T_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_MOvrT_LongName{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_MOvrT_ShortName{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_MOvrT_MeasUnits{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_MOvrT_ForeGColor{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_MOvrT_BackGColor{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_MOvrT_Data{ get { string o; (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_MOvrT_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_DOvrT_LongName{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_DOvrT_ShortName{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_DOvrT_MeasUnits{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_DOvrT_ForeGColor{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_DOvrT_BackGColor{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_DOvrT_Data{ get { string o; (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_DOvrT_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_OvrV_LongName{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_OvrV_ShortName{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_OvrV_MeasUnits{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_OvrV_ForeGColor{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_OvrV_BackGColor{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_OvrV_Data{ get { string o; (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_OvrV_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_UndV_LongName{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_UndV_ShortName{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_UndV_MeasUnits{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_UndV_ForeGColor{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_UndV_BackGColor{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_UndV_Data{ get { string o; (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_UndV_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_CmdE_LongName{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_CmdE_ShortName{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_CmdE_MeasUnits{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_CmdE_ForeGColor{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_CmdE_BackGColor{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_CmdE_Data{ get { string o; (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_CmdE_Data"); OnPropertyChanged("X_MER_Data"); } }
public string X_MER_DisIn_LongName{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).LongName(); } }
public string X_MER_DisIn_ShortName{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ShortName(); } }
public string X_MER_DisIn_MeasUnits{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).MeasUnits(); } }
public string X_MER_DisIn_ForeGColor{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).ForeGColor(); } }
public string X_MER_DisIn_BackGColor{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).BackGColor(); } }
public string X_MER_DisIn_Data{ get { string o; (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.X_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("X_MER_DisIn_Data"); OnPropertyChanged("X_MER_Data"); } }
public string Xpri_MER_LongName{ get { return (new DaIAdapter(DaKs.Xpri_MER)).LongName(); } }
public string Xpri_MER_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_MER)).ShortName(); } }
public string Xpri_MER_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_MER)).MeasUnits(); } }
public string Xpri_MER_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_MER)).ForeGColor(); } }
public string Xpri_MER_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_MER)).BackGColor(); } }
public string Xpri_MER_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_MER)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_MER)).SetIn(value); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_MERforEstop_LongName{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_MERforEstop_ShortName{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_MERforEstop_MeasUnits{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_MERforEstop_ForeGColor{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_MERforEstop_BackGColor{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_MERforEstop_Data{ get { string o; (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_MERforEstop_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_CANE_LongName{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_CANE_ShortName{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_CANE_MeasUnits{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_CANE_ForeGColor{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_CANE_BackGColor{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_CANE_Data{ get { string o; (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_CANE_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_Shrt_LongName{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_Shrt_ShortName{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_Shrt_MeasUnits{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_Shrt_ForeGColor{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_Shrt_BackGColor{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_Shrt_Data{ get { string o; (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_Shrt_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_SetE_LongName{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_SetE_ShortName{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_SetE_MeasUnits{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_SetE_ForeGColor{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_SetE_BackGColor{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_SetE_Data{ get { string o; (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_SetE_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_CtlE_LongName{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_CtlE_ShortName{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_CtlE_MeasUnits{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_CtlE_ForeGColor{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_CtlE_BackGColor{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_CtlE_Data{ get { string o; (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_CtlE_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_ComE_LongName{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_ComE_ShortName{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_ComE_MeasUnits{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_ComE_ForeGColor{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_ComE_BackGColor{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_ComE_Data{ get { string o; (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_ComE_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_MtPoW_LongName{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_MtPoW_ShortName{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_MtPoW_MeasUnits{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_MtPoW_ForeGColor{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_MtPoW_BackGColor{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_MtPoW_Data{ get { string o; (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_MtPoW_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_PLSw_LongName{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_PLSw_ShortName{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_PLSw_MeasUnits{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_PLSw_ForeGColor{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_PLSw_BackGColor{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_PLSw_Data{ get { string o; (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_PLSw_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_NLSw_LongName{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_NLSw_ShortName{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_NLSw_MeasUnits{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_NLSw_ForeGColor{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_NLSw_BackGColor{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_NLSw_Data{ get { string o; (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_NLSw_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_OvrI_LongName{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_OvrI_ShortName{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_OvrI_MeasUnits{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_OvrI_ForeGColor{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_OvrI_BackGColor{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_OvrI_Data{ get { string o; (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_OvrI_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_I2T_LongName{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_I2T_ShortName{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_I2T_MeasUnits{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_I2T_ForeGColor{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_I2T_BackGColor{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_I2T_Data{ get { string o; (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_I2T_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_MOvrT_LongName{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_MOvrT_ShortName{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_MOvrT_MeasUnits{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_MOvrT_ForeGColor{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_MOvrT_BackGColor{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_MOvrT_Data{ get { string o; (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_MOvrT_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_DOvrT_LongName{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_DOvrT_ShortName{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_DOvrT_MeasUnits{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_DOvrT_ForeGColor{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_DOvrT_BackGColor{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_DOvrT_Data{ get { string o; (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_DOvrT_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_OvrV_LongName{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_OvrV_ShortName{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_OvrV_MeasUnits{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_OvrV_ForeGColor{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_OvrV_BackGColor{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_OvrV_Data{ get { string o; (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_OvrV_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_UndV_LongName{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_UndV_ShortName{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_UndV_MeasUnits{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_UndV_ForeGColor{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_UndV_BackGColor{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_UndV_Data{ get { string o; (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_UndV_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_CmdE_LongName{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_CmdE_ShortName{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_CmdE_MeasUnits{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_CmdE_ForeGColor{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_CmdE_BackGColor{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_CmdE_Data{ get { string o; (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_CmdE_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Xpri_MER_DisIn_LongName{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).LongName(); } }
public string Xpri_MER_DisIn_ShortName{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ShortName(); } }
public string Xpri_MER_DisIn_MeasUnits{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).MeasUnits(); } }
public string Xpri_MER_DisIn_ForeGColor{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).ForeGColor(); } }
public string Xpri_MER_DisIn_BackGColor{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).BackGColor(); } }
public string Xpri_MER_DisIn_Data{ get { string o; (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Xpri_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Xpri_MER_DisIn_Data"); OnPropertyChanged("Xpri_MER_Data"); } }
public string Y_MER_LongName{ get { return (new DaIAdapter(DaKs.Y_MER)).LongName(); } }
public string Y_MER_ShortName{ get { return (new DaIAdapter(DaKs.Y_MER)).ShortName(); } }
public string Y_MER_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_MER)).MeasUnits(); } }
public string Y_MER_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_MER)).ForeGColor(); } }
public string Y_MER_BackGColor{ get { return (new DaIAdapter(DaKs.Y_MER)).BackGColor(); } }
public string Y_MER_Data{ get { string o; (new DaIAdapter(DaKs.Y_MER)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_MER)).SetIn(value); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_MERforEstop_LongName{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_MERforEstop_ShortName{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_MERforEstop_MeasUnits{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_MERforEstop_ForeGColor{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_MERforEstop_BackGColor{ get { return (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_MERforEstop_Data{ get { string o; (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MERforEstop", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_MERforEstop_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_CANE_LongName{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_CANE_ShortName{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_CANE_MeasUnits{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_CANE_ForeGColor{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_CANE_BackGColor{ get { return (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_CANE_Data{ get { string o; (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("CANE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_CANE_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_Shrt_LongName{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_Shrt_ShortName{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_Shrt_MeasUnits{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_Shrt_ForeGColor{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_Shrt_BackGColor{ get { return (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_Shrt_Data{ get { string o; (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("Shrt", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_Shrt_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_SetE_LongName{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_SetE_ShortName{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_SetE_MeasUnits{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_SetE_ForeGColor{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_SetE_BackGColor{ get { return (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_SetE_Data{ get { string o; (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("SetE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_SetE_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_CtlE_LongName{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_CtlE_ShortName{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_CtlE_MeasUnits{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_CtlE_ForeGColor{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_CtlE_BackGColor{ get { return (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_CtlE_Data{ get { string o; (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("CtlE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_CtlE_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_ComE_LongName{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_ComE_ShortName{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_ComE_MeasUnits{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_ComE_ForeGColor{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_ComE_BackGColor{ get { return (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_ComE_Data{ get { string o; (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("ComE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_ComE_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_MtPoW_LongName{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_MtPoW_ShortName{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_MtPoW_MeasUnits{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_MtPoW_ForeGColor{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_MtPoW_BackGColor{ get { return (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_MtPoW_Data{ get { string o; (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MtPoW", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_MtPoW_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_PLSw_LongName{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_PLSw_ShortName{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_PLSw_MeasUnits{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_PLSw_ForeGColor{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_PLSw_BackGColor{ get { return (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_PLSw_Data{ get { string o; (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("PLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_PLSw_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_NLSw_LongName{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_NLSw_ShortName{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_NLSw_MeasUnits{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_NLSw_ForeGColor{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_NLSw_BackGColor{ get { return (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_NLSw_Data{ get { string o; (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("NLSw", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_NLSw_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_OvrI_LongName{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_OvrI_ShortName{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_OvrI_MeasUnits{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_OvrI_ForeGColor{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_OvrI_BackGColor{ get { return (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_OvrI_Data{ get { string o; (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OvrI", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_OvrI_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_I2T_LongName{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_I2T_ShortName{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_I2T_MeasUnits{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_I2T_ForeGColor{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_I2T_BackGColor{ get { return (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_I2T_Data{ get { string o; (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("I2T", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_I2T_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_MOvrT_LongName{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_MOvrT_ShortName{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_MOvrT_MeasUnits{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_MOvrT_ForeGColor{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_MOvrT_BackGColor{ get { return (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_MOvrT_Data{ get { string o; (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("MOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_MOvrT_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_DOvrT_LongName{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_DOvrT_ShortName{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_DOvrT_MeasUnits{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_DOvrT_ForeGColor{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_DOvrT_BackGColor{ get { return (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_DOvrT_Data{ get { string o; (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("DOvrT", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_DOvrT_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_OvrV_LongName{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_OvrV_ShortName{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_OvrV_MeasUnits{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_OvrV_ForeGColor{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_OvrV_BackGColor{ get { return (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_OvrV_Data{ get { string o; (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("OvrV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_OvrV_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_UndV_LongName{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_UndV_ShortName{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_UndV_MeasUnits{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_UndV_ForeGColor{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_UndV_BackGColor{ get { return (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_UndV_Data{ get { string o; (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("UndV", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_UndV_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_CmdE_LongName{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_CmdE_ShortName{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_CmdE_MeasUnits{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_CmdE_ForeGColor{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_CmdE_BackGColor{ get { return (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_CmdE_Data{ get { string o; (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("CmdE", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_CmdE_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string Y_MER_DisIn_LongName{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).LongName(); } }
public string Y_MER_DisIn_ShortName{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ShortName(); } }
public string Y_MER_DisIn_MeasUnits{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).MeasUnits(); } }
public string Y_MER_DisIn_ForeGColor{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).ForeGColor(); } }
public string Y_MER_DisIn_BackGColor{ get { return (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).BackGColor(); } }
public string Y_MER_DisIn_Data{ get { string o; (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).GetOut(out o); return o; } set { (new SubDaIAdapter("DisIn", (new DaIAdapter(DaKs.Y_MER)).GetDaIi())).SetIn(value); OnPropertyChanged("Y_MER_DisIn_Data"); OnPropertyChanged("Y_MER_Data"); } }
public string X_MER_Msk_LongName{ get { return (new DaIAdapter(DaKs.X_MER_Msk)).LongName(); } }
public string X_MER_Msk_ShortName{ get { return (new DaIAdapter(DaKs.X_MER_Msk)).ShortName(); } }
public string X_MER_Msk_MeasUnits{ get { return (new DaIAdapter(DaKs.X_MER_Msk)).MeasUnits(); } }
public string X_MER_Msk_ForeGColor{ get { return (new DaIAdapter(DaKs.X_MER_Msk)).ForeGColor(); } }
public string X_MER_Msk_BackGColor{ get { return (new DaIAdapter(DaKs.X_MER_Msk)).BackGColor(); } }
public string X_MER_Msk_Data{ get { string o; (new DaIAdapter(DaKs.X_MER_Msk)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_MER_Msk)).SetIn(value); OnPropertyChanged("X_MER_Msk_Data"); } }
public string Xpri_MER_Msk_LongName{ get { return (new DaIAdapter(DaKs.Xpri_MER_Msk)).LongName(); } }
public string Xpri_MER_Msk_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_MER_Msk)).ShortName(); } }
public string Xpri_MER_Msk_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_MER_Msk)).MeasUnits(); } }
public string Xpri_MER_Msk_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_MER_Msk)).ForeGColor(); } }
public string Xpri_MER_Msk_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_MER_Msk)).BackGColor(); } }
public string Xpri_MER_Msk_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_MER_Msk)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_MER_Msk)).SetIn(value); OnPropertyChanged("Xpri_MER_Msk_Data"); } }
public string Y_MER_Msk_LongName{ get { return (new DaIAdapter(DaKs.Y_MER_Msk)).LongName(); } }
public string Y_MER_Msk_ShortName{ get { return (new DaIAdapter(DaKs.Y_MER_Msk)).ShortName(); } }
public string Y_MER_Msk_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_MER_Msk)).MeasUnits(); } }
public string Y_MER_Msk_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_MER_Msk)).ForeGColor(); } }
public string Y_MER_Msk_BackGColor{ get { return (new DaIAdapter(DaKs.Y_MER_Msk)).BackGColor(); } }
public string Y_MER_Msk_Data{ get { string o; (new DaIAdapter(DaKs.Y_MER_Msk)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_MER_Msk)).SetIn(value); OnPropertyChanged("Y_MER_Msk_Data"); } }
public string X_Drv_Err_LongName{ get { return (new DaIAdapter(DaKs.X_Drv_Err)).LongName(); } }
public string X_Drv_Err_ShortName{ get { return (new DaIAdapter(DaKs.X_Drv_Err)).ShortName(); } }
public string X_Drv_Err_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Drv_Err)).MeasUnits(); } }
public string X_Drv_Err_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Drv_Err)).ForeGColor(); } }
public string X_Drv_Err_BackGColor{ get { return (new DaIAdapter(DaKs.X_Drv_Err)).BackGColor(); } }
public string X_Drv_Err_Data{ get { string o; (new DaIAdapter(DaKs.X_Drv_Err)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Drv_Err)).SetIn(value); OnPropertyChanged("X_Drv_Err_Data"); } }
public string Xpri_Drv_Err_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Drv_Err)).LongName(); } }
public string Xpri_Drv_Err_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Drv_Err)).ShortName(); } }
public string Xpri_Drv_Err_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Drv_Err)).MeasUnits(); } }
public string Xpri_Drv_Err_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Drv_Err)).ForeGColor(); } }
public string Xpri_Drv_Err_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Drv_Err)).BackGColor(); } }
public string Xpri_Drv_Err_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Drv_Err)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Drv_Err)).SetIn(value); OnPropertyChanged("Xpri_Drv_Err_Data"); } }
public string Y_Drv_Err_LongName{ get { return (new DaIAdapter(DaKs.Y_Drv_Err)).LongName(); } }
public string Y_Drv_Err_ShortName{ get { return (new DaIAdapter(DaKs.Y_Drv_Err)).ShortName(); } }
public string Y_Drv_Err_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Drv_Err)).MeasUnits(); } }
public string Y_Drv_Err_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Drv_Err)).ForeGColor(); } }
public string Y_Drv_Err_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Drv_Err)).BackGColor(); } }
public string Y_Drv_Err_Data{ get { string o; (new DaIAdapter(DaKs.Y_Drv_Err)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Drv_Err)).SetIn(value); OnPropertyChanged("Y_Drv_Err_Data"); } }
public string X_Bridg_Loc_LongName{ get { return (new DaIAdapter(DaKs.X_Bridg_Loc)).LongName(); } }
public string X_Bridg_Loc_ShortName{ get { return (new DaIAdapter(DaKs.X_Bridg_Loc)).ShortName(); } }
public string X_Bridg_Loc_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Bridg_Loc)).MeasUnits(); } }
public string X_Bridg_Loc_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Bridg_Loc)).ForeGColor(); } }
public string X_Bridg_Loc_BackGColor{ get { return (new DaIAdapter(DaKs.X_Bridg_Loc)).BackGColor(); } }
public string X_Bridg_Loc_Data{ get { string o; (new DaIAdapter(DaKs.X_Bridg_Loc)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Bridg_Loc)).SetIn(value); OnPropertyChanged("X_Bridg_Loc_Data"); } }
public string Xpri_Bridg_Loc_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Loc)).LongName(); } }
public string Xpri_Bridg_Loc_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Loc)).ShortName(); } }
public string Xpri_Bridg_Loc_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Loc)).MeasUnits(); } }
public string Xpri_Bridg_Loc_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Loc)).ForeGColor(); } }
public string Xpri_Bridg_Loc_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Loc)).BackGColor(); } }
public string Xpri_Bridg_Loc_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Bridg_Loc)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Bridg_Loc)).SetIn(value); OnPropertyChanged("Xpri_Bridg_Loc_Data"); } }
public string Y_Crg_Loc_LongName{ get { return (new DaIAdapter(DaKs.Y_Crg_Loc)).LongName(); } }
public string Y_Crg_Loc_ShortName{ get { return (new DaIAdapter(DaKs.Y_Crg_Loc)).ShortName(); } }
public string Y_Crg_Loc_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Crg_Loc)).MeasUnits(); } }
public string Y_Crg_Loc_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Crg_Loc)).ForeGColor(); } }
public string Y_Crg_Loc_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Crg_Loc)).BackGColor(); } }
public string Y_Crg_Loc_Data{ get { string o; (new DaIAdapter(DaKs.Y_Crg_Loc)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Crg_Loc)).SetIn(value); OnPropertyChanged("Y_Crg_Loc_Data"); } }
public string X_Bridg_Pos_Err_LongName{ get { return (new DaIAdapter(DaKs.X_Bridg_Pos_Err)).LongName(); } }
public string X_Bridg_Pos_Err_ShortName{ get { return (new DaIAdapter(DaKs.X_Bridg_Pos_Err)).ShortName(); } }
public string X_Bridg_Pos_Err_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Bridg_Pos_Err)).MeasUnits(); } }
public string X_Bridg_Pos_Err_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Bridg_Pos_Err)).ForeGColor(); } }
public string X_Bridg_Pos_Err_BackGColor{ get { return (new DaIAdapter(DaKs.X_Bridg_Pos_Err)).BackGColor(); } }
public string X_Bridg_Pos_Err_Data{ get { string o; (new DaIAdapter(DaKs.X_Bridg_Pos_Err)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Bridg_Pos_Err)).SetIn(value); OnPropertyChanged("X_Bridg_Pos_Err_Data"); } }
public string Xpri_Bridg_Pos_Err_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Pos_Err)).LongName(); } }
public string Xpri_Bridg_Pos_Err_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Pos_Err)).ShortName(); } }
public string Xpri_Bridg_Pos_Err_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Pos_Err)).MeasUnits(); } }
public string Xpri_Bridg_Pos_Err_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Pos_Err)).ForeGColor(); } }
public string Xpri_Bridg_Pos_Err_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Pos_Err)).BackGColor(); } }
public string Xpri_Bridg_Pos_Err_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Bridg_Pos_Err)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Bridg_Pos_Err)).SetIn(value); OnPropertyChanged("Xpri_Bridg_Pos_Err_Data"); } }
public string Y_Crg_Pos_Err_LongName{ get { return (new DaIAdapter(DaKs.Y_Crg_Pos_Err)).LongName(); } }
public string Y_Crg_Pos_Err_ShortName{ get { return (new DaIAdapter(DaKs.Y_Crg_Pos_Err)).ShortName(); } }
public string Y_Crg_Pos_Err_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Crg_Pos_Err)).MeasUnits(); } }
public string Y_Crg_Pos_Err_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Crg_Pos_Err)).ForeGColor(); } }
public string Y_Crg_Pos_Err_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Crg_Pos_Err)).BackGColor(); } }
public string Y_Crg_Pos_Err_Data{ get { string o; (new DaIAdapter(DaKs.Y_Crg_Pos_Err)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Crg_Pos_Err)).SetIn(value); OnPropertyChanged("Y_Crg_Pos_Err_Data"); } }
public string X_Mtr_I_LongName{ get { return (new DaIAdapter(DaKs.X_Mtr_I)).LongName(); } }
public string X_Mtr_I_ShortName{ get { return (new DaIAdapter(DaKs.X_Mtr_I)).ShortName(); } }
public string X_Mtr_I_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Mtr_I)).MeasUnits(); } }
public string X_Mtr_I_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Mtr_I)).ForeGColor(); } }
public string X_Mtr_I_BackGColor{ get { return (new DaIAdapter(DaKs.X_Mtr_I)).BackGColor(); } }
public string X_Mtr_I_Data{ get { string o; (new DaIAdapter(DaKs.X_Mtr_I)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Mtr_I)).SetIn(value); OnPropertyChanged("X_Mtr_I_Data"); } }
public string Xpri_Mtr_I_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Mtr_I)).LongName(); } }
public string Xpri_Mtr_I_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Mtr_I)).ShortName(); } }
public string Xpri_Mtr_I_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Mtr_I)).MeasUnits(); } }
public string Xpri_Mtr_I_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Mtr_I)).ForeGColor(); } }
public string Xpri_Mtr_I_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Mtr_I)).BackGColor(); } }
public string Xpri_Mtr_I_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Mtr_I)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Mtr_I)).SetIn(value); OnPropertyChanged("Xpri_Mtr_I_Data"); } }
public string Y_Mtr_I_LongName{ get { return (new DaIAdapter(DaKs.Y_Mtr_I)).LongName(); } }
public string Y_Mtr_I_ShortName{ get { return (new DaIAdapter(DaKs.Y_Mtr_I)).ShortName(); } }
public string Y_Mtr_I_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Mtr_I)).MeasUnits(); } }
public string Y_Mtr_I_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Mtr_I)).ForeGColor(); } }
public string Y_Mtr_I_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Mtr_I)).BackGColor(); } }
public string Y_Mtr_I_Data{ get { string o; (new DaIAdapter(DaKs.Y_Mtr_I)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Mtr_I)).SetIn(value); OnPropertyChanged("Y_Mtr_I_Data"); } }
public string X_Mtr_S_LongName{ get { return (new DaIAdapter(DaKs.X_Mtr_S)).LongName(); } }
public string X_Mtr_S_ShortName{ get { return (new DaIAdapter(DaKs.X_Mtr_S)).ShortName(); } }
public string X_Mtr_S_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Mtr_S)).MeasUnits(); } }
public string X_Mtr_S_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Mtr_S)).ForeGColor(); } }
public string X_Mtr_S_BackGColor{ get { return (new DaIAdapter(DaKs.X_Mtr_S)).BackGColor(); } }
public string X_Mtr_S_Data{ get { string o; (new DaIAdapter(DaKs.X_Mtr_S)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Mtr_S)).SetIn(value); OnPropertyChanged("X_Mtr_S_Data"); } }
public string Xpri_Mtr_S_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Mtr_S)).LongName(); } }
public string Xpri_Mtr_S_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Mtr_S)).ShortName(); } }
public string Xpri_Mtr_S_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Mtr_S)).MeasUnits(); } }
public string Xpri_Mtr_S_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Mtr_S)).ForeGColor(); } }
public string Xpri_Mtr_S_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Mtr_S)).BackGColor(); } }
public string Xpri_Mtr_S_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Mtr_S)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Mtr_S)).SetIn(value); OnPropertyChanged("Xpri_Mtr_S_Data"); } }
public string Y_Mtr_S_LongName{ get { return (new DaIAdapter(DaKs.Y_Mtr_S)).LongName(); } }
public string Y_Mtr_S_ShortName{ get { return (new DaIAdapter(DaKs.Y_Mtr_S)).ShortName(); } }
public string Y_Mtr_S_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Mtr_S)).MeasUnits(); } }
public string Y_Mtr_S_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Mtr_S)).ForeGColor(); } }
public string Y_Mtr_S_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Mtr_S)).BackGColor(); } }
public string Y_Mtr_S_Data{ get { string o; (new DaIAdapter(DaKs.Y_Mtr_S)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Mtr_S)).SetIn(value); OnPropertyChanged("Y_Mtr_S_Data"); } }
public string X_Drv_Tmp_LongName{ get { return (new DaIAdapter(DaKs.X_Drv_Tmp)).LongName(); } }
public string X_Drv_Tmp_ShortName{ get { return (new DaIAdapter(DaKs.X_Drv_Tmp)).ShortName(); } }
public string X_Drv_Tmp_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Drv_Tmp)).MeasUnits(); } }
public string X_Drv_Tmp_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Drv_Tmp)).ForeGColor(); } }
public string X_Drv_Tmp_BackGColor{ get { return (new DaIAdapter(DaKs.X_Drv_Tmp)).BackGColor(); } }
public string X_Drv_Tmp_Data{ get { string o; (new DaIAdapter(DaKs.X_Drv_Tmp)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Drv_Tmp)).SetIn(value); OnPropertyChanged("X_Drv_Tmp_Data"); } }
public string Xpri_Drv_Tmp_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Drv_Tmp)).LongName(); } }
public string Xpri_Drv_Tmp_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Drv_Tmp)).ShortName(); } }
public string Xpri_Drv_Tmp_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Drv_Tmp)).MeasUnits(); } }
public string Xpri_Drv_Tmp_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Drv_Tmp)).ForeGColor(); } }
public string Xpri_Drv_Tmp_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Drv_Tmp)).BackGColor(); } }
public string Xpri_Drv_Tmp_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Drv_Tmp)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Drv_Tmp)).SetIn(value); OnPropertyChanged("Xpri_Drv_Tmp_Data"); } }
public string Y_Drv_Tmp_LongName{ get { return (new DaIAdapter(DaKs.Y_Drv_Tmp)).LongName(); } }
public string Y_Drv_Tmp_ShortName{ get { return (new DaIAdapter(DaKs.Y_Drv_Tmp)).ShortName(); } }
public string Y_Drv_Tmp_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Drv_Tmp)).MeasUnits(); } }
public string Y_Drv_Tmp_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Drv_Tmp)).ForeGColor(); } }
public string Y_Drv_Tmp_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Drv_Tmp)).BackGColor(); } }
public string Y_Drv_Tmp_Data{ get { string o; (new DaIAdapter(DaKs.Y_Drv_Tmp)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Drv_Tmp)).SetIn(value); OnPropertyChanged("Y_Drv_Tmp_Data"); } }
public string X_Ref_LongName{ get { return (new DaIAdapter(DaKs.X_Ref)).LongName(); } }
public string X_Ref_ShortName{ get { return (new DaIAdapter(DaKs.X_Ref)).ShortName(); } }
public string X_Ref_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Ref)).MeasUnits(); } }
public string X_Ref_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Ref)).ForeGColor(); } }
public string X_Ref_BackGColor{ get { return (new DaIAdapter(DaKs.X_Ref)).BackGColor(); } }
public string X_Ref_Data{ get { string o; (new DaIAdapter(DaKs.X_Ref)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Ref)).SetIn(value); OnPropertyChanged("X_Ref_Data"); } }
public string Xpri_Ref_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Ref)).LongName(); } }
public string Xpri_Ref_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Ref)).ShortName(); } }
public string Xpri_Ref_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Ref)).MeasUnits(); } }
public string Xpri_Ref_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Ref)).ForeGColor(); } }
public string Xpri_Ref_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Ref)).BackGColor(); } }
public string Xpri_Ref_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Ref)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Ref)).SetIn(value); OnPropertyChanged("Xpri_Ref_Data"); } }
public string Y_Ref_LongName{ get { return (new DaIAdapter(DaKs.Y_Ref)).LongName(); } }
public string Y_Ref_ShortName{ get { return (new DaIAdapter(DaKs.Y_Ref)).ShortName(); } }
public string Y_Ref_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Ref)).MeasUnits(); } }
public string Y_Ref_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Ref)).ForeGColor(); } }
public string Y_Ref_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Ref)).BackGColor(); } }
public string Y_Ref_Data{ get { string o; (new DaIAdapter(DaKs.Y_Ref)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Ref)).SetIn(value); OnPropertyChanged("Y_Ref_Data"); } }
public string X_Bridg_Joy_LongName{ get { return (new DaIAdapter(DaKs.X_Bridg_Joy)).LongName(); } }
public string X_Bridg_Joy_ShortName{ get { return (new DaIAdapter(DaKs.X_Bridg_Joy)).ShortName(); } }
public string X_Bridg_Joy_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Bridg_Joy)).MeasUnits(); } }
public string X_Bridg_Joy_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Bridg_Joy)).ForeGColor(); } }
public string X_Bridg_Joy_BackGColor{ get { return (new DaIAdapter(DaKs.X_Bridg_Joy)).BackGColor(); } }
public string X_Bridg_Joy_Data{ get { string o; (new DaIAdapter(DaKs.X_Bridg_Joy)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Bridg_Joy)).SetIn(value); OnPropertyChanged("X_Bridg_Joy_Data"); } }
public string Xpri_Bridg_Joy_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Joy)).LongName(); } }
public string Xpri_Bridg_Joy_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Joy)).ShortName(); } }
public string Xpri_Bridg_Joy_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Joy)).MeasUnits(); } }
public string Xpri_Bridg_Joy_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Joy)).ForeGColor(); } }
public string Xpri_Bridg_Joy_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Bridg_Joy)).BackGColor(); } }
public string Xpri_Bridg_Joy_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Bridg_Joy)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Bridg_Joy)).SetIn(value); OnPropertyChanged("Xpri_Bridg_Joy_Data"); } }
public string Y_Crg_Joy_LongName{ get { return (new DaIAdapter(DaKs.Y_Crg_Joy)).LongName(); } }
public string Y_Crg_Joy_ShortName{ get { return (new DaIAdapter(DaKs.Y_Crg_Joy)).ShortName(); } }
public string Y_Crg_Joy_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Crg_Joy)).MeasUnits(); } }
public string Y_Crg_Joy_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Crg_Joy)).ForeGColor(); } }
public string Y_Crg_Joy_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Crg_Joy)).BackGColor(); } }
public string Y_Crg_Joy_Data{ get { string o; (new DaIAdapter(DaKs.Y_Crg_Joy)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Crg_Joy)).SetIn(value); OnPropertyChanged("Y_Crg_Joy_Data"); } }
public string X_AxisOn_LongName{ get { return (new DaIAdapter(DaKs.X_AxisOn)).LongName(); } }
public string X_AxisOn_ShortName{ get { return (new DaIAdapter(DaKs.X_AxisOn)).ShortName(); } }
public string X_AxisOn_MeasUnits{ get { return (new DaIAdapter(DaKs.X_AxisOn)).MeasUnits(); } }
public string X_AxisOn_ForeGColor{ get { return (new DaIAdapter(DaKs.X_AxisOn)).ForeGColor(); } }
public string X_AxisOn_BackGColor{ get { return (new DaIAdapter(DaKs.X_AxisOn)).BackGColor(); } }
public string X_AxisOn_Data{ get { string o; (new DaIAdapter(DaKs.X_AxisOn)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_AxisOn)).SetIn(value); OnPropertyChanged("X_AxisOn_Data"); } }
public string Xpri_AxisOn_LongName{ get { return (new DaIAdapter(DaKs.Xpri_AxisOn)).LongName(); } }
public string Xpri_AxisOn_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_AxisOn)).ShortName(); } }
public string Xpri_AxisOn_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_AxisOn)).MeasUnits(); } }
public string Xpri_AxisOn_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_AxisOn)).ForeGColor(); } }
public string Xpri_AxisOn_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_AxisOn)).BackGColor(); } }
public string Xpri_AxisOn_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_AxisOn)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_AxisOn)).SetIn(value); OnPropertyChanged("Xpri_AxisOn_Data"); } }
public string Y_AxisOn_LongName{ get { return (new DaIAdapter(DaKs.Y_AxisOn)).LongName(); } }
public string Y_AxisOn_ShortName{ get { return (new DaIAdapter(DaKs.Y_AxisOn)).ShortName(); } }
public string Y_AxisOn_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_AxisOn)).MeasUnits(); } }
public string Y_AxisOn_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_AxisOn)).ForeGColor(); } }
public string Y_AxisOn_BackGColor{ get { return (new DaIAdapter(DaKs.Y_AxisOn)).BackGColor(); } }
public string Y_AxisOn_Data{ get { string o; (new DaIAdapter(DaKs.Y_AxisOn)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_AxisOn)).SetIn(value); OnPropertyChanged("Y_AxisOn_Data"); } }
public string X_AxisOff_LongName{ get { return (new DaIAdapter(DaKs.X_AxisOff)).LongName(); } }
public string X_AxisOff_ShortName{ get { return (new DaIAdapter(DaKs.X_AxisOff)).ShortName(); } }
public string X_AxisOff_MeasUnits{ get { return (new DaIAdapter(DaKs.X_AxisOff)).MeasUnits(); } }
public string X_AxisOff_ForeGColor{ get { return (new DaIAdapter(DaKs.X_AxisOff)).ForeGColor(); } }
public string X_AxisOff_BackGColor{ get { return (new DaIAdapter(DaKs.X_AxisOff)).BackGColor(); } }
public string X_AxisOff_Data{ get { string o; (new DaIAdapter(DaKs.X_AxisOff)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_AxisOff)).SetIn(value); OnPropertyChanged("X_AxisOff_Data"); } }
public string Xpri_AxisOff_LongName{ get { return (new DaIAdapter(DaKs.Xpri_AxisOff)).LongName(); } }
public string Xpri_AxisOff_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_AxisOff)).ShortName(); } }
public string Xpri_AxisOff_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_AxisOff)).MeasUnits(); } }
public string Xpri_AxisOff_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_AxisOff)).ForeGColor(); } }
public string Xpri_AxisOff_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_AxisOff)).BackGColor(); } }
public string Xpri_AxisOff_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_AxisOff)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_AxisOff)).SetIn(value); OnPropertyChanged("Xpri_AxisOff_Data"); } }
public string Y_AxisOff_LongName{ get { return (new DaIAdapter(DaKs.Y_AxisOff)).LongName(); } }
public string Y_AxisOff_ShortName{ get { return (new DaIAdapter(DaKs.Y_AxisOff)).ShortName(); } }
public string Y_AxisOff_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_AxisOff)).MeasUnits(); } }
public string Y_AxisOff_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_AxisOff)).ForeGColor(); } }
public string Y_AxisOff_BackGColor{ get { return (new DaIAdapter(DaKs.Y_AxisOff)).BackGColor(); } }
public string Y_AxisOff_Data{ get { string o; (new DaIAdapter(DaKs.Y_AxisOff)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_AxisOff)).SetIn(value); OnPropertyChanged("Y_AxisOff_Data"); } }
public string X_Reset_LongName{ get { return (new DaIAdapter(DaKs.X_Reset)).LongName(); } }
public string X_Reset_ShortName{ get { return (new DaIAdapter(DaKs.X_Reset)).ShortName(); } }
public string X_Reset_MeasUnits{ get { return (new DaIAdapter(DaKs.X_Reset)).MeasUnits(); } }
public string X_Reset_ForeGColor{ get { return (new DaIAdapter(DaKs.X_Reset)).ForeGColor(); } }
public string X_Reset_BackGColor{ get { return (new DaIAdapter(DaKs.X_Reset)).BackGColor(); } }
public string X_Reset_Data{ get { string o; (new DaIAdapter(DaKs.X_Reset)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_Reset)).SetIn(value); OnPropertyChanged("X_Reset_Data"); } }
public string Xpri_Reset_LongName{ get { return (new DaIAdapter(DaKs.Xpri_Reset)).LongName(); } }
public string Xpri_Reset_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_Reset)).ShortName(); } }
public string Xpri_Reset_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_Reset)).MeasUnits(); } }
public string Xpri_Reset_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_Reset)).ForeGColor(); } }
public string Xpri_Reset_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_Reset)).BackGColor(); } }
public string Xpri_Reset_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_Reset)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_Reset)).SetIn(value); OnPropertyChanged("Xpri_Reset_Data"); } }
public string Y_Reset_LongName{ get { return (new DaIAdapter(DaKs.Y_Reset)).LongName(); } }
public string Y_Reset_ShortName{ get { return (new DaIAdapter(DaKs.Y_Reset)).ShortName(); } }
public string Y_Reset_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_Reset)).MeasUnits(); } }
public string Y_Reset_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_Reset)).ForeGColor(); } }
public string Y_Reset_BackGColor{ get { return (new DaIAdapter(DaKs.Y_Reset)).BackGColor(); } }
public string Y_Reset_Data{ get { string o; (new DaIAdapter(DaKs.Y_Reset)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_Reset)).SetIn(value); OnPropertyChanged("Y_Reset_Data"); } }
public string X_HomePos_LongName{ get { return (new DaIAdapter(DaKs.X_HomePos)).LongName(); } }
public string X_HomePos_ShortName{ get { return (new DaIAdapter(DaKs.X_HomePos)).ShortName(); } }
public string X_HomePos_MeasUnits{ get { return (new DaIAdapter(DaKs.X_HomePos)).MeasUnits(); } }
public string X_HomePos_ForeGColor{ get { return (new DaIAdapter(DaKs.X_HomePos)).ForeGColor(); } }
public string X_HomePos_BackGColor{ get { return (new DaIAdapter(DaKs.X_HomePos)).BackGColor(); } }
public string X_HomePos_Data{ get { string o; (new DaIAdapter(DaKs.X_HomePos)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_HomePos)).SetIn(value); OnPropertyChanged("X_HomePos_Data"); } }
public string X_CSPD_LongName{ get { return (new DaIAdapter(DaKs.X_CSPD)).LongName(); } }
public string X_CSPD_ShortName{ get { return (new DaIAdapter(DaKs.X_CSPD)).ShortName(); } }
public string X_CSPD_MeasUnits{ get { return (new DaIAdapter(DaKs.X_CSPD)).MeasUnits(); } }
public string X_CSPD_ForeGColor{ get { return (new DaIAdapter(DaKs.X_CSPD)).ForeGColor(); } }
public string X_CSPD_BackGColor{ get { return (new DaIAdapter(DaKs.X_CSPD)).BackGColor(); } }
public string X_CSPD_Data{ get { string o; (new DaIAdapter(DaKs.X_CSPD)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_CSPD)).SetIn(value); OnPropertyChanged("X_CSPD_Data"); } }
public string X_CACC_LongName{ get { return (new DaIAdapter(DaKs.X_CACC)).LongName(); } }
public string X_CACC_ShortName{ get { return (new DaIAdapter(DaKs.X_CACC)).ShortName(); } }
public string X_CACC_MeasUnits{ get { return (new DaIAdapter(DaKs.X_CACC)).MeasUnits(); } }
public string X_CACC_ForeGColor{ get { return (new DaIAdapter(DaKs.X_CACC)).ForeGColor(); } }
public string X_CACC_BackGColor{ get { return (new DaIAdapter(DaKs.X_CACC)).BackGColor(); } }
public string X_CACC_Data{ get { string o; (new DaIAdapter(DaKs.X_CACC)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_CACC)).SetIn(value); OnPropertyChanged("X_CACC_Data"); } }
public string X_CDEC_LongName{ get { return (new DaIAdapter(DaKs.X_CDEC)).LongName(); } }
public string X_CDEC_ShortName{ get { return (new DaIAdapter(DaKs.X_CDEC)).ShortName(); } }
public string X_CDEC_MeasUnits{ get { return (new DaIAdapter(DaKs.X_CDEC)).MeasUnits(); } }
public string X_CDEC_ForeGColor{ get { return (new DaIAdapter(DaKs.X_CDEC)).ForeGColor(); } }
public string X_CDEC_BackGColor{ get { return (new DaIAdapter(DaKs.X_CDEC)).BackGColor(); } }
public string X_CDEC_Data{ get { string o; (new DaIAdapter(DaKs.X_CDEC)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_CDEC)).SetIn(value); OnPropertyChanged("X_CDEC_Data"); } }
public string X_AxisAccel_LongName{ get { return (new DaIAdapter(DaKs.X_AxisAccel)).LongName(); } }
public string X_AxisAccel_ShortName{ get { return (new DaIAdapter(DaKs.X_AxisAccel)).ShortName(); } }
public string X_AxisAccel_MeasUnits{ get { return (new DaIAdapter(DaKs.X_AxisAccel)).MeasUnits(); } }
public string X_AxisAccel_ForeGColor{ get { return (new DaIAdapter(DaKs.X_AxisAccel)).ForeGColor(); } }
public string X_AxisAccel_BackGColor{ get { return (new DaIAdapter(DaKs.X_AxisAccel)).BackGColor(); } }
public string X_AxisAccel_Data{ get { string o; (new DaIAdapter(DaKs.X_AxisAccel)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_AxisAccel)).SetIn(value); OnPropertyChanged("X_AxisAccel_Data"); } }
public string X_CPOS_LongName{ get { return (new DaIAdapter(DaKs.X_CPOS)).LongName(); } }
public string X_CPOS_ShortName{ get { return (new DaIAdapter(DaKs.X_CPOS)).ShortName(); } }
public string X_CPOS_MeasUnits{ get { return (new DaIAdapter(DaKs.X_CPOS)).MeasUnits(); } }
public string X_CPOS_ForeGColor{ get { return (new DaIAdapter(DaKs.X_CPOS)).ForeGColor(); } }
public string X_CPOS_BackGColor{ get { return (new DaIAdapter(DaKs.X_CPOS)).BackGColor(); } }
public string X_CPOS_Data{ get { string o; (new DaIAdapter(DaKs.X_CPOS)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_CPOS)).SetIn(value); OnPropertyChanged("X_CPOS_Data"); } }
public string X_TPOS_LongName{ get { return (new DaIAdapter(DaKs.X_TPOS)).LongName(); } }
public string X_TPOS_ShortName{ get { return (new DaIAdapter(DaKs.X_TPOS)).ShortName(); } }
public string X_TPOS_MeasUnits{ get { return (new DaIAdapter(DaKs.X_TPOS)).MeasUnits(); } }
public string X_TPOS_ForeGColor{ get { return (new DaIAdapter(DaKs.X_TPOS)).ForeGColor(); } }
public string X_TPOS_BackGColor{ get { return (new DaIAdapter(DaKs.X_TPOS)).BackGColor(); } }
public string X_TPOS_Data{ get { string o; (new DaIAdapter(DaKs.X_TPOS)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_TPOS)).SetIn(value); OnPropertyChanged("X_TPOS_Data"); } }
public string X_TSPD_LongName{ get { return (new DaIAdapter(DaKs.X_TSPD)).LongName(); } }
public string X_TSPD_ShortName{ get { return (new DaIAdapter(DaKs.X_TSPD)).ShortName(); } }
public string X_TSPD_MeasUnits{ get { return (new DaIAdapter(DaKs.X_TSPD)).MeasUnits(); } }
public string X_TSPD_ForeGColor{ get { return (new DaIAdapter(DaKs.X_TSPD)).ForeGColor(); } }
public string X_TSPD_BackGColor{ get { return (new DaIAdapter(DaKs.X_TSPD)).BackGColor(); } }
public string X_TSPD_Data{ get { string o; (new DaIAdapter(DaKs.X_TSPD)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_TSPD)).SetIn(value); OnPropertyChanged("X_TSPD_Data"); } }
public string X_TACC_LongName{ get { return (new DaIAdapter(DaKs.X_TACC)).LongName(); } }
public string X_TACC_ShortName{ get { return (new DaIAdapter(DaKs.X_TACC)).ShortName(); } }
public string X_TACC_MeasUnits{ get { return (new DaIAdapter(DaKs.X_TACC)).MeasUnits(); } }
public string X_TACC_ForeGColor{ get { return (new DaIAdapter(DaKs.X_TACC)).ForeGColor(); } }
public string X_TACC_BackGColor{ get { return (new DaIAdapter(DaKs.X_TACC)).BackGColor(); } }
public string X_TACC_Data{ get { string o; (new DaIAdapter(DaKs.X_TACC)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_TACC)).SetIn(value); OnPropertyChanged("X_TACC_Data"); } }
public string X_POSTRIGG1_LongName{ get { return (new DaIAdapter(DaKs.X_POSTRIGG1)).LongName(); } }
public string X_POSTRIGG1_ShortName{ get { return (new DaIAdapter(DaKs.X_POSTRIGG1)).ShortName(); } }
public string X_POSTRIGG1_MeasUnits{ get { return (new DaIAdapter(DaKs.X_POSTRIGG1)).MeasUnits(); } }
public string X_POSTRIGG1_ForeGColor{ get { return (new DaIAdapter(DaKs.X_POSTRIGG1)).ForeGColor(); } }
public string X_POSTRIGG1_BackGColor{ get { return (new DaIAdapter(DaKs.X_POSTRIGG1)).BackGColor(); } }
public string X_POSTRIGG1_Data{ get { string o; (new DaIAdapter(DaKs.X_POSTRIGG1)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_POSTRIGG1)).SetIn(value); OnPropertyChanged("X_POSTRIGG1_Data"); } }
public string Xpri_HomePos_LongName{ get { return (new DaIAdapter(DaKs.Xpri_HomePos)).LongName(); } }
public string Xpri_HomePos_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_HomePos)).ShortName(); } }
public string Xpri_HomePos_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_HomePos)).MeasUnits(); } }
public string Xpri_HomePos_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_HomePos)).ForeGColor(); } }
public string Xpri_HomePos_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_HomePos)).BackGColor(); } }
public string Xpri_HomePos_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_HomePos)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_HomePos)).SetIn(value); OnPropertyChanged("Xpri_HomePos_Data"); } }
public string Xpri_CSPD_LongName{ get { return (new DaIAdapter(DaKs.Xpri_CSPD)).LongName(); } }
public string Xpri_CSPD_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_CSPD)).ShortName(); } }
public string Xpri_CSPD_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_CSPD)).MeasUnits(); } }
public string Xpri_CSPD_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_CSPD)).ForeGColor(); } }
public string Xpri_CSPD_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_CSPD)).BackGColor(); } }
public string Xpri_CSPD_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_CSPD)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_CSPD)).SetIn(value); OnPropertyChanged("Xpri_CSPD_Data"); } }
public string Xpri_CACC_LongName{ get { return (new DaIAdapter(DaKs.Xpri_CACC)).LongName(); } }
public string Xpri_CACC_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_CACC)).ShortName(); } }
public string Xpri_CACC_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_CACC)).MeasUnits(); } }
public string Xpri_CACC_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_CACC)).ForeGColor(); } }
public string Xpri_CACC_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_CACC)).BackGColor(); } }
public string Xpri_CACC_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_CACC)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_CACC)).SetIn(value); OnPropertyChanged("Xpri_CACC_Data"); } }
public string Xpri_CDEC_LongName{ get { return (new DaIAdapter(DaKs.Xpri_CDEC)).LongName(); } }
public string Xpri_CDEC_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_CDEC)).ShortName(); } }
public string Xpri_CDEC_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_CDEC)).MeasUnits(); } }
public string Xpri_CDEC_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_CDEC)).ForeGColor(); } }
public string Xpri_CDEC_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_CDEC)).BackGColor(); } }
public string Xpri_CDEC_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_CDEC)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_CDEC)).SetIn(value); OnPropertyChanged("Xpri_CDEC_Data"); } }
public string Xpri_AxisAccel_LongName{ get { return (new DaIAdapter(DaKs.Xpri_AxisAccel)).LongName(); } }
public string Xpri_AxisAccel_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_AxisAccel)).ShortName(); } }
public string Xpri_AxisAccel_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_AxisAccel)).MeasUnits(); } }
public string Xpri_AxisAccel_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_AxisAccel)).ForeGColor(); } }
public string Xpri_AxisAccel_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_AxisAccel)).BackGColor(); } }
public string Xpri_AxisAccel_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_AxisAccel)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_AxisAccel)).SetIn(value); OnPropertyChanged("Xpri_AxisAccel_Data"); } }
public string Xpri_CPOS_LongName{ get { return (new DaIAdapter(DaKs.Xpri_CPOS)).LongName(); } }
public string Xpri_CPOS_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_CPOS)).ShortName(); } }
public string Xpri_CPOS_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_CPOS)).MeasUnits(); } }
public string Xpri_CPOS_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_CPOS)).ForeGColor(); } }
public string Xpri_CPOS_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_CPOS)).BackGColor(); } }
public string Xpri_CPOS_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_CPOS)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_CPOS)).SetIn(value); OnPropertyChanged("Xpri_CPOS_Data"); } }
public string Xpri_TPOS_LongName{ get { return (new DaIAdapter(DaKs.Xpri_TPOS)).LongName(); } }
public string Xpri_TPOS_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_TPOS)).ShortName(); } }
public string Xpri_TPOS_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_TPOS)).MeasUnits(); } }
public string Xpri_TPOS_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_TPOS)).ForeGColor(); } }
public string Xpri_TPOS_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_TPOS)).BackGColor(); } }
public string Xpri_TPOS_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_TPOS)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_TPOS)).SetIn(value); OnPropertyChanged("Xpri_TPOS_Data"); } }
public string Xpri_TSPD_LongName{ get { return (new DaIAdapter(DaKs.Xpri_TSPD)).LongName(); } }
public string Xpri_TSPD_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_TSPD)).ShortName(); } }
public string Xpri_TSPD_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_TSPD)).MeasUnits(); } }
public string Xpri_TSPD_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_TSPD)).ForeGColor(); } }
public string Xpri_TSPD_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_TSPD)).BackGColor(); } }
public string Xpri_TSPD_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_TSPD)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_TSPD)).SetIn(value); OnPropertyChanged("Xpri_TSPD_Data"); } }
public string Xpri_TACC_LongName{ get { return (new DaIAdapter(DaKs.Xpri_TACC)).LongName(); } }
public string Xpri_TACC_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_TACC)).ShortName(); } }
public string Xpri_TACC_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_TACC)).MeasUnits(); } }
public string Xpri_TACC_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_TACC)).ForeGColor(); } }
public string Xpri_TACC_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_TACC)).BackGColor(); } }
public string Xpri_TACC_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_TACC)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_TACC)).SetIn(value); OnPropertyChanged("Xpri_TACC_Data"); } }
public string Xpri_POSTRIGG1_LongName{ get { return (new DaIAdapter(DaKs.Xpri_POSTRIGG1)).LongName(); } }
public string Xpri_POSTRIGG1_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_POSTRIGG1)).ShortName(); } }
public string Xpri_POSTRIGG1_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_POSTRIGG1)).MeasUnits(); } }
public string Xpri_POSTRIGG1_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_POSTRIGG1)).ForeGColor(); } }
public string Xpri_POSTRIGG1_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_POSTRIGG1)).BackGColor(); } }
public string Xpri_POSTRIGG1_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_POSTRIGG1)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_POSTRIGG1)).SetIn(value); OnPropertyChanged("Xpri_POSTRIGG1_Data"); } }
public string Y_HomePos_LongName{ get { return (new DaIAdapter(DaKs.Y_HomePos)).LongName(); } }
public string Y_HomePos_ShortName{ get { return (new DaIAdapter(DaKs.Y_HomePos)).ShortName(); } }
public string Y_HomePos_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_HomePos)).MeasUnits(); } }
public string Y_HomePos_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_HomePos)).ForeGColor(); } }
public string Y_HomePos_BackGColor{ get { return (new DaIAdapter(DaKs.Y_HomePos)).BackGColor(); } }
public string Y_HomePos_Data{ get { string o; (new DaIAdapter(DaKs.Y_HomePos)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_HomePos)).SetIn(value); OnPropertyChanged("Y_HomePos_Data"); } }
public string Y_CSPD_LongName{ get { return (new DaIAdapter(DaKs.Y_CSPD)).LongName(); } }
public string Y_CSPD_ShortName{ get { return (new DaIAdapter(DaKs.Y_CSPD)).ShortName(); } }
public string Y_CSPD_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_CSPD)).MeasUnits(); } }
public string Y_CSPD_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_CSPD)).ForeGColor(); } }
public string Y_CSPD_BackGColor{ get { return (new DaIAdapter(DaKs.Y_CSPD)).BackGColor(); } }
public string Y_CSPD_Data{ get { string o; (new DaIAdapter(DaKs.Y_CSPD)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_CSPD)).SetIn(value); OnPropertyChanged("Y_CSPD_Data"); } }
public string Y_CACC_LongName{ get { return (new DaIAdapter(DaKs.Y_CACC)).LongName(); } }
public string Y_CACC_ShortName{ get { return (new DaIAdapter(DaKs.Y_CACC)).ShortName(); } }
public string Y_CACC_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_CACC)).MeasUnits(); } }
public string Y_CACC_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_CACC)).ForeGColor(); } }
public string Y_CACC_BackGColor{ get { return (new DaIAdapter(DaKs.Y_CACC)).BackGColor(); } }
public string Y_CACC_Data{ get { string o; (new DaIAdapter(DaKs.Y_CACC)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_CACC)).SetIn(value); OnPropertyChanged("Y_CACC_Data"); } }
public string Y_CDEC_LongName{ get { return (new DaIAdapter(DaKs.Y_CDEC)).LongName(); } }
public string Y_CDEC_ShortName{ get { return (new DaIAdapter(DaKs.Y_CDEC)).ShortName(); } }
public string Y_CDEC_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_CDEC)).MeasUnits(); } }
public string Y_CDEC_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_CDEC)).ForeGColor(); } }
public string Y_CDEC_BackGColor{ get { return (new DaIAdapter(DaKs.Y_CDEC)).BackGColor(); } }
public string Y_CDEC_Data{ get { string o; (new DaIAdapter(DaKs.Y_CDEC)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_CDEC)).SetIn(value); OnPropertyChanged("Y_CDEC_Data"); } }
public string Y_AxisAccel_LongName{ get { return (new DaIAdapter(DaKs.Y_AxisAccel)).LongName(); } }
public string Y_AxisAccel_ShortName{ get { return (new DaIAdapter(DaKs.Y_AxisAccel)).ShortName(); } }
public string Y_AxisAccel_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_AxisAccel)).MeasUnits(); } }
public string Y_AxisAccel_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_AxisAccel)).ForeGColor(); } }
public string Y_AxisAccel_BackGColor{ get { return (new DaIAdapter(DaKs.Y_AxisAccel)).BackGColor(); } }
public string Y_AxisAccel_Data{ get { string o; (new DaIAdapter(DaKs.Y_AxisAccel)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_AxisAccel)).SetIn(value); OnPropertyChanged("Y_AxisAccel_Data"); } }
public string Y_CPOS_LongName{ get { return (new DaIAdapter(DaKs.Y_CPOS)).LongName(); } }
public string Y_CPOS_ShortName{ get { return (new DaIAdapter(DaKs.Y_CPOS)).ShortName(); } }
public string Y_CPOS_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_CPOS)).MeasUnits(); } }
public string Y_CPOS_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_CPOS)).ForeGColor(); } }
public string Y_CPOS_BackGColor{ get { return (new DaIAdapter(DaKs.Y_CPOS)).BackGColor(); } }
public string Y_CPOS_Data{ get { string o; (new DaIAdapter(DaKs.Y_CPOS)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_CPOS)).SetIn(value); OnPropertyChanged("Y_CPOS_Data"); } }
public string Y_TPOS_LongName{ get { return (new DaIAdapter(DaKs.Y_TPOS)).LongName(); } }
public string Y_TPOS_ShortName{ get { return (new DaIAdapter(DaKs.Y_TPOS)).ShortName(); } }
public string Y_TPOS_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_TPOS)).MeasUnits(); } }
public string Y_TPOS_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_TPOS)).ForeGColor(); } }
public string Y_TPOS_BackGColor{ get { return (new DaIAdapter(DaKs.Y_TPOS)).BackGColor(); } }
public string Y_TPOS_Data{ get { string o; (new DaIAdapter(DaKs.Y_TPOS)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_TPOS)).SetIn(value); OnPropertyChanged("Y_TPOS_Data"); } }
public string Y_TSPD_LongName{ get { return (new DaIAdapter(DaKs.Y_TSPD)).LongName(); } }
public string Y_TSPD_ShortName{ get { return (new DaIAdapter(DaKs.Y_TSPD)).ShortName(); } }
public string Y_TSPD_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_TSPD)).MeasUnits(); } }
public string Y_TSPD_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_TSPD)).ForeGColor(); } }
public string Y_TSPD_BackGColor{ get { return (new DaIAdapter(DaKs.Y_TSPD)).BackGColor(); } }
public string Y_TSPD_Data{ get { string o; (new DaIAdapter(DaKs.Y_TSPD)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_TSPD)).SetIn(value); OnPropertyChanged("Y_TSPD_Data"); } }
public string Y_TACC_LongName{ get { return (new DaIAdapter(DaKs.Y_TACC)).LongName(); } }
public string Y_TACC_ShortName{ get { return (new DaIAdapter(DaKs.Y_TACC)).ShortName(); } }
public string Y_TACC_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_TACC)).MeasUnits(); } }
public string Y_TACC_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_TACC)).ForeGColor(); } }
public string Y_TACC_BackGColor{ get { return (new DaIAdapter(DaKs.Y_TACC)).BackGColor(); } }
public string Y_TACC_Data{ get { string o; (new DaIAdapter(DaKs.Y_TACC)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_TACC)).SetIn(value); OnPropertyChanged("Y_TACC_Data"); } }
public string Y_POSTRIGG1_LongName{ get { return (new DaIAdapter(DaKs.Y_POSTRIGG1)).LongName(); } }
public string Y_POSTRIGG1_ShortName{ get { return (new DaIAdapter(DaKs.Y_POSTRIGG1)).ShortName(); } }
public string Y_POSTRIGG1_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_POSTRIGG1)).MeasUnits(); } }
public string Y_POSTRIGG1_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_POSTRIGG1)).ForeGColor(); } }
public string Y_POSTRIGG1_BackGColor{ get { return (new DaIAdapter(DaKs.Y_POSTRIGG1)).BackGColor(); } }
public string Y_POSTRIGG1_Data{ get { string o; (new DaIAdapter(DaKs.Y_POSTRIGG1)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_POSTRIGG1)).SetIn(value); OnPropertyChanged("Y_POSTRIGG1_Data"); } }
public string X_ProgramRev_LongName{ get { return (new DaIAdapter(DaKs.X_ProgramRev)).LongName(); } }
public string X_ProgramRev_ShortName{ get { return (new DaIAdapter(DaKs.X_ProgramRev)).ShortName(); } }
public string X_ProgramRev_MeasUnits{ get { return (new DaIAdapter(DaKs.X_ProgramRev)).MeasUnits(); } }
public string X_ProgramRev_ForeGColor{ get { return (new DaIAdapter(DaKs.X_ProgramRev)).ForeGColor(); } }
public string X_ProgramRev_BackGColor{ get { return (new DaIAdapter(DaKs.X_ProgramRev)).BackGColor(); } }
public string X_ProgramRev_Data{ get { string o; (new DaIAdapter(DaKs.X_ProgramRev)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.X_ProgramRev)).SetIn(value); OnPropertyChanged("X_ProgramRev_Data"); } }
public string Xpri_ProgramRev_LongName{ get { return (new DaIAdapter(DaKs.Xpri_ProgramRev)).LongName(); } }
public string Xpri_ProgramRev_ShortName{ get { return (new DaIAdapter(DaKs.Xpri_ProgramRev)).ShortName(); } }
public string Xpri_ProgramRev_MeasUnits{ get { return (new DaIAdapter(DaKs.Xpri_ProgramRev)).MeasUnits(); } }
public string Xpri_ProgramRev_ForeGColor{ get { return (new DaIAdapter(DaKs.Xpri_ProgramRev)).ForeGColor(); } }
public string Xpri_ProgramRev_BackGColor{ get { return (new DaIAdapter(DaKs.Xpri_ProgramRev)).BackGColor(); } }
public string Xpri_ProgramRev_Data{ get { string o; (new DaIAdapter(DaKs.Xpri_ProgramRev)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Xpri_ProgramRev)).SetIn(value); OnPropertyChanged("Xpri_ProgramRev_Data"); } }
public string Y_ProgramRev_LongName{ get { return (new DaIAdapter(DaKs.Y_ProgramRev)).LongName(); } }
public string Y_ProgramRev_ShortName{ get { return (new DaIAdapter(DaKs.Y_ProgramRev)).ShortName(); } }
public string Y_ProgramRev_MeasUnits{ get { return (new DaIAdapter(DaKs.Y_ProgramRev)).MeasUnits(); } }
public string Y_ProgramRev_ForeGColor{ get { return (new DaIAdapter(DaKs.Y_ProgramRev)).ForeGColor(); } }
public string Y_ProgramRev_BackGColor{ get { return (new DaIAdapter(DaKs.Y_ProgramRev)).BackGColor(); } }
public string Y_ProgramRev_Data{ get { string o; (new DaIAdapter(DaKs.Y_ProgramRev)).GetOut(out o); return o; } set { (new DaIAdapter(DaKs.Y_ProgramRev)).SetIn(value); OnPropertyChanged("Y_ProgramRev_Data"); } }

     }
}

//  end x_TestTools
