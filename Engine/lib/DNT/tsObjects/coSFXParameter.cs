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
    internal class tsObjectConvertercoSFXParameter : TypeConverter
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
                return new coSFXParameter(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoSFXParameter))]
    public class coSFXParameter : coSimObject
        {
        private Point2F _range;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coSFXParameter(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coSFXParameter(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coSFXParameter(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// Channel that the parameter controls.\n     This controls which property of the sources it is attached to the parameter controls. 
        /// </summary>
        public SFXChannel channel
            {
            get { return (SFXChannel) Enum.Parse(typeof (SFXChannel), dnTorque.self.GetVar(_mSimObjectId + ".channel")); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".channel", value.ToString()); }
            }

        /// <summary>
        /// Value to which the parameter is initially set.\n     When the parameter is first added to the system, #value will be set to #defaultValue. 
        /// </summary>
        public float defaultValue
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".defaultValue").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".defaultValue", value.AsString()); }
            }

        /// <summary>
        /// Textual description of the parameter.\n     Primarily for use in the Audio Parameters dialog of the editor to allow for easier identification      of parameters. 
        /// </summary>
        public String description
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".description").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".description", value.AsString()); }
            }

        /// <summary>
        /// Permitted range for #value.\n     Minimum and maximum allowed value for the parameter. Both inclusive.\n\n     For all but the User0-3 channels, this property is automatically set up by SFXParameter. 
        /// </summary>
        public Point2F range
            {
            get
                {
                if (_range != null)
                    _range.DetachAllEvents();
                _range = dnTorque.self.GetVar(_mSimObjectId + ".range").AsPoint2F();
                _range.OnChangeNotification += _range_OnChangeNotification;
                return _range;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".range", value.AsString()); }
            }

        /// <summary>
        /// Current value of the audio parameter.\n     All attached sources are notified when this value changes. 
        /// </summary>
        public float value
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".value").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".value", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coSFXParameter ts, string simobjectid)
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
        public static bool operator !=(coSFXParameter ts, string simobjectid)
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
        public static implicit operator string(coSFXParameter ts)
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
        public static implicit operator coSFXParameter(string ts)
            {
            return new coSFXParameter(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coSFXParameter ts)
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
        public static implicit operator coSFXParameter(int ts)
            {
            return new coSFXParameter(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coSFXParameter ts)
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
        public static implicit operator coSFXParameter(uint ts)
            {
            return new coSFXParameter(ts);
            }

        private void _range_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".range", e.NewValue);
            }

        /// <summary>
        /// Get the name of the parameter.
        ///    @return The paramete name. )
        /// 
        /// </summary>
        public string getParameterName()
            {
            return TorqueScriptTemplate.m_ts.fnSFXParameter_getParameterName(_mSimObjectId);
            }

        /// <summary>
        /// Reset the parameter's value to its default.
        ///    @see SFXParameter::defaultValue )
        /// 
        /// </summary>
        public void reset()
            {
            TorqueScriptTemplate.m_ts.fnSFXParameter_reset(_mSimObjectId);
            }
        }
    }