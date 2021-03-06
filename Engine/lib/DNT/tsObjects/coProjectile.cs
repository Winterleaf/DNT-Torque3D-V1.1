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
    internal class tsObjectConvertercoProjectile : TypeConverter
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
                return new coProjectile(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoProjectile))]
    public class coProjectile : coGameBase
        {
        private Point3F _initialPosition;
        private Point3F _initialVelocity;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coProjectile(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coProjectile(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coProjectile(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// @brief Starting position for the projectile.\n\n
        /// </summary>
        public Point3F initialPosition
            {
            get
                {
                if (_initialPosition != null)
                    _initialPosition.DetachAllEvents();
                _initialPosition = dnTorque.self.GetVar(_mSimObjectId + ".initialPosition").AsPoint3F();
                _initialPosition.OnChangeNotification += _initialPosition_OnChangeNotification;
                return _initialPosition;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".initialPosition", value.AsString()); }
            }

        /// <summary>
        /// @brief Starting velocity for the projectile.\n\n
        /// </summary>
        public Point3F initialVelocity
            {
            get
                {
                if (_initialVelocity != null)
                    _initialVelocity.DetachAllEvents();
                _initialVelocity = dnTorque.self.GetVar(_mSimObjectId + ".initialVelocity").AsPoint3F();
                _initialVelocity.OnChangeNotification += _initialVelocity_OnChangeNotification;
                return _initialVelocity;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".initialVelocity", value.AsString()); }
            }

        /// <summary>
        /// @brief ID number of the object that fired the projectile.\n\n   @note If the projectile was fired by a WeaponImage, sourceObject will be    the object that owns the WeaponImage. This is usually the player.
        /// </summary>
        public int sourceObject
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".sourceObject").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".sourceObject", value.AsString()); }
            }

        /// <summary>
        /// @brief The sourceObject's weapon slot that the projectile originates from.\n\n
        /// </summary>
        public int sourceSlot
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".sourceSlot").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".sourceSlot", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coProjectile ts, string simobjectid)
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
        public static bool operator !=(coProjectile ts, string simobjectid)
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
        public static implicit operator string(coProjectile ts)
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
        public static implicit operator coProjectile(string ts)
            {
            return new coProjectile(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coProjectile ts)
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
        public static implicit operator coProjectile(int ts)
            {
            return new coProjectile(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coProjectile ts)
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
        public static implicit operator coProjectile(uint ts)
            {
            return new coProjectile(ts);
            }

        private void _initialPosition_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".initialPosition", e.NewValue);
            }

        private void _initialVelocity_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".initialVelocity", e.NewValue);
            }

        /// <summary>
        /// @brief Updates the projectile's positional and collision information.
        ///                                        This function will first delete the projectile if it is a server object and is outside it's ProjectileData::lifetime. 
        ///                                        Also responsible for applying gravity, determining collisions, triggering explosions, 
        ///                                        emitting trail particles, and calculating bounces if necessary.
        /// 									            @param seconds Amount of time, in seconds since the simulation's start, to advance.
        /// 									            @tsexample
        /// 									               // Tell the projectile to process a simulation event, and provide the amount of time
        /// 										            // that has passed since the simulation began.
        /// 										            %seconds = 2.0;
        /// 										            %projectile.presimulate(%seconds);
        /// 									            @endtsexample
        ///                                        @note This function is not called if the SimObject::hidden is true.)
        /// 
        /// </summary>
        public void presimulate(float seconds)
            {
            TorqueScriptTemplate.m_ts.fnProjectile_presimulate(_mSimObjectId, seconds);
            }
        }
    }