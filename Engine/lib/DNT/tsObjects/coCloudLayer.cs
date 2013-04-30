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
    internal class tsObjectConvertercoCloudLayer : TypeConverter
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
                return new coCloudLayer(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoCloudLayer))]
    public class coCloudLayer : coSceneObject
        {
        private ColorF _baseColor;
        private Point2F _texDirection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coCloudLayer(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coCloudLayer(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coCloudLayer(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// Base cloud color before lighting. 
        /// </summary>
        public ColorF baseColor
            {
            get
                {
                if (_baseColor != null)
                    _baseColor.DetachAllEvents();
                _baseColor = dnTorque.self.GetVar(_mSimObjectId + ".baseColor").AsColorF();
                _baseColor.OnChangeNotification += _baseColor_OnChangeNotification;
                return _baseColor;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".baseColor", value.AsString()); }
            }

        /// <summary>
        /// Fraction of sky covered by clouds 0-1. 
        /// </summary>
        public float coverage
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".coverage").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".coverage", value.AsString()); }
            }

        /// <summary>
        /// Brightness scale so CloudLayer can be overblown if desired. 
        /// </summary>
        public float exposure
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".exposure").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".exposure", value.AsString()); }
            }

        /// <summary>
        /// Abstract number which controls the curvature and height of the dome mesh. 
        /// </summary>
        public float height
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".height").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".height", value.AsString()); }
            }

        /// <summary>
        /// Controls the direction this slot scrolls. 
        /// </summary>
        public Point2F texDirection
            {
            get
                {
                if (_texDirection != null)
                    _texDirection.DetachAllEvents();
                _texDirection = dnTorque.self.GetVar(_mSimObjectId + ".texDirection").AsPoint2F();
                _texDirection.OnChangeNotification += _texDirection_OnChangeNotification;
                return _texDirection;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".texDirection", value.AsString()); }
            }

        /// <summary>
        /// Controls the texture repeat of this slot. 
        /// </summary>
        public float texScale
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".texScale").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".texScale", value.AsString()); }
            }

        /// <summary>
        /// Controls the speed this slot scrolls. 
        /// </summary>
        public float texSpeed
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".texSpeed").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".texSpeed", value.AsString()); }
            }

        /// <summary>
        /// An RGBA texture which should contain normals and opacity (density). 
        /// </summary>
        public String texture
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".texture").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".texture", value.AsString()); }
            }

        /// <summary>
        /// Overall scalar to texture scroll speed. 
        /// </summary>
        public float windSpeed
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".windSpeed").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".windSpeed", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coCloudLayer ts, string simobjectid)
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
        public static bool operator !=(coCloudLayer ts, string simobjectid)
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
        public static implicit operator string(coCloudLayer ts)
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
        public static implicit operator coCloudLayer(string ts)
            {
            return new coCloudLayer(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coCloudLayer ts)
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
        public static implicit operator coCloudLayer(int ts)
            {
            return new coCloudLayer(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coCloudLayer ts)
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
        public static implicit operator coCloudLayer(uint ts)
            {
            return new coCloudLayer(ts);
            }

        private void _baseColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".baseColor", e.NewValue);
            }

        private void _texDirection_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".texDirection", e.NewValue);
            }
        }
    }