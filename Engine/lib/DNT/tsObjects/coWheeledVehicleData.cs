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

#endregion

namespace WinterLeaf.tsObjects
    {
    /// <summary>
    /// 
    /// </summary>
    internal class tsObjectConvertercoWheeledVehicleData : TypeConverter
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
                return new coWheeledVehicleData(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoWheeledVehicleData))]
    public class coWheeledVehicleData : coVehicleData
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coWheeledVehicleData(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coWheeledVehicleData(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coWheeledVehicleData(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// @brief Torque applied when braking.\n\n   This controls how fast the vehicle will stop when the brakes are applied. 
        /// </summary>
        public float brakeTorque
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".brakeTorque").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".brakeTorque", value.AsString()); }
            }

        /// <summary>
        /// @brief Braking torque applied by the engine when the throttle and brake    are both 0.\n\n   This controls how quickly the vehicle will coast to a stop. 
        /// </summary>
        public float engineBrake
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".engineBrake").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".engineBrake", value.AsString()); }
            }

        /// <summary>
        /// @brief Looping engine sound.\n\n   The pitch is dynamically adjusted based on the current engine RPM 
        /// </summary>
        public coSFXTrack engineSound
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".engineSound"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".engineSound", value.ToString()); }
            }

        /// <summary>
        /// @brief Torque available from the engine at 100% throttle.\n\n   This controls vehicle acceleration. ie. how fast it will reach maximum speed. 
        /// </summary>
        public float engineTorque
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".engineTorque").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".engineTorque", value.AsString()); }
            }

        /// <summary>
        /// Looping sound played when the vehicle is jetting. 
        /// </summary>
        public coSFXTrack jetSound
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".jetSound"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".jetSound", value.ToString()); }
            }

        /// <summary>
        /// @brief Maximum linear velocity of each wheel.\n\n   This caps the maximum speed of the vehicle. 
        /// </summary>
        public float maxWheelSpeed
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".maxWheelSpeed").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxWheelSpeed", value.AsString()); }
            }

        /// <summary>
        /// @brief Looping sound played while any of the wheels is slipping.\n\n   The volume is dynamically adjusted based on how much the wheels are slipping. 
        /// </summary>
        public coSFXTrack squealSound
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".squealSound"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".squealSound", value.ToString()); }
            }

        /// <summary>
        /// ParticleEmitterData datablock used to generate particles from each wheel    when the vehicle is moving and the wheel is in contact with the ground.
        /// </summary>
        public coParticleEmitterData tireEmitter
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".tireEmitter"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".tireEmitter", value.ToString()); }
            }

        /// <summary>
        /// Sound played when the wheels impact the ground.\nCurrently unused. 
        /// </summary>
        public coSFXTrack WheelImpactSound
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".WheelImpactSound"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".WheelImpactSound", value.ToString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coWheeledVehicleData ts, string simobjectid)
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
        public static bool operator !=(coWheeledVehicleData ts, string simobjectid)
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
        public static implicit operator string(coWheeledVehicleData ts)
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
        public static implicit operator coWheeledVehicleData(string ts)
            {
            return new coWheeledVehicleData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coWheeledVehicleData ts)
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
        public static implicit operator coWheeledVehicleData(int ts)
            {
            return new coWheeledVehicleData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coWheeledVehicleData ts)
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
        public static implicit operator coWheeledVehicleData(uint ts)
            {
            return new coWheeledVehicleData(ts);
            }
        }
    }