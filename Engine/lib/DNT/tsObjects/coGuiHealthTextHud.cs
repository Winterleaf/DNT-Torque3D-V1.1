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
    internal class tsObjectConvertercoGuiHealthTextHud : TypeConverter
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
                return new coGuiHealthTextHud(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiHealthTextHud))]
    public class coGuiHealthTextHud : coGuiControl
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiHealthTextHud(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiHealthTextHud(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiHealthTextHud(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// Color for the background of the control.
        /// </summary>
        public ColorF fillColor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".fillColor").AsColorF(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".fillColor", value.AsString()); }
            }

        /// <summary>
        /// Color for the control's frame.
        /// </summary>
        public ColorF frameColor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".frameColor").AsColorF(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".frameColor", value.AsString()); }
            }

        /// <summary>
        /// Speed at which the control will pulse.
        /// </summary>
        public int pulseRate
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".pulseRate").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".pulseRate", value.AsString()); }
            }

        /// <summary>
        /// Health level at which to begin pulsing.
        /// </summary>
        public float pulseThreshold
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".pulseThreshold").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".pulseThreshold", value.AsString()); }
            }

        /// <summary>
        /// If true, display the energy value rather than the damage value.
        /// </summary>
        public bool showEnergy
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".showEnergy").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".showEnergy", value.AsString()); }
            }

        /// <summary>
        /// If true, draw the background.
        /// </summary>
        public bool showFill
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".showFill").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".showFill", value.AsString()); }
            }

        /// <summary>
        /// If true, draw the frame.
        /// </summary>
        public bool showFrame
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".showFrame").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".showFrame", value.AsString()); }
            }

        /// <summary>
        /// If true, we don't hardcode maxHealth to 100.
        /// </summary>
        public bool showTrueValue
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".showTrueValue").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".showTrueValue", value.AsString()); }
            }

        /// <summary>
        /// Color for the text on this control.
        /// </summary>
        public ColorF textColor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".textColor").AsColorF(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".textColor", value.AsString()); }
            }

        /// <summary>
        /// Color for the text when health is low.
        /// </summary>
        public ColorF warningColor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".warningColor").AsColorF(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".warningColor", value.AsString()); }
            }

        /// <summary>
        /// The health level at which to use the warningColor.
        /// </summary>
        public float warnThreshold
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".warnThreshold").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".warnThreshold", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiHealthTextHud ts, string simobjectid)
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
        public static bool operator !=(coGuiHealthTextHud ts, string simobjectid)
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
        public static implicit operator string(coGuiHealthTextHud ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiHealthTextHud(string ts)
            {
            return new coGuiHealthTextHud(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiHealthTextHud ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiHealthTextHud(int ts)
            {
            return new coGuiHealthTextHud(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiHealthTextHud ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiHealthTextHud(uint ts)
            {
            return new coGuiHealthTextHud(ts);
            }
        }
    }