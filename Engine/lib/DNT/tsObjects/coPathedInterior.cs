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
    internal class tsObjectConvertercoPathedInterior : TypeConverter
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
                return new coPathedInterior(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoPathedInterior))]
    public class coPathedInterior : coGameBase
        {
        private TransformF _basePosition;
        private TransformF _baseRotation;
        private Point3F _baseScale;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coPathedInterior(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coPathedInterior(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coPathedInterior(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        public TransformF basePosition
            {
            get
                {
                if (_basePosition != null)
                    _basePosition.DetachAllEvents();
                _basePosition = dnTorque.self.GetVar(_mSimObjectId + ".basePosition").AsTransformF();
                _basePosition.OnChangeNotification += _basePosition_OnChangeNotification;
                return _basePosition;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".basePosition", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public TransformF baseRotation
            {
            get
                {
                if (_baseRotation != null)
                    _baseRotation.DetachAllEvents();
                _baseRotation = dnTorque.self.GetVar(_mSimObjectId + ".baseRotation").AsTransformF();
                _baseRotation.OnChangeNotification += _baseRotation_OnChangeNotification;
                return _baseRotation;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".baseRotation", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public Point3F baseScale
            {
            get
                {
                if (_baseScale != null)
                    _baseScale.DetachAllEvents();
                _baseScale = dnTorque.self.GetVar(_mSimObjectId + ".baseScale").AsPoint3F();
                _baseScale.OnChangeNotification += _baseScale_OnChangeNotification;
                return _baseScale;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".baseScale", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public int interiorIndex
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".interiorIndex").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".interiorIndex", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public String interiorResource
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".interiorResource").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".interiorResource", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coPathedInterior ts, string simobjectid)
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
        public static bool operator !=(coPathedInterior ts, string simobjectid)
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
        public static implicit operator string(coPathedInterior ts)
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
        public static implicit operator coPathedInterior(string ts)
            {
            return new coPathedInterior(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coPathedInterior ts)
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
        public static implicit operator coPathedInterior(int ts)
            {
            return new coPathedInterior(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coPathedInterior ts)
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
        public static implicit operator coPathedInterior(uint ts)
            {
            return new coPathedInterior(ts);
            }

        private void _basePosition_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".basePosition", e.NewValue);
            }

        private void _baseRotation_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".baseRotation", e.NewValue);
            }

        private void _baseScale_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".baseScale", e.NewValue);
            }

        /// <summary>
        /// (PathedInterior, setPathPosition, void, 3, 3, )
        /// 
        /// </summary>
        public void setPathPosition(string a2)
            {
            TorqueScriptTemplate.m_ts.fnPathedInterior_setPathPosition(_mSimObjectId, a2);
            }

        /// <summary>
        /// (PathedInterior, setTargetPosition, void, 3, 3, )
        /// 
        /// </summary>
        public void setTargetPosition(string a2)
            {
            TorqueScriptTemplate.m_ts.fnPathedInterior_setTargetPosition(_mSimObjectId, a2);
            }
        }
    }