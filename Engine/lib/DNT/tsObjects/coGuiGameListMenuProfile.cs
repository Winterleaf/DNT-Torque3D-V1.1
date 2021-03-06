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
    internal class tsObjectConvertercoGuiGameListMenuProfile : TypeConverter
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
                return new coGuiGameListMenuProfile(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiGameListMenuProfile))]
    public class coGuiGameListMenuProfile : coGuiControlProfile
        {
        private Point2I _hitAreaLowerRight;
        private Point2I _hitAreaUpperLeft;
        private Point2I _iconOffset;
        private Point2I _rowSize;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiGameListMenuProfile(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiGameListMenuProfile(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiGameListMenuProfile(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// Position of the lower right corner of the row hit area (relative to row's top left corner) 
        /// </summary>
        public Point2I hitAreaLowerRight
            {
            get
                {
                if (_hitAreaLowerRight != null)
                    _hitAreaLowerRight.DetachAllEvents();
                _hitAreaLowerRight = dnTorque.self.GetVar(_mSimObjectId + ".hitAreaLowerRight").AsPoint2I();
                _hitAreaLowerRight.OnChangeNotification += _hitAreaLowerRight_OnChangeNotification;
                return _hitAreaLowerRight;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".hitAreaLowerRight", value.AsString()); }
            }

        /// <summary>
        /// Position of the upper left corner of the row hit area (relative to row's top left corner) 
        /// </summary>
        public Point2I hitAreaUpperLeft
            {
            get
                {
                if (_hitAreaUpperLeft != null)
                    _hitAreaUpperLeft.DetachAllEvents();
                _hitAreaUpperLeft = dnTorque.self.GetVar(_mSimObjectId + ".hitAreaUpperLeft").AsPoint2I();
                _hitAreaUpperLeft.OnChangeNotification += _hitAreaUpperLeft_OnChangeNotification;
                return _hitAreaUpperLeft;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".hitAreaUpperLeft", value.AsString()); }
            }

        /// <summary>
        /// Offset from the row's top left corner at which to render the row icon 
        /// </summary>
        public Point2I iconOffset
            {
            get
                {
                if (_iconOffset != null)
                    _iconOffset.DetachAllEvents();
                _iconOffset = dnTorque.self.GetVar(_mSimObjectId + ".iconOffset").AsPoint2I();
                _iconOffset.OnChangeNotification += _iconOffset_OnChangeNotification;
                return _iconOffset;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".iconOffset", value.AsString()); }
            }

        /// <summary>
        /// The base size (\width height\) of a row 
        /// </summary>
        public Point2I rowSize
            {
            get
                {
                if (_rowSize != null)
                    _rowSize.DetachAllEvents();
                _rowSize = dnTorque.self.GetVar(_mSimObjectId + ".rowSize").AsPoint2I();
                _rowSize.OnChangeNotification += _rowSize_OnChangeNotification;
                return _rowSize;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".rowSize", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiGameListMenuProfile ts, string simobjectid)
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
        public static bool operator !=(coGuiGameListMenuProfile ts, string simobjectid)
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
        public static implicit operator string(coGuiGameListMenuProfile ts)
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
        public static implicit operator coGuiGameListMenuProfile(string ts)
            {
            return new coGuiGameListMenuProfile(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiGameListMenuProfile ts)
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
        public static implicit operator coGuiGameListMenuProfile(int ts)
            {
            return new coGuiGameListMenuProfile(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiGameListMenuProfile ts)
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
        public static implicit operator coGuiGameListMenuProfile(uint ts)
            {
            return new coGuiGameListMenuProfile(ts);
            }

        private void _hitAreaLowerRight_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".hitAreaLowerRight", e.NewValue);
            }

        private void _hitAreaUpperLeft_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".hitAreaUpperLeft", e.NewValue);
            }

        private void _iconOffset_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".iconOffset", e.NewValue);
            }

        private void _rowSize_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".rowSize", e.NewValue);
            }
        }
    }