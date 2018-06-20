// Your app creates a singleton data model like this one for data items.

using System;
using System.Collections.Generic;
using ECFundies;

namespace ECPutItTogether
{

    /// <summary>
    /// Puts all the data items in one spot, accessable by data key.
    /// Thread-safe singleton.
    /// Ties together two namespaces.
    /// </summary>
    public sealed class DaIDataModel
    {
        private static volatile DaIDataModel _instance;
        private static object _syncRoot = new Object();

        private static Dictionary<uint, DaIBase> _daIStore;

        public void GetDaIStore(ref Dictionary<uint, DaIBase> towhere) { towhere = _daIStore; }

        private DaIDataModel()
        {
            _daIStore = new Dictionary<uint, DaIBase>(256);

            _daIStore.Add(
                DaKs.X_Func.Key,
                new DaIBase(DaKs.X_Func,
                    "X Function",
                    "X Func",
                    new DICvMotionFunc(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Func.Key,
                new DaIBase(DaKs.Xpri_Func,
                    "X' Function",
                    "X' Func",
                    new DICvMotionFunc(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Func.Key,
                new DaIBase(DaKs.Y_Func,
                    "Y Function",
                    "Y Func",
                    new DICvMotionFunc(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_StM.Key,
                new DaIBase(DaKs.X_StM,
                    "X Motion",
                    "X Motion",
                    new DICvStartMotion(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_StM.Key,
                new DaIBase(DaKs.Xpri_StM,
                    "X' Motion",
                    "X' Motion",
                    new DICvStartMotion(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_StM.Key,
                new DaIBase(DaKs.Y_StM,
                    "Y Motion",
                    "Y Motion",
                    new DICvStartMotion(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_Move.Key,
                new DaIBase(DaKs.X_Move,
                    "X Move Dist",
                    "X Move",
                    new DICvSpacingE(),
                    new DICvSpacingM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Move.Key,
                new DaIBase(DaKs.Xpri_Move,
                    "Move Dist (X')",
                    "Move (X')",
                    new DICvSpacingE(),
                    new DICvSpacingM()
                )
            );

            _daIStore.Add(
                DaKs.Y_Move.Key,
                new DaIBase(DaKs.Y_Move,
                    "Y Move Dist",
                    "Y Move",
                    new DICvSpacingE(),
                    new DICvSpacingM()
                )
            );

            _daIStore.Add(
                DaKs.X_Wall_Len.Key,
                new DaIBase(DaKs.X_Wall_Len,
                    "Wall Length",
                    "Wall Len",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Wall_Len.Key,
                new DaIBase(DaKs.Xpri_Wall_Len,
                    "Wall Len (X')",
                    "Wall Len (X')",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Y_Wall_Hgt.Key,
                new DaIBase(DaKs.Y_Wall_Hgt,
                    "Wall Height",
                    "Wall Hgt",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.X_Stitch.Key,
                new DaIBase(DaKs.X_Stitch,
                    "Stitch Space",
                    "Stitch",
                    new DICvSpacingE(),
                    new DICvSpacingM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Stitch.Key,
                new DaIBase(DaKs.Xpri_Stitch,
                    "Stitch (X')",
                    "Stitch (X')",
                    new DICvSpacingE(),
                    new DICvSpacingM()
                )
            );

            _daIStore.Add(
                DaKs.Y_Field.Key,
                new DaIBase(DaKs.Y_Field, 
                    "Field Space",
                    "Field",
                    new DICvSpacingE(),
                    new DICvSpacingM()
                )
            );

            _daIStore.Add(
                DaKs.X_Sys_Cfg.Key,
                new DaIBase(DaKs.X_Sys_Cfg,
                    "X System Config",
                    "X Sys Cfg",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Sys_Cfg.Key,
                new DaIBase(DaKs.Xpri_Sys_Cfg,
                    "X' System Config",
                    "X' Sys Cfg",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Sys_Cfg.Key,
                new DaIBase(DaKs.Y_Sys_Cfg,
                    "Y System Config",
                    "Y Sys Cfg",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_Bridg_Spd.Key,
                new DaIBase(DaKs.X_Bridg_Spd,
                    "Bridge Speed",
                    "Bridg Spd",
                    new DICvMtrSpdE(),
                    new DICvMtrSpdM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Bridg_Spd.Key,
                new DaIBase(DaKs.Xpri_Bridg_Spd,
                    "Speed (X')",
                    "Spd (X')",
                    new DICvMtrSpdE(),
                    new DICvMtrSpdM()
                )
            );

            _daIStore.Add(
                DaKs.Y_Crg_Spd.Key,
                new DaIBase(DaKs.Y_Crg_Spd,
                    "Carriage Speed",
                    "Crg Spd",
                    new DICvMtrSpdE(),
                    new DICvMtrSpdM()
                )
            );

            _daIStore.Add(
                DaKs.X_Sys_St.Key,
                new DaIBase(DaKs.X_Sys_St,
                    "X System State",
                    "X Sys St",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Sys_St.Key,
                new DaIBase(DaKs.Xpri_Sys_St,
                    "X' System State",
                    "X' Sys St",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Sys_St.Key,
                new DaIBase(DaKs.Y_Sys_St,
                    "Y System State",
                    "Y Sys St",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Seams.Key,
                new DaIBase(DaKs.Y_Seams,
                    "Seam Space",
                    "Seams",
                    new DICvSpacingE(),
                    new DICvSpacingM()
                )
            );

            _daIStore.Add(
                DaKs.Y_F1st_Nail.Key,
                new DaIBase(DaKs.Y_F1st_Nail,
                    "1st Nail Loc",
                    "1st Nail",
                    new DICvSpacingE(),
                    new DICvSpacingM()
                )
            );

            _daIStore.Add(
                DaKs.X_SR32.Key,
                new DaIBase(DaKs.X_SR32,
                    "X Stat Reg",
                    "X SR32",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_SR32.Key,
                new DaIBase(DaKs.Xpri_SR32,
                    "X' Stat Reg",
                    "X' SR32",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_SR32.Key,
                new DaIBase(DaKs.Y_SR32,
                    "Y Stat Reg",
                    "Y SR32",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_Dig_In.Key,
                new DaIBase(DaKs.X_Dig_In,
                    "X Dig In",
                    "X Dig In",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Dig_In.Key,
                new DaIBase(DaKs.Xpri_Dig_In,
                    "X' Dig In",
                    "X' Dig In",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Dig_In.Key,
                new DaIBase(DaKs.Y_Dig_In,
                    "Y Dig In",
                    "Y Dig In",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_Dig_Out.Key,
                new DaIBase(DaKs.X_Dig_Out,
                    "X Dig Out",
                    "X Dig Out",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Dig_Out.Key,
                new DaIBase(DaKs.Xpri_Dig_Out,
                    "X' Dig Out",
                    "X' Dig Out",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Dig_Out.Key,
                new DaIBase(DaKs.Y_Dig_Out,
                    "Y Dig Out",
                    "Y Dig Out",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_MER.Key,
                new DaIBase(DaKs.X_MER,
                    "X Motion Err",
                    "X MER",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_MER.Key,
                new DaIBase(DaKs.Xpri_MER,
                    "X' Motion Err",
                    "X' MER",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_MER.Key,
                new DaIBase(DaKs.Y_MER,
                    "Y Motion Err",
                    "Y MER",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_MER_Msk.Key,
                new DaIBase(DaKs.X_MER_Msk,
                    "X MER Msk",
                    "X MER Msk",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_MER_Msk.Key,
                new DaIBase(DaKs.Xpri_MER_Msk,
                    "X' MER Msk",
                    "X' MER Msk",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_MER_Msk.Key,
                new DaIBase(DaKs.Y_MER_Msk,
                    "Y MER Msk",
                    "Y MER Msk",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_Drv_Err.Key,
                new DaIBase(DaKs.X_Drv_Err,
                    "X Drive Error",
                    "X Drv Err",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Drv_Err.Key,
                new DaIBase(DaKs.Xpri_Drv_Err,
                    "X' Drive Error",
                    "X' Drv Err",
                    new DICv16bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Drv_Err.Key,
                new DaIBase(DaKs.Y_Drv_Err,
                    "Y Drive Error",
                    "Y Drv Err",
                    new DICv16bBin(),
                    null                     
                )
            );

            _daIStore.Add(
                DaKs.X_Bridg_Loc.Key,
                new DaIBase(DaKs.X_Bridg_Loc,
                    "Bridge Loc",
                    "Bridg Loc",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Bridg_Loc.Key,
                new DaIBase(DaKs.Xpri_Bridg_Loc,
                    "Loc (X')",
                    "Loc (X')",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Y_Crg_Loc.Key,
                new DaIBase(DaKs.Y_Crg_Loc,
                    "Carriage Loc",
                    "Crg Loc",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.X_Bridg_Pos_Err.Key,
                new DaIBase(DaKs.X_Bridg_Pos_Err,
                    "Bridge Pos Err",
                    "Bridg Pos Err",
                    new DICvSpacingE(),
                    new DICvSpacingM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Bridg_Pos_Err.Key,
                new DaIBase(DaKs.Xpri_Bridg_Pos_Err,
                    "Pos Err (X')",
                    "Pos Err (X')",
                    new DICvSpacingE(),
                    new DICvSpacingM()
                )
            );

            _daIStore.Add(
                DaKs.Y_Crg_Pos_Err.Key,
                new DaIBase(DaKs.Y_Crg_Pos_Err,
                    "Carriage Pos Err",
                    "Crg Pos Err",
                    new DICvSpacingE(),
                    new DICvSpacingM()
                )
            );

            _daIStore.Add(
                DaKs.X_Mtr_I.Key,
                new DaIBase(DaKs.X_Mtr_I,
                    "X Motor Curr",
                    "X Mtr C",
                    new DICvMtrI(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Mtr_I.Key,
                new DaIBase(DaKs.Xpri_Mtr_I,
                    "X' Motor Curr",
                    "X' Mtr C",
                    new DICvMtrI(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Mtr_I.Key,
                new DaIBase(DaKs.Y_Mtr_I,
                    "Y Motor Curr",
                    "Y Mtr C",
                    new DICvMtrI(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_Mtr_S.Key,
                new DaIBase(DaKs.X_Mtr_S,
                    "X Motor Spply",
                    "X Mtr S",
                    new DICvMtrV(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Mtr_S .Key,
                new DaIBase(DaKs.Xpri_Mtr_S, 
                    "X' Motor Spply",
                    "X' Mtr S",
                    new DICvMtrV(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Mtr_S.Key,
                new DaIBase(DaKs.Y_Mtr_S,
                    "Y Motor Spply",
                    "Y Mtr S",
                    new DICvMtrV(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_Drv_Tmp.Key,
                new DaIBase(DaKs.X_Drv_Tmp,
                    "X Drive Temp",
                    "X Drv Tmp",
                    new DICvDrvTE(),
                    new DICvDrvTM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Drv_Tmp.Key,
                new DaIBase(DaKs.Xpri_Drv_Tmp,
                    "X' Drive Temp",
                    "X' Drv Tmp",
                    new DICvDrvTE(),
                    new DICvDrvTM()
                )
            );

            _daIStore.Add(
                DaKs.Y_Drv_Tmp.Key,
                new DaIBase(DaKs.Y_Drv_Tmp,
                    "Y Drive Temp",
                    "Y Drv Tmp",
                    new DICvDrvTE(),
                    new DICvDrvTM()
                )
            );

            _daIStore.Add(
                DaKs.X_Ref.Key,
                new DaIBase(DaKs.X_Ref,
                    "X Ref",
                    "X Ref",
                    new DICvAnalV(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Ref.Key,
                new DaIBase(DaKs.Xpri_Ref,
                    "X' Ref",
                    "X' Ref",
                    new DICvAnalV(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Ref.Key,
                new DaIBase(DaKs.Y_Ref,
                    "Y Ref",
                    "Y Ref",
                    new DICvAnalV(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_Bridg_Joy.Key,
                new DaIBase(DaKs.X_Bridg_Joy,
                    "Bridge Joystick",
                    "Bridg Joy",
                    new DICvAnalV(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Bridg_Joy.Key,
                new DaIBase(DaKs.Xpri_Bridg_Joy,
                    "Joystick (X')",
                    "Joy (X')",
                    new DICvAnalV(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Crg_Joy.Key,
                new DaIBase(DaKs.Y_Crg_Joy,
                    "Carriage Joystick",
                    "Crg Joy",
                    new DICvAnalV(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_AxisOn.Key,
                new DaIBase(DaKs.X_AxisOn,
                    "simp inst",
                    "simp inst",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_AxisOn.Key,
                new DaIBase(DaKs.Xpri_AxisOn,
                    "simp inst",
                    "simp inst",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_AxisOn.Key,
                new DaIBase(DaKs.Y_AxisOn,
                    "simp inst",
                    "simp inst",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_AxisOff.Key,
                new DaIBase(DaKs.X_AxisOff,
                    "simp inst",
                    "simp inst",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_AxisOff.Key,
                new DaIBase(DaKs.Xpri_AxisOff,
                    "simp inst",
                    "simp inst",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_AxisOff.Key,
                new DaIBase(DaKs.Y_AxisOff,
                    "simp inst",
                    "simp inst",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_Reset.Key,
                new DaIBase(DaKs.X_Reset,
                    "simp inst",
                    "simp inst",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_Reset.Key,
                new DaIBase(DaKs.Xpri_Reset,
                    "simp inst",
                    "simp inst",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_Reset.Key,
                new DaIBase(DaKs.Y_Reset,
                    "simp inst",
                    "simp inst",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_HomePos.Key,
                new DaIBase(DaKs.X_HomePos,
                    "X HomePos",
                    "X HoPo",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.X_CSPD.Key,
                new DaIBase(DaKs.X_CSPD,
                    "X CSPD",
                    "X CSPD",
                    new DICvMtrSpdE(),
                    new DICvMtrSpdM()
                )
            );

            _daIStore.Add(
                DaKs.X_CACC.Key,
                new DaIBase(DaKs.X_CACC,
                    "X CACC",
                    "X CACC",
                    new DICvMtrAccE(),
                    new DICvMtrAccM()
                )
            );

            _daIStore.Add(
                DaKs.X_CDEC.Key,
                new DaIBase(DaKs.X_CDEC,
                    "X CDEC",
                    "X CDEC",
                    new DICvMtrAccE(),
                    new DICvMtrAccM()
                )
            );

            _daIStore.Add(
                DaKs.X_AxisAccel.Key,
                new DaIBase(DaKs.X_AxisAccel,
                    "X Axis Acc",
                    "X Axis Acc",
                    new DICvMtrAccE(),
                    new DICvMtrAccM()
                )
            );

            _daIStore.Add(
                DaKs.X_CPOS.Key,
                new DaIBase(DaKs.X_CPOS,
                    "X CPOS",
                    "X CPOS",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.X_TPOS.Key,
                new DaIBase(DaKs.X_TPOS,
                    "X TPOS",
                    "X TPOS",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.X_TSPD.Key,
                new DaIBase(DaKs.X_TSPD,
                    "X TSPD",
                    "X TSPD",
                    new DICvMtrSpdE(),
                    new DICvMtrSpdM()
                )
            );

            _daIStore.Add(
                DaKs.X_TACC.Key,
                new DaIBase(DaKs.X_TACC,
                    "X TACC",
                    "X TACC",
                    new DICv32bBin(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.X_POSTRIGG1.Key,
                new DaIBase(DaKs.X_POSTRIGG1,
                    "X POSTRIGG1",
                    "X PTRG1",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_HomePos.Key,
                new DaIBase(DaKs.Xpri_HomePos,
                    "X' HomePos",
                    "X' HoPo",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_CSPD.Key,
                new DaIBase(DaKs.Xpri_CSPD,
                    "X' CSPD",
                    "X' CSPD",
                    new DICvMtrSpdE(),
                    new DICvMtrSpdM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_CACC.Key,
                new DaIBase(DaKs.Xpri_CACC,
                    "X' CACC",
                    "X' CACC",
                    new DICvMtrAccE(),
                    new DICvMtrAccM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_CDEC.Key,
                new DaIBase(DaKs.Xpri_CDEC,
                    "X' CDEC",
                    "X' CDEC",
                    new DICvMtrAccE(),
                    new DICvMtrAccM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_AxisAccel.Key,
                new DaIBase(DaKs.Xpri_AxisAccel,
                    "X' Axis Acc",
                    "X' Axis Acc",
                    new DICvMtrAccE(),
                    new DICvMtrAccM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_CPOS.Key,
                new DaIBase(DaKs.Xpri_CPOS,
                    "X' CPOS",
                    "X' CPOS",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_TPOS.Key,
                new DaIBase(DaKs.Xpri_TPOS,
                    "X' TPOS",
                    "X' TPOS",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_TSPD.Key,
                new DaIBase(DaKs.Xpri_TSPD,
                    "X' TSPD",
                    "X' TSPD",
                    new DICvMtrSpdE(),
                    new DICvMtrSpdM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_TACC.Key,
                new DaIBase(DaKs.Xpri_TACC,
                    "X' TACC",
                    "X' TACC",
                    new DICvMtrAccE(),
                    new DICvMtrAccM()
                )
            );

            _daIStore.Add(
                DaKs.Xpri_POSTRIGG1.Key,
                new DaIBase(DaKs.Xpri_POSTRIGG1,
                    "X' POSTRIGG1",
                    "X' PTRG1",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Y_HomePos.Key,
                new DaIBase(DaKs.Y_HomePos,
                    "Y HomePos",
                    "Y HoPo",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Y_CSPD.Key,
                new DaIBase(DaKs.Y_CSPD,
                    "Y CSPD",
                    "Y CSPD",
                    new DICvMtrSpdE(),
                    new DICvMtrSpdM()
                )
            );

            _daIStore.Add(
                DaKs.Y_CACC.Key,
                new DaIBase(DaKs.Y_CACC,
                    "Y CACC",
                    "Y CACC",
                    new DICvMtrAccE(),
                    new DICvMtrAccM()
                )
            );

            _daIStore.Add(
                DaKs.Y_CDEC.Key,
                new DaIBase(DaKs.Y_CDEC,
                    "Y CDEC",
                    "Y CDEC",
                    new DICvMtrAccE(),
                    new DICvMtrAccM()
                )
            );

            _daIStore.Add(
                DaKs.Y_AxisAccel.Key,
                new DaIBase(DaKs.Y_AxisAccel,
                    "Y Axis Acc",
                    "Y Axis Acc",
                    new DICvMtrAccE(),
                    new DICvMtrAccM()
                )
            );

            _daIStore.Add(
                DaKs.Y_CPOS.Key,
                new DaIBase(DaKs.Y_CPOS,
                    "Y CPOS",
                    "Y CPOS",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Y_TPOS.Key,
                new DaIBase(DaKs.Y_TPOS,
                    "Y TPOS",
                    "Y TPOS",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.Y_TSPD.Key,
                new DaIBase(DaKs.Y_TSPD,
                    "Y TSPD",
                    "Y TSPD",
                    new DICvMtrSpdE(),
                    new DICvMtrSpdM()
                )
            );

            _daIStore.Add(
                DaKs.Y_TACC.Key,
                new DaIBase(DaKs.Y_TACC,
                    "Y TACC",
                    "Y TACC",
                    new DICvMtrAccE(),
                    new DICvMtrAccM()
                )
            );

            _daIStore.Add(
                DaKs.Y_POSTRIGG1.Key,
                new DaIBase(DaKs.Y_POSTRIGG1,
                    "Y POSTRIGG1",
                    "Y PTRG1",
                    new DICvWallDimE(),
                    new DICvWallDimM()
                )
            );

            _daIStore.Add(
                DaKs.X_ProgramRev.Key,
                new DaIBase(DaKs.X_ProgramRev,
                    "X Prog Rev",
                    "X Rev",
                    new DICv32bRaw(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Xpri_ProgramRev.Key,
                new DaIBase(DaKs.Xpri_ProgramRev,
                    "X pri Prog Rev",
                    "X' Rev",
                    new DICv32bRaw(),
                    null
                )
            );

            _daIStore.Add(
                DaKs.Y_ProgramRev.Key,
                new DaIBase(DaKs.Y_ProgramRev,
                    "Y Prog Rev",
                    "Y Rev",
                    new DICv32bRaw(),
                    null
                )
            );


        }

        public static DaIDataModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new DaIDataModel();
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
        public void HandleOn(uint kval, out DaIBase daii)
        {
            _daIStore.TryGetValue(kval, out daii);
        }

    }

}

