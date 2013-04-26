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
    internal class tsObjectConvertercoGuiSpeedometerHud : TypeConverter
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
                return new coGuiSpeedometerHud(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiSpeedometerHud))]
    public class coGuiSpeedometerHud : coGuiBitmapCtrl
        {
        private Point2F _center;
        private ColorF _color;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiSpeedometerHud(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiSpeedometerHud(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiSpeedometerHud(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// Center of the needle, offset from the GuiSpeedometerHud control top    left corner 
        /// </summary>
        public Point2F center
            {
            get
                {
                if (_center != null)
                    _center.DetachAllEvents();
                _center = dnTorque.self.GetVar(_mSimObjectId + ".center").AsPoint2F();
                _center.OnChangeNotification += _center_OnChangeNotification;
                return _center;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".center", value.AsString()); }
            }

        /// <summary>
        /// Color of the needle 
        /// </summary>
        public ColorF color
            {
            get
                {
                if (_color != null)
                    _color.DetachAllEvents();
                _color = dnTorque.self.GetVar(_mSimObjectId + ".color").AsColorF();
                _color.OnChangeNotification += _color_OnChangeNotification;
                return _color;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".color", value.AsString()); }
            }

        /// <summary>
        /// Length of the needle from center to end 
        /// </summary>
        public float length
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".length").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".length", value.AsString()); }
            }

        /// <summary>
        /// Angle (in radians) of the needle when the Vehicle speed is = maxSpeed.    An angle of 0 points right, 90 points up etc). 
        /// </summary>
        public float maxAngle
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".maxAngle").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxAngle", value.AsString()); }
            }

        /// <summary>
        /// Maximum Vehicle speed (in Torque units per second) to represent on the    speedo (Vehicle speeds greater than this are clamped to maxSpeed). 
        /// </summary>
        public float maxSpeed
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".maxSpeed").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxSpeed", value.AsString()); }
            }

        /// <summary>
        /// Angle (in radians) of the needle when the Vehicle speed is 0. An angle    of 0 points right, 90 points up etc). 
        /// </summary>
        public float minAngle
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".minAngle").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".minAngle", value.AsString()); }
            }

        /// <summary>
        /// Length of the needle from center to tail 
        /// </summary>
        public float tail
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".tail").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".tail", value.AsString()); }
            }

        /// <summary>
        /// Width of the needle 
        /// </summary>
        public float width
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".width").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".width", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiSpeedometerHud ts, string simobjectid)
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
        public static bool operator !=(coGuiSpeedometerHud ts, string simobjectid)
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
        public static implicit operator string(coGuiSpeedometerHud ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiSpeedometerHud(string ts)
            {
            return new coGuiSpeedometerHud(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiSpeedometerHud ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiSpeedometerHud(int ts)
            {
            return new coGuiSpeedometerHud(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiSpeedometerHud ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiSpeedometerHud(uint ts)
            {
            return new coGuiSpeedometerHud(ts);
            }

        private void _center_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".center", e.NewValue);
            }

        private void _color_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".color", e.NewValue);
            }
        }
    }