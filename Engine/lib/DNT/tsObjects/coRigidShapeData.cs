
// Copyright (C) 2012 Winterleaf Entertainment L,L,C.
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

#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Classes;
using WinterLeaf.Containers;
using WinterLeaf.Enums;
using System.ComponentModel;
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
            return (typeof(string) == sourceType);
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
    [TypeConverter(typeof(tsObjectConvertercoRigidShapeData))]
    public class coRigidShapeData: coShapeBaseData
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coRigidShapeData(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coRigidShapeData(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coRigidShapeData(int simobjectid): base(simobjectid){ }


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
            
            return (this._mSimObjectId ==(string)myReflections.ChangeType( obj,typeof(string)));
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
        public static implicit operator string( coRigidShapeData ts)
            {
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
        public static implicit operator int( coRigidShapeData ts)
            {
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
        public static implicit operator uint( coRigidShapeData ts)
            {
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
public float bodyFriction
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".bodyFriction").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".bodyFriction", value.AsString());
          }
       }
public float bodyRestitution
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".bodyRestitution").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".bodyRestitution", value.AsString());
          }
       }
public float cameraDecay
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".cameraDecay").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".cameraDecay", value.AsString());
          }
       }
public float cameraLag
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".cameraLag").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".cameraLag", value.AsString());
          }
       }
public float cameraOffset
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".cameraOffset").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".cameraOffset", value.AsString());
          }
       }
public bool cameraRoll
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".cameraRoll").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".cameraRoll", value.AsString());
          }
       }
public float collisionTol
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".collisionTol").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".collisionTol", value.AsString());
          }
       }
public float contactTol
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".contactTol").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".contactTol", value.AsString());
          }
       }
public float dragForce
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dragForce").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dragForce", value.AsString());
          }
       }
public coParticleEmitterData dustEmitter
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dustEmitter");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dustEmitter", value.ToString());
          }
       }
public float dustHeight
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dustHeight").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dustHeight", value.AsString());
          }
       }
public coParticleEmitterData dustTrailEmitter
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dustTrailEmitter");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dustTrailEmitter", value.ToString());
          }
       }
public coSFXTrack exitingWater
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".exitingWater");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".exitingWater", value.ToString());
          }
       }
public float exitSplashSoundVelocity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".exitSplashSoundVelocity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".exitSplashSoundVelocity", value.AsString());
          }
       }
public coSFXTrack hardImpactSound
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".hardImpactSound");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".hardImpactSound", value.ToString());
          }
       }
public float hardImpactSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".hardImpactSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".hardImpactSpeed", value.AsString());
          }
       }
public float hardSplashSoundVelocity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".hardSplashSoundVelocity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".hardSplashSoundVelocity", value.AsString());
          }
       }
public coSFXTrack impactWaterEasy
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".impactWaterEasy");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".impactWaterEasy", value.ToString());
          }
       }
public coSFXTrack impactWaterHard
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".impactWaterHard");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".impactWaterHard", value.ToString());
          }
       }
public coSFXTrack impactWaterMedium
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".impactWaterMedium");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".impactWaterMedium", value.ToString());
          }
       }
public int integration
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".integration").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".integration", value.AsString());
          }
       }
public Point3F massBox
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".massBox").AsPoint3F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".massBox", value.AsString());
          }
       }
public Point3F massCenter
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".massCenter").AsPoint3F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".massCenter", value.AsString());
          }
       }
public float maxDrag
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".maxDrag").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".maxDrag", value.AsString());
          }
       }
public float mediumSplashSoundVelocity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".mediumSplashSoundVelocity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".mediumSplashSoundVelocity", value.AsString());
          }
       }
public float minDrag
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".minDrag").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".minDrag", value.AsString());
          }
       }
public float minImpactSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".minImpactSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".minImpactSpeed", value.AsString());
          }
       }
public float minRollSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".minRollSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".minRollSpeed", value.AsString());
          }
       }
public coSFXTrack softImpactSound
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".softImpactSound");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".softImpactSound", value.ToString());
          }
       }
public float softImpactSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".softImpactSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".softImpactSpeed", value.AsString());
          }
       }
public float softSplashSoundVelocity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".softSplashSoundVelocity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".softSplashSoundVelocity", value.AsString());
          }
       }
public coParticleEmitterData splashEmitter
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".splashEmitter");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".splashEmitter", value.ToString());
          }
       }
public float splashFreqMod
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".splashFreqMod").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".splashFreqMod", value.AsString());
          }
       }
public float splashVelEpsilon
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".splashVelEpsilon").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".splashVelEpsilon", value.AsString());
          }
       }
public float triggerDustHeight
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".triggerDustHeight").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".triggerDustHeight", value.AsString());
          }
       }
public float vertFactor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".vertFactor").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".vertFactor", value.AsString());
          }
       }
public coSFXTrack waterWakeSound
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".waterWakeSound");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".waterWakeSound", value.ToString());
          }
       }
}}