
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
    internal class tsObjectConvertercoSFXEmitter : TypeConverter
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
                return new coSFXEmitter(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoSFXEmitter))]
    public class coSFXEmitter: coSceneObject
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coSFXEmitter(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coSFXEmitter(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coSFXEmitter(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coSFXEmitter ts, string simobjectid)
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
        public static bool operator !=(coSFXEmitter ts, string simobjectid)
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
        public static implicit operator string( coSFXEmitter ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSFXEmitter(string ts)
            {
            return new coSFXEmitter(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coSFXEmitter ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSFXEmitter(int ts)
            {
            return new coSFXEmitter(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coSFXEmitter ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSFXEmitter(uint ts)
            {
            return new coSFXEmitter(ts);
            }
public int coneInsideAngle
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".coneInsideAngle").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".coneInsideAngle", value.AsString());
          }
       }
public int coneOutsideAngle
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".coneOutsideAngle").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".coneOutsideAngle", value.AsString());
          }
       }
public float coneOutsideVolume
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".coneOutsideVolume").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".coneOutsideVolume", value.AsString());
          }
       }
public float fadeInTime
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fadeInTime").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fadeInTime", value.AsString());
          }
       }
public float fadeOutTime
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fadeOutTime").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fadeOutTime", value.AsString());
          }
       }
public String fileName
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fileName").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fileName", value.AsString());
          }
       }
public bool is3D
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".is3D").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".is3D", value.AsString());
          }
       }
public bool isLooping
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".isLooping").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".isLooping", value.AsString());
          }
       }
public bool isStreaming
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".isStreaming").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".isStreaming", value.AsString());
          }
       }
public float maxDistance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".maxDistance").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".maxDistance", value.AsString());
          }
       }
public float pitch
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".pitch").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".pitch", value.AsString());
          }
       }
public bool playOnAdd
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".playOnAdd").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".playOnAdd", value.AsString());
          }
       }
public float referenceDistance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".referenceDistance").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".referenceDistance", value.AsString());
          }
       }
public Point3F scatterDistance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".scatterDistance").AsPoint3F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".scatterDistance", value.AsString());
          }
       }
public coSFXSource sourceGroup
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".sourceGroup");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".sourceGroup", value.ToString());
          }
       }
public coSFXTrack track
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".track");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".track", value.ToString());
          }
       }
public bool useTrackDescriptionOnly
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".useTrackDescriptionOnly").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".useTrackDescriptionOnly", value.AsString());
          }
       }
public float volume
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".volume").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".volume", value.AsString());
          }
       }
/// <summary>
/// Get the sound source object from the emitter.
///    @return The sound source used by the emitter or null.
///    @note This method will return null when called on the server-side SFXEmitter object.  Only client-side ghosts 
///       actually hold on to %SFXSources. )
/// 
/// </summary>
public  string getSource(){
return TorqueScriptTemplate.m_ts.fnSFXEmitter_getSource(_mSimObjectId);
}
/// <summary>
/// Manually start playback of the emitter's sound.
///    If this is called on the server-side object, the play command will be related to all client-side ghosts. )
/// 
/// </summary>
public  void play(){
TorqueScriptTemplate.m_ts.fnSFXEmitter_play(_mSimObjectId);
}
/// <summary>
/// Manually stop playback of the emitter's sound.
///    If this is called on the server-side object, the stop command will be related to all client-side ghosts. )
/// 
/// </summary>
public  void stop(){
TorqueScriptTemplate.m_ts.fnSFXEmitter_stop(_mSimObjectId);
}
}}