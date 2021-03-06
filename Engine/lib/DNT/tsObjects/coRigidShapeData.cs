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
    internal class tsObjectConvertercoRigidShapeData : TypeConverter
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
                return new coRigidShapeData(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoRigidShapeData))]
    public class coRigidShapeData : coShapeBaseData
        {
        private Point3F _massBox;
        private Point3F _massCenter;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coRigidShapeData(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coRigidShapeData(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coRigidShapeData(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// How much friction this object has. Lower values will cause the object to appear to be more slippery.
        /// </summary>
        public float bodyFriction
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".bodyFriction").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".bodyFriction", value.AsString()); }
            }

        /// <summary>
        /// The percentage of kinetic energy kept by this object in a collision.
        /// </summary>
        public float bodyRestitution
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".bodyRestitution").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".bodyRestitution", value.AsString()); }
            }

        /// <summary>
        /// Scalar rate at which the third person camera offset decays, per tick.\n
        /// </summary>
        public float cameraDecay
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".cameraDecay").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".cameraDecay", value.AsString()); }
            }

        /// <summary>
        /// Scalar amount by which the third person camera lags the object, relative to the object's linear velocity.\n
        /// </summary>
        public float cameraLag
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".cameraLag").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".cameraLag", value.AsString()); }
            }

        /// <summary>
        /// The vertical offset of the object's camera.\n
        /// </summary>
        public float cameraOffset
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".cameraOffset").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".cameraOffset", value.AsString()); }
            }

        /// <summary>
        /// Specifies whether the camera's rotation matrix, and the render eye transform are multiplied during camera updates.\n
        /// </summary>
        public bool cameraRoll
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".cameraRoll").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".cameraRoll", value.AsString()); }
            }

        /// <summary>
        /// Collision distance tolerance.
        /// </summary>
        public float collisionTol
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".collisionTol").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".collisionTol", value.AsString()); }
            }

        /// <summary>
        /// Contact velocity tolerance.
        /// </summary>
        public float contactTol
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".contactTol").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".contactTol", value.AsString()); }
            }

        /// <summary>
        /// Used to simulate the constant drag acting on the object
        /// </summary>
        public float dragForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".dragForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".dragForce", value.AsString()); }
            }

        /// <summary>
        /// Array of pointers to ParticleEmitterData datablocks which will be used to emit particles at object/terrain contact point.\n
        /// </summary>
        public coParticleEmitterData dustEmitter
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".dustEmitter"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".dustEmitter", value.ToString()); }
            }

        /// <summary>
        /// Height of dust effects.\n
        /// </summary>
        public float dustHeight
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".dustHeight").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".dustHeight", value.AsString()); }
            }

        /// <summary>
        /// Particle emitter used to create a dust trail for the moving object.\n
        /// </summary>
        public coParticleEmitterData dustTrailEmitter
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".dustTrailEmitter"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".dustTrailEmitter", value.ToString()); }
            }

        /// <summary>
        /// The AudioProfile will be used to produce sounds when emerging from water.\n
        /// </summary>
        public coSFXTrack exitingWater
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".exitingWater"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".exitingWater", value.ToString()); }
            }

        /// <summary>
        /// The minimum velocity at which the exit splash sound will be played when emerging from water.\n
        /// </summary>
        public float exitSplashSoundVelocity
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".exitSplashSoundVelocity").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".exitSplashSoundVelocity", value.AsString()); }
            }

        /// <summary>
        /// Sound to play when body impacts with at least hardImpactSpeed. 
        /// </summary>
        public coSFXTrack hardImpactSound
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".hardImpactSound"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".hardImpactSound", value.ToString()); }
            }

        /// <summary>
        /// Minimum speed at which the object must be travelling for the hard impact sound to be played.
        /// </summary>
        public float hardImpactSpeed
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".hardImpactSpeed").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".hardImpactSpeed", value.AsString()); }
            }

        /// <summary>
        /// The minimum velocity at which the hard splash sound will be played when impacting water.\n
        /// </summary>
        public float hardSplashSoundVelocity
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".hardSplashSoundVelocity").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".hardSplashSoundVelocity", value.AsString()); }
            }

        /// <summary>
        /// The AudioProfile will be used to produce sounds when a soft impact with water occurs.\n
        /// </summary>
        public coSFXTrack impactWaterEasy
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".impactWaterEasy"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".impactWaterEasy", value.ToString()); }
            }

        /// <summary>
        /// The AudioProfile will be used to produce sounds when a hard impact with water occurs.\n
        /// </summary>
        public coSFXTrack impactWaterHard
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".impactWaterHard"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".impactWaterHard", value.ToString()); }
            }

        /// <summary>
        /// The AudioProfile will be used to produce sounds when a medium impact with water occurs.\n
        /// </summary>
        public coSFXTrack impactWaterMedium
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".impactWaterMedium"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".impactWaterMedium", value.ToString()); }
            }

        /// <summary>
        /// Number of physics steps to process per tick.
        /// </summary>
        public int integration
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".integration").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".integration", value.AsString()); }
            }

        /// <summary>
        /// Size of inertial box.
        /// </summary>
        public Point3F massBox
            {
            get
                {
                if (_massBox != null)
                    _massBox.DetachAllEvents();
                _massBox = dnTorque.self.GetVar(_mSimObjectId + ".massBox").AsPoint3F();
                _massBox.OnChangeNotification += _massBox_OnChangeNotification;
                return _massBox;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".massBox", value.AsString()); }
            }

        /// <summary>
        /// Center of mass for rigid body.
        /// </summary>
        public Point3F massCenter
            {
            get
                {
                if (_massCenter != null)
                    _massCenter.DetachAllEvents();
                _massCenter = dnTorque.self.GetVar(_mSimObjectId + ".massCenter").AsPoint3F();
                _massCenter.OnChangeNotification += _massCenter_OnChangeNotification;
                return _massCenter;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".massCenter", value.AsString()); }
            }

        /// <summary>
        /// Maximum drag available to this object.
        /// </summary>
        public float maxDrag
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".maxDrag").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxDrag", value.AsString()); }
            }

        /// <summary>
        /// The minimum velocity at which the medium splash sound will be played when impacting water.\n
        /// </summary>
        public float mediumSplashSoundVelocity
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".mediumSplashSoundVelocity").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".mediumSplashSoundVelocity", value.AsString()); }
            }

        /// <summary>
        /// Minimum drag available to this object.
        /// </summary>
        public float minDrag
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".minDrag").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".minDrag", value.AsString()); }
            }

        /// <summary>
        /// Minimum collision speed to classify collision as impact (triggers onImpact on server object). 
        /// </summary>
        public float minImpactSpeed
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".minImpactSpeed").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".minImpactSpeed", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public float minRollSpeed
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".minRollSpeed").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".minRollSpeed", value.AsString()); }
            }

        /// <summary>
        /// Sound to play when body impacts with at least softImageSpeed but less than hardImpactSpeed. 
        /// </summary>
        public coSFXTrack softImpactSound
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".softImpactSound"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".softImpactSound", value.ToString()); }
            }

        /// <summary>
        /// Minimum speed at which this object must be travelling for the soft impact sound to be played.
        /// </summary>
        public float softImpactSpeed
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".softImpactSpeed").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".softImpactSpeed", value.AsString()); }
            }

        /// <summary>
        /// The minimum velocity at which the soft splash sound will be played when impacting water.\n
        /// </summary>
        public float softSplashSoundVelocity
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".softSplashSoundVelocity").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".softSplashSoundVelocity", value.AsString()); }
            }

        /// <summary>
        /// Array of pointers to ParticleEmitterData datablocks which will generate splash effects.\n
        /// </summary>
        public coParticleEmitterData splashEmitter
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".splashEmitter"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".splashEmitter", value.ToString()); }
            }

        /// <summary>
        /// The simulated frequency modulation of a splash generated by this object. Multiplied along with speed and time elapsed when determining splash emition rate.\n
        /// </summary>
        public float splashFreqMod
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".splashFreqMod").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".splashFreqMod", value.AsString()); }
            }

        /// <summary>
        /// The threshold speed at which we consider the object's movement to have stopped when updating splash effects.\n
        /// </summary>
        public float splashVelEpsilon
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".splashVelEpsilon").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".splashVelEpsilon", value.AsString()); }
            }

        /// <summary>
        /// Maximum height from the ground at which the object will generate dust.\n
        /// </summary>
        public float triggerDustHeight
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".triggerDustHeight").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".triggerDustHeight", value.AsString()); }
            }

        /// <summary>
        /// The scalar applied to the vertical portion of the velocity drag acting on a object.
        /// </summary>
        public float vertFactor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".vertFactor").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".vertFactor", value.AsString()); }
            }

        /// <summary>
        /// The AudioProfile will be used to produce sounds when a water wake is displayed.\n
        /// </summary>
        public coSFXTrack waterWakeSound
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".waterWakeSound"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".waterWakeSound", value.ToString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coRigidShapeData ts, string simobjectid)
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
        public static bool operator !=(coRigidShapeData ts, string simobjectid)
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
        public static implicit operator string(coRigidShapeData ts)
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
        public static implicit operator coRigidShapeData(string ts)
            {
            return new coRigidShapeData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coRigidShapeData ts)
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
        public static implicit operator coRigidShapeData(int ts)
            {
            return new coRigidShapeData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coRigidShapeData ts)
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
        public static implicit operator coRigidShapeData(uint ts)
            {
            return new coRigidShapeData(ts);
            }

        private void _massBox_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".massBox", e.NewValue);
            }

        private void _massCenter_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".massCenter", e.NewValue);
            }
        }
    }