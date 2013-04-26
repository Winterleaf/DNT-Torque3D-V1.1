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
    internal class tsObjectConvertercoHoverVehicleData : TypeConverter
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
                return new coHoverVehicleData(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoHoverVehicleData))]
    public class coHoverVehicleData : coVehicleData
        {
        private Point3F _dustTrailOffset;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coHoverVehicleData(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coHoverVehicleData(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coHoverVehicleData(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// Maximum speed below which a braking force is applied.\n\n@see brakingForce 
        /// </summary>
        public float brakingActivationSpeed
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".brakingActivationSpeed").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".brakingActivationSpeed", value.AsString()); }
            }

        /// <summary>
        /// Force generated by braking.\nThe vehicle is considered to be braking if    it is moving, but the throttle is off, and no left or right thrust is    being applied. This force is only applied when the vehicle's velocity is    less than brakingActivationSpeed. 
        /// </summary>
        public float brakingForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".brakingForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".brakingForce", value.AsString()); }
            }

        /// <summary>
        /// Drag force factor that acts opposite to the vehicle velocity.\nAlso    used to determnine the vehicle's maxThrustSpeed.\n@see mainThrustForce 
        /// </summary>
        public float dragForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".dragForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".dragForce", value.AsString()); }
            }

        /// <summary>
        /// Emitter to generate particles for the vehicle's dust trail.\nThe trail    of dust particles is generated only while the vehicle is moving. 
        /// </summary>
        public coParticleEmitterData dustTrailEmitter
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".dustTrailEmitter"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".dustTrailEmitter", value.ToString()); }
            }

        /// <summary>
        /// Number of dust trail particles to generate based on vehicle speed.\nThe    vehicle's speed is divided by this value to determine how many particles    to generate each frame. Lower values give a more dense trail, higher    values a more sparse trail. 
        /// </summary>
        public float dustTrailFreqMod
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".dustTrailFreqMod").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".dustTrailFreqMod", value.AsString()); }
            }

        /// <summary>
        /// \X Y Z\ offset from the vehicle's origin from which to generate dust    trail particles.\nBy default particles are emitted directly beneath the    origin of the vehicle model. 
        /// </summary>
        public Point3F dustTrailOffset
            {
            get
                {
                if (_dustTrailOffset != null)
                    _dustTrailOffset.DetachAllEvents();
                _dustTrailOffset = dnTorque.self.GetVar(_mSimObjectId + ".dustTrailOffset").AsPoint3F();
                _dustTrailOffset.OnChangeNotification += _dustTrailOffset_OnChangeNotification;
                return _dustTrailOffset;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".dustTrailOffset", value.AsString()); }
            }

        /// <summary>
        /// Looping engine sound.\nThe volume is dynamically adjusted based on the    current thrust level. 
        /// </summary>
        public coSFXProfile engineSound
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".engineSound"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".engineSound", value.ToString()); }
            }

        /// <summary>
        /// Scale factor applied to the vehicle gravitational force when the vehicle    is floating.\n\n@see stabLenMin 
        /// </summary>
        public float floatingGravMag
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".floatingGravMag").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".floatingGravMag", value.AsString()); }
            }

        /// <summary>
        /// Scalar applied to the vehicle's thrust force when the vehicle is floating.\n   @note The floatingThrustFactor must be between 0.0 and 1.0 (inclusive). 
        /// </summary>
        public float floatingThrustFactor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".floatingThrustFactor").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".floatingThrustFactor", value.AsString()); }
            }

        /// <summary>
        /// Looping sound played while the vehicle is floating.\n\n@see stabMinLen 
        /// </summary>
        public coSFXProfile floatSound
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".floatSound"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".floatSound", value.ToString()); }
            }

        /// <summary>
        /// Emitter to generate particles for forward jet thrust.\nForward jet    thrust particles are emitted from model nodes JetNozzle0 and JetNozzle1. 
        /// </summary>
        public coParticleEmitterData forwardJetEmitter
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".forwardJetEmitter"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".forwardJetEmitter", value.ToString()); }
            }

        /// <summary>
        /// Damping torque that acts against the vehicle's current angular momentum. 
        /// </summary>
        public float gyroDrag
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".gyroDrag").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".gyroDrag", value.AsString()); }
            }

        /// <summary>
        /// Looping sound played when the vehicle is jetting. 
        /// </summary>
        public coSFXProfile jetSound
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".jetSound"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".jetSound", value.ToString()); }
            }

        /// <summary>
        /// Force generated by thrusting the vehicle forward.\nAlso used to determine    the maxThrustSpeed:\n\n   @tsexample\n   maxThrustSpeed = (mainThrustForce + strafeThrustForce) / dragForce;\n   @endtsexample\n 
        /// </summary>
        public float mainThrustForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".mainThrustForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".mainThrustForce", value.AsString()); }
            }

        /// <summary>
        /// Force generated in the ground normal direction when the vehicle is not    floating (within stabalizer length from the ground).\n\n   @see stabLenMin 
        /// </summary>
        public float normalForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".normalForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".normalForce", value.AsString()); }
            }

        /// <summary>
        /// Pitch (rotation about the X-axis) force applied when steering in the y-axis direction. 
        /// </summary>
        public float pitchForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".pitchForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".pitchForce", value.AsString()); }
            }

        /// <summary>
        /// Force generated to stabalize the vehicle (return it to neutral pitch/roll)    when the vehicle is floating (more than stabalizer length from the    ground.\n\n@see stabLenMin 
        /// </summary>
        public float restorativeForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".restorativeForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".restorativeForce", value.AsString()); }
            }

        /// <summary>
        /// Force generated by thrusting the vehicle backward. 
        /// </summary>
        public float reverseThrustForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".reverseThrustForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".reverseThrustForce", value.AsString()); }
            }

        /// <summary>
        /// Roll (rotation about the Y-axis) force applied when steering in the x-axis direction. 
        /// </summary>
        public float rollForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".rollForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".rollForce", value.AsString()); }
            }

        /// <summary>
        /// Damping spring force acting against changes in the stabalizer length.\n\n   @see stabLenMin 
        /// </summary>
        public float stabDampingConstant
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stabDampingConstant").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stabDampingConstant", value.AsString()); }
            }

        /// <summary>
        /// Length of the base stabalizer when travelling at maximum speed    (maxThrustSpeed).\n\n@see stabLenMin\n\n@see mainThrustForce 
        /// </summary>
        public float stabLenMax
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stabLenMax").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stabLenMax", value.AsString()); }
            }

        /// <summary>
        /// Length of the base stabalizer when travelling at minimum speed (0).\n   Each tick, the vehicle performs 2 raycasts (from the center back and    center front of the vehicle) to check for contact with the ground. The    base stabalizer length determines the length of that raycast; if    neither raycast hit the ground, the vehicle is floating, stabalizer    spring and ground normal forces are not applied.\n\n   img src=\images/hoverVehicle_forces.png\\n   @see stabSpringConstant 
        /// </summary>
        public float stabLenMin
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stabLenMin").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stabLenMin", value.AsString()); }
            }

        /// <summary>
        /// Value used to generate stabalizer spring force. The force generated    depends on stabilizer compression, that is how close the vehicle is    to the ground proportional to current stabalizer length.\n\n   @see stabLenMin 
        /// </summary>
        public float stabSpringConstant
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stabSpringConstant").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stabSpringConstant", value.AsString()); }
            }

        /// <summary>
        /// Yaw (rotation about the Z-axis) force applied when steering in the x-axis direction.   about the vehicle's Z-axis) 
        /// </summary>
        public float steeringForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".steeringForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".steeringForce", value.AsString()); }
            }

        /// <summary>
        /// Force generated by thrusting the vehicle to one side.\nAlso used to    determine the vehicle's maxThrustSpeed.\n@see mainThrustForce 
        /// </summary>
        public float strafeThrustForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".strafeThrustForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".strafeThrustForce", value.AsString()); }
            }

        /// <summary>
        /// Maximum height above surface to emit dust trail particles.\nIf the vehicle    is less than triggerTrailHeight above a static surface with a material that    has 'showDust' set to true, the vehicle will emit particles from the    dustTrailEmitter. 
        /// </summary>
        public float triggerTrailHeight
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".triggerTrailHeight").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".triggerTrailHeight", value.AsString()); }
            }

        /// <summary>
        /// Scale factor applied to the vehicle's thrust force when jetting. 
        /// </summary>
        public float turboFactor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".turboFactor").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".turboFactor", value.AsString()); }
            }

        /// <summary>
        /// Scalar applied to the vertical portion of the velocity drag acting on    the vehicle.\nFor the horizontal (X and Y) components of velocity drag,    a factor of 0.25 is applied when the vehicle is floating, and a factor    of 1.0 is applied when the vehicle is not floating. This velocity drag    is multiplied by the vehicle's dragForce, as defined above, and the    result is subtracted from it's movement force.\n   @note The vertFactor must be between 0.0 and 1.0 (inclusive). 
        /// </summary>
        public float vertFactor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".vertFactor").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".vertFactor", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coHoverVehicleData ts, string simobjectid)
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
        public static bool operator !=(coHoverVehicleData ts, string simobjectid)
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
        public static implicit operator string(coHoverVehicleData ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coHoverVehicleData(string ts)
            {
            return new coHoverVehicleData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coHoverVehicleData ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coHoverVehicleData(int ts)
            {
            return new coHoverVehicleData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coHoverVehicleData ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coHoverVehicleData(uint ts)
            {
            return new coHoverVehicleData(ts);
            }

        private void _dustTrailOffset_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".dustTrailOffset", e.NewValue);
            }
        }
    }