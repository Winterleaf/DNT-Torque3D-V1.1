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
    internal class tsObjectConvertercoProjectileData : TypeConverter
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
                return new coProjectileData(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoProjectileData))]
    public class coProjectileData : coGameBaseData
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coProjectileData(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coProjectileData(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coProjectileData(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// @brief Amount of time, in milliseconds, before the projectile will cause damage or explode on impact.\n\n   This value must be equal to or less than the projectile's lifetime.\n\n   @see lifetime
        /// </summary>
        public int armingDelay
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".armingDelay").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".armingDelay", value.AsString()); }
            }

        /// <summary>
        /// @brief Influences post-bounce velocity of a projectile that does not explode on contact.\n\n   Scales the velocity from a bounce after friction is taken into account.    A value of 1.0 will leave it's velocity unchanged while values greater than 1.0 will increase it.\n
        /// </summary>
        public float bounceElasticity
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".bounceElasticity").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".bounceElasticity", value.AsString()); }
            }

        /// <summary>
        /// @brief Factor to reduce post-bounce velocity of a projectile that does not explode on contact.\n\n   Reduces bounce velocity by this factor and a multiple of the tangent to impact.    Used to simulate surface friction.\n
        /// </summary>
        public float bounceFriction
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".bounceFriction").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".bounceFriction", value.AsString()); }
            }

        /// <summary>
        /// @brief Decal datablock used for decals placed at projectile explosion points.\n\n
        /// </summary>
        public coDecalData decal
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".decal"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".decal", value.ToString()); }
            }

        /// <summary>
        /// @brief Explosion datablock used when the projectile explodes outside of water.\n\n
        /// </summary>
        public coExplosionData explosion
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".explosion"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".explosion", value.ToString()); }
            }

        /// <summary>
        /// @brief Amount of time, in milliseconds, before the projectile begins to fade out.\n\n   This value must be smaller than the projectile's lifetime to have an affect.
        /// </summary>
        public int fadeDelay
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".fadeDelay").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".fadeDelay", value.AsString()); }
            }

        /// <summary>
        /// @brief Scales the influence of gravity on the projectile.\n\n   The larger this value is, the more that gravity will affect the projectile.    A value of 1.0 will assume \normal\ influence upon it.\n   The magnitude of gravity is assumed to be 9.81 m/s/s\n\n   @note ProjectileData::isBallistic must be true for this to have any affect.
        /// </summary>
        public float gravityMod
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".gravityMod").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".gravityMod", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public float impactForce
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".impactForce").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".impactForce", value.AsString()); }
            }

        /// <summary>
        /// @brief Detetmines if the projectile should be affected by gravity and whether or not    it bounces before exploding.\n\n
        /// </summary>
        public bool isBallistic
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".isBallistic").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".isBallistic", value.AsString()); }
            }

        /// <summary>
        /// @brief Amount of time, in milliseconds, before the projectile is removed from the simulation.\n\n   Used with fadeDelay to determine the transparency of the projectile at a given time.    A projectile may exist up to a maximum of 131040ms (or 4095 ticks) as defined by Projectile::MaxLivingTicks in the source code.   @see fadeDelay
        /// </summary>
        public int lifetime
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".lifetime").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".lifetime", value.AsString()); }
            }

        /// <summary>
        /// @brief LightDescription datablock used for lights attached to the projectile.\n\n
        /// </summary>
        public coLightDescription lightDesc
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".lightDesc"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".lightDesc", value.ToString()); }
            }

        /// <summary>
        /// @brief Amount of velocity the projectile recieves from the \muzzle\ of the gun.\n\n   Used with velInheritFactor to determine the initial velocity of the projectile.    This value is never modified by the engine.\n\n   @note This value by default is not transmitted between the server and the client.\n\n   @see velInheritFactor
        /// </summary>
        public float muzzleVelocity
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".muzzleVelocity").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".muzzleVelocity", value.AsString()); }
            }

        /// <summary>
        /// @brief Particle emitter datablock used to generate particles while the projectile is outside of water.\n\n   @note If datablocks are defined for both particleEmitter and particleWaterEmitter, both effects will play    as the projectile enters or leaves water.\n\n   @see particleWaterEmitter\n
        /// </summary>
        public coParticleEmitterData particleEmitter
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".particleEmitter"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".particleEmitter", value.ToString()); }
            }

        /// <summary>
        /// @brief Particle emitter datablock used to generate particles while the projectile is submerged in water.\n\n   @note If datablocks are defined for both particleWaterEmitter and particleEmitter , both effects will play    as the projectile enters or leaves water.\n\n   @see particleEmitter\n
        /// </summary>
        public coParticleEmitterData particleWaterEmitter
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".particleWaterEmitter"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".particleWaterEmitter", value.ToString()); }
            }

        /// <summary>
        /// @brief File path to the model of the projectile.\n\n
        /// </summary>
        public String projectileShapeName
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".projectileShapeName").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".projectileShapeName", value.AsString()); }
            }

        /// <summary>
        /// @brief Scale to apply to the projectile's size.\n\n   @note This is applied after SceneObject::scale\n
        /// </summary>
        public Point3F scale
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".scale").AsPoint3F(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".scale", value.AsString()); }
            }

        /// <summary>
        /// @brief SFXTrack datablock used to play sounds while in flight.\n\n
        /// </summary>
        public coSFXTrack sound
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".sound"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".sound", value.ToString()); }
            }

        /// <summary>
        /// @brief Splash datablock used to create splash effects as the projectile enters or leaves water\n\n
        /// </summary>
        public coSplashData splash
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".splash"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".splash", value.ToString()); }
            }

        /// <summary>
        /// @brief Amount of velocity the projectile recieves from the source that created it.\n\n   Use an amount between 0 and 1 for the best effect.    This value is never modified by the engine.\n   @note This value by default is not transmitted between the server and the client.
        /// </summary>
        public float velInheritFactor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".velInheritFactor").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".velInheritFactor", value.AsString()); }
            }

        /// <summary>
        /// @brief Explosion datablock used when the projectile explodes underwater.\n\n
        /// </summary>
        public coExplosionData waterExplosion
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".waterExplosion"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".waterExplosion", value.ToString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coProjectileData ts, string simobjectid)
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
        public static bool operator !=(coProjectileData ts, string simobjectid)
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
        public static implicit operator string(coProjectileData ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coProjectileData(string ts)
            {
            return new coProjectileData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coProjectileData ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coProjectileData(int ts)
            {
            return new coProjectileData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coProjectileData ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coProjectileData(uint ts)
            {
            return new coProjectileData(ts);
            }
        }
    }