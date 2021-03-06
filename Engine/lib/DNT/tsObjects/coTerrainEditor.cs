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

#endregion

namespace WinterLeaf.tsObjects
    {
    /// <summary>
    /// 
    /// </summary>
    internal class tsObjectConvertercoTerrainEditor : TypeConverter
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
                return new coTerrainEditor(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoTerrainEditor))]
    public class coTerrainEditor : coEditTSCtrl
        {
        private ColorI _borderFillColor;
        private ColorI _borderFrameColor;
        private Point2I _maxBrushSize;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coTerrainEditor(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coTerrainEditor(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coTerrainEditor(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// 
        /// </summary>
        public float adjustHeightMouseScale
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".adjustHeightMouseScale").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".adjustHeightMouseScale", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public float adjustHeightVal
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".adjustHeightVal").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".adjustHeightVal", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public ColorI borderFillColor
            {
            get
                {
                if (_borderFillColor != null)
                    _borderFillColor.DetachAllEvents();
                _borderFillColor = dnTorque.self.GetVar(_mSimObjectId + ".borderFillColor").AsColorI();
                _borderFillColor.OnChangeNotification += _borderFillColor_OnChangeNotification;
                return _borderFillColor;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".borderFillColor", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public ColorI borderFrameColor
            {
            get
                {
                if (_borderFrameColor != null)
                    _borderFrameColor.DetachAllEvents();
                _borderFrameColor = dnTorque.self.GetVar(_mSimObjectId + ".borderFrameColor").AsColorI();
                _borderFrameColor.OnChangeNotification += _borderFrameColor_OnChangeNotification;
                return _borderFrameColor;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".borderFrameColor", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public float borderHeight
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".borderHeight").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".borderHeight", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public bool borderLineMode
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".borderLineMode").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".borderLineMode", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public bool isDirty
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".isDirty").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".isDirty", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public bool isMissionDirty
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".isMissionDirty").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".isMissionDirty", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public int materialGroup
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".materialGroup").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".materialGroup", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public Point2I maxBrushSize
            {
            get
                {
                if (_maxBrushSize != null)
                    _maxBrushSize.DetachAllEvents();
                _maxBrushSize = dnTorque.self.GetVar(_mSimObjectId + ".maxBrushSize").AsPoint2I();
                _maxBrushSize.OnChangeNotification += _maxBrushSize_OnChangeNotification;
                return _maxBrushSize;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxBrushSize", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public float noiseFactor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".noiseFactor").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".noiseFactor", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public int paintIndex
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".paintIndex").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".paintIndex", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public bool processUsesBrush
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".processUsesBrush").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".processUsesBrush", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public bool renderBorder
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".renderBorder").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".renderBorder", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public bool renderSolidBrush
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".renderSolidBrush").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".renderSolidBrush", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public bool renderVertexSelection
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".renderVertexSelection").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".renderVertexSelection", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public float scaleVal
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".scaleVal").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".scaleVal", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public bool selectionHidden
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".selectionHidden").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".selectionHidden", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public float setHeightVal
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".setHeightVal").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".setHeightVal", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public float smoothFactor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".smoothFactor").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".smoothFactor", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public String softSelectDefaultFilter
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".softSelectDefaultFilter").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".softSelectDefaultFilter", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public String softSelectFilter
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".softSelectFilter").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".softSelectFilter", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public float softSelectRadius
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".softSelectRadius").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".softSelectRadius", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coTerrainEditor ts, string simobjectid)
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
        public static bool operator !=(coTerrainEditor ts, string simobjectid)
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
        public static implicit operator string(coTerrainEditor ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coTerrainEditor(string ts)
            {
            return new coTerrainEditor(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coTerrainEditor ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coTerrainEditor(int ts)
            {
            return new coTerrainEditor(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coTerrainEditor ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coTerrainEditor(uint ts)
            {
            return new coTerrainEditor(ts);
            }

        private void _borderFillColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".borderFillColor", e.NewValue);
            }

        private void _borderFrameColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".borderFrameColor", e.NewValue);
            }

        private void _maxBrushSize_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".maxBrushSize", e.NewValue);
            }
        }
    }