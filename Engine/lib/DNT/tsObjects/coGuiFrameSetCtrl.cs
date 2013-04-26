﻿// Copyright (C) 2012 Winterleaf Entertainment L,L,C.
// 
// THE SOFTW ARE IS PROVIDED ON AN “ AS IS” BASIS, WITHOUT W ARRANTY OF ANY KIND,
// INCLUDING WITHOUT LIMIT ATION THE W ARRANTIES OF MERCHANT ABILITY, FITNESS
// FOR A PARTICULAR PURPOSE OR NON-INFRINGEMENT . THE ENTIRE RISK AS TO THE
// QUALITY AND PERFORMANCE OF THE SOFTW ARE IS THE RESPONSIBILITY OF LICENSEE.
// SHOULD THE SOFTW ARE PROVE DEFECTIVE IN ANY RESPECT , LICENSEE AND NOT LICEN -
// SOR OR ITS SUPPLIERS OR RESELLERS ASSUMES THE ENTIRE COST OF AN Y SERVICE AND
// REPAIR. THIS DISCLAIMER OF W ARRANTY CONSTITUTES AN ESSENTIAL PART OF THIS
// AGREEMENT. NO USE OF THE SOFTW ARE IS AUTHORIZED HEREUNDER EXCEPT UNDER
// THIS DISCLAIMER.
// 
// The use of the WinterLeaf Entertainment LLC DotNetT orque (“DNT ”) and DotNetT orque
// Customizer (“DNTC”)is governed by this license agreement (“ Agreement”).
// 
// R E S T R I C T I O N S
// 
// (a) Licensee may not: (i) create any derivative works of DNTC, including but not
// limited to translations, localizations, technology add-ons, or game making software
// other than Games; (ii) reverse engineer , or otherwise attempt to derive the algorithms
// for DNT or DNTC (iii) redistribute, encumber , sell, rent, lease, sublicense, or otherwise
// transfer rights to  DNTC; or (iv) remove or alter any tra demark, logo, copyright
// or other proprietary notices, legends, symbols or labels in DNT or DNTC; or (iiv) use
// the Software to develop or distribute any software that compete s with the Software
// without WinterLeaf Entertainment’s prior written consent; or (i iiv) use the Software for
// any illegal purpose.
// (b) Licensee may not distribute the DNTC in any manner.
// 
// LI C E N S E G R A N T .
// This license allows companies of any size, government entities or individuals to cre -
// ate, sell, rent, lease, or otherwise profit commercially from, games using executables
// created from the source code of DNT
// 
// **********************************************************************************
// **********************************************************************************
// **********************************************************************************
// THE SOURCE CODE GENERATED BY DNTC CAN BE  DISTRIBUTED PUBLICLY PROVIDED THAT THE 
// DISTRIBUTOR PROVIDES  THE GENERATE SOURCE CODE FREE OF CHARGE.
// 
// THIS SOURCE CODE (DNT) CAN BE DISTRIBUTED PUBLICLY PROVIDED THAT THE DISTRIBUTOR 
// PROVIDES  THE SOURCE CODE (DNT) FREE OF CHARGE.
// **********************************************************************************
// **********************************************************************************
// **********************************************************************************
// 
// Please visit http://www.winterleafentertainment.com for more information about the project and latest updates.
// 
// 
// 

#region

using System;
using System.ComponentModel;
using WinterLeaf.Classes;
using WinterLeaf.Containers;
using WinterLeaf.Enums;

#endregion

namespace WinterLeaf.tsObjects
    {
    /// <summary>
    /// 
    /// </summary>
    internal class tsObjectConvertercoGuiFrameSetCtrl : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return (typeof (string) == sourceType);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
            {
            if (value is string)
                {
                return new coGuiFrameSetCtrl(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiFrameSetCtrl))]
    public class coGuiFrameSetCtrl : coGuiContainer
        {
        private ColorI _borderColor;
        private VectorInt _columns;
        private VectorInt _rows;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiFrameSetCtrl(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiFrameSetCtrl(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiFrameSetCtrl(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// If true, row and column offsets are automatically scaled to match the    new extents when the control is resized. 
        /// </summary>
        public bool autoBalance
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".autoBalance").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".autoBalance", value.AsString()); }
            }

        /// <summary>
        /// Color of interior borders between cells. 
        /// </summary>
        public ColorI borderColor
            {
            get
                {
                if (_borderColor != null)
                    _borderColor.DetachAllEvents();
                _borderColor = dnTorque.self.GetVar(_mSimObjectId + ".borderColor").AsColorI();
                _borderColor.OnChangeNotification += _borderColor_OnChangeNotification;
                return _borderColor;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".borderColor", value.AsString()); }
            }

        /// <summary>
        /// Controls whether frame borders are enabled.\n\nFrames use this value    unless overridden for that frame using i%ctrl.frameBorder(index)/i 
        /// </summary>
        public GuiFrameSetCtrl__FrameState borderEnable
            {
            get { return (GuiFrameSetCtrl__FrameState) Enum.Parse(typeof (GuiFrameSetCtrl__FrameState), dnTorque.self.GetVar(_mSimObjectId + ".borderEnable")); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".borderEnable", value.ToString()); }
            }

        /// <summary>
        /// Controls whether borders can be dynamically repositioned with the mouse    by the user.\n\nFrames use this value unless overridden for that frame    using i%ctrl.frameMovable(index)/i 
        /// </summary>
        public GuiFrameSetCtrl__FrameState borderMovable
            {
            get { return (GuiFrameSetCtrl__FrameState) Enum.Parse(typeof (GuiFrameSetCtrl__FrameState), dnTorque.self.GetVar(_mSimObjectId + ".borderMovable")); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".borderMovable", value.ToString()); }
            }

        /// <summary>
        /// Width of interior borders between cells in pixels. 
        /// </summary>
        public int borderWidth
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".borderWidth").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".borderWidth", value.AsString()); }
            }

        /// <summary>
        /// A vector of column offsets (determines the width of each column). 
        /// </summary>
        public VectorInt columns
            {
            get
                {
                if (_columns != null)
                    _columns.DetachAllEvents();
                _columns = dnTorque.self.GetVar(_mSimObjectId + ".columns").AsVectorInt();
                _columns.OnChangeNotification += _columns_OnChangeNotification;
                return _columns;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".columns", value.AsString()); }
            }

        /// <summary>
        /// Offset for row and column dividers in pixels 
        /// </summary>
        public int fudgeFactor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".fudgeFactor").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".fudgeFactor", value.AsString()); }
            }

        /// <summary>
        /// A vector of row offsets (determines the height of each row). 
        /// </summary>
        public VectorInt rows
            {
            get
                {
                if (_rows != null)
                    _rows.DetachAllEvents();
                _rows = dnTorque.self.GetVar(_mSimObjectId + ".rows").AsVectorInt();
                _rows.OnChangeNotification += _rows_OnChangeNotification;
                return _rows;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".rows", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiFrameSetCtrl ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return object.ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            return (this._mSimObjectId == (string) myReflections.ChangeType(obj, typeof (string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(coGuiFrameSetCtrl ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(coGuiFrameSetCtrl ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiFrameSetCtrl(string ts)
            {
            return new coGuiFrameSetCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiFrameSetCtrl ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiFrameSetCtrl(int ts)
            {
            return new coGuiFrameSetCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiFrameSetCtrl ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiFrameSetCtrl(uint ts)
            {
            return new coGuiFrameSetCtrl(ts);
            }

        private void _borderColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".borderColor", e.NewValue);
            }

        private void _columns_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".columns", e.NewValue);
            }

        private void _rows_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".rows", e.NewValue);
            }

        /// <summary>
        /// Add a new column. )
        /// 
        /// </summary>
        public void addColumn()
            {
            TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_addColumn(_mSimObjectId);
            }

        /// <summary>
        /// Add a new row. )
        /// 
        /// </summary>
        public void addRow()
            {
            TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_addRow(_mSimObjectId);
            }

        /// <summary>
        /// dynamic ),
        ///    Override the i>borderEnable/i> setting for this frame.
        ///    @param index  Index of the frame to modify
        ///    @param state  New borderEnable state: \"on\", \"off\" or \"dynamic\" )
        /// 
        /// </summary>
        public void frameBorder(int index, string state)
            {
            TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_frameBorder(_mSimObjectId, index, state);
            }

        /// <summary>
        /// Set the minimum width and height for the frame. It will not be possible 
        ///    for the user to resize the frame smaller than this.
        ///    @param index  Index of the frame to modify
        ///    @param width  Minimum width in pixels
        ///    @param height Minimum height in pixels )
        /// 
        /// </summary>
        public void frameMinExtent(int index, int width, int height)
            {
            TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_frameMinExtent(_mSimObjectId, index, width, height);
            }

        /// <summary>
        /// dynamic ),
        ///    Override the i>borderMovable/i> setting for this frame.
        ///    @param index  Index of the frame to modify
        ///    @param state  New borderEnable state: \"on\", \"off\" or \"dynamic\" )
        /// 
        /// </summary>
        public void frameMovable(int index, string state)
            {
            TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_frameMovable(_mSimObjectId, index, state);
            }

        /// <summary>
        /// Set the padding for this frame. Padding introduces blank space on the inside 
        ///    edge of the frame.
        ///    @param index     Index of the frame to modify
        ///    @param padding   Frame top, bottom, left, and right padding )
        /// 
        /// </summary>
        public void framePadding(int index, RectSpacingI padding)
            {
            TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_framePadding(_mSimObjectId, index, padding.AsString());
            }

        /// <summary>
        /// Get the number of columns.
        ///    @return The number of columns )
        /// 
        /// </summary>
        public int getColumnCount()
            {
            return TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_getColumnCount(_mSimObjectId);
            }

        /// <summary>
        /// Get the horizontal offset of a column.
        ///    @param index Index of the column to query
        ///    @return Column offset in pixels )
        /// 
        /// </summary>
        public int getColumnOffset(int index)
            {
            return TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_getColumnOffset(_mSimObjectId, index);
            }

        /// <summary>
        /// Get the padding for this frame.
        ///    @param index     Index of the frame to query )
        /// 
        /// </summary>
        public RectSpacingI getFramePadding(int index)
            {
            return new RectSpacingI(TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_getFramePadding(_mSimObjectId, index));
            }

        /// <summary>
        /// Get the number of rows.
        ///    @return The number of rows )
        /// 
        /// </summary>
        public int getRowCount()
            {
            return TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_getRowCount(_mSimObjectId);
            }

        /// <summary>
        /// Get the vertical offset of a row.
        ///    @param index Index of the row to query
        ///    @return Row offset in pixels )
        /// 
        /// </summary>
        public int getRowOffset(int index)
            {
            return TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_getRowOffset(_mSimObjectId, index);
            }

        /// <summary>
        /// Remove the last (rightmost) column. )
        /// 
        /// </summary>
        public void removeColumn()
            {
            TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_removeColumn(_mSimObjectId);
            }

        /// <summary>
        /// Remove the last (bottom) row. )
        /// 
        /// </summary>
        public void removeRow()
            {
            TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_removeRow(_mSimObjectId);
            }

        /// <summary>
        /// Set the horizontal offset of a column.
        ///    Note that column offsets must always be in increasing order, and therefore 
        ///    this offset must be between the offsets of the colunns either side.
        ///    @param index  Index of the column to modify
        ///    @param offset New column offset )
        /// 
        /// </summary>
        public void setColumnOffset(int index, int offset)
            {
            TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_setColumnOffset(_mSimObjectId, index, offset);
            }

        /// <summary>
        /// Set the vertical offset of a row.
        ///    Note that row offsets must always be in increasing order, and therefore 
        ///    this offset must be between the offsets of the rows either side.
        ///    @param index  Index of the row to modify
        ///    @param offset New row offset )
        /// 
        /// </summary>
        public void setRowOffset(int index, int offset)
            {
            TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_setRowOffset(_mSimObjectId, index, offset);
            }

        /// <summary>
        /// Recalculates child control sizes. )
        /// 
        /// </summary>
        public void updateSizes()
            {
            TorqueScriptTemplate.m_ts.fnGuiFrameSetCtrl_updateSizes(_mSimObjectId);
            }
        }
    }