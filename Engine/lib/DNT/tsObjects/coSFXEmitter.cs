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
                return new coSFXEmitter(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoSFXEmitter))]
    public class coSFXEmitter : coSceneObject
        {
        private Point3F _scatterDistance;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coSFXEmitter(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coSFXEmitter(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coSFXEmitter(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// Angle of inner volume cone of 3D sound in degrees.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::coneInsideAngle 
        /// </summary>
        public int coneInsideAngle
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".coneInsideAngle").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".coneInsideAngle", value.AsString()); }
            }

        /// <summary>
        /// Angle of outer volume cone of 3D sound in degrees\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::coneOutsideAngle 
        /// </summary>
        public int coneOutsideAngle
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".coneOutsideAngle").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".coneOutsideAngle", value.AsString()); }
            }

        /// <summary>
        /// Volume scale factor of outside of outer volume 3D sound cone.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::coneOutsideVolume 
        /// </summary>
        public float coneOutsideVolume
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".coneOutsideVolume").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".coneOutsideVolume", value.AsString()); }
            }

        /// <summary>
        /// Number of seconds to gradually fade in volume from zero when playback starts.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::fadeInTime 
        /// </summary>
        public float fadeInTime
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".fadeInTime").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".fadeInTime", value.AsString()); }
            }

        /// <summary>
        /// Number of seconds to gradually fade out volume down to zero when playback is stopped or paused.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::fadeOutTime 
        /// </summary>
        public float fadeOutTime
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".fadeOutTime").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".fadeOutTime", value.AsString()); }
            }

        /// <summary>
        /// The sound file to play.\n     Use @b either this property @b or #track. If both are assigned, #track takes precendence. The primary purpose of this      field is to avoid the need for the user to define SFXTrack datablocks for all sounds used in a level. 
        /// </summary>
        public String fileName
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".fileName").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".fileName", value.AsString()); }
            }

        /// <summary>
        /// Whether to play #fileName as a positional (3D) sound or not.\n     If a #track is assigned, the value of this field is ignored.\n\n     @see SFXDescription::is3D 
        /// </summary>
        public bool is3D
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".is3D").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".is3D", value.AsString()); }
            }

        /// <summary>
        /// Whether to play #fileName in an infinite loop.\n     If a #track is assigned, the value of this field is ignored.\n     @see SFXDescription::isLooping 
        /// </summary>
        public bool isLooping
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".isLooping").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".isLooping", value.AsString()); }
            }

        /// <summary>
        /// Whether to use streamed playback for #fileName.\n     If a #track is assigned, the value of this field is ignored.\n     @see SFXDescription::isStreaming\n\n     @ref SFX_streaming 
        /// </summary>
        public bool isStreaming
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".isStreaming").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".isStreaming", value.AsString()); }
            }

        /// <summary>
        /// Distance at which to stop volume attenuation of the 3D sound.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::maxDistance 
        /// </summary>
        public float maxDistance
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".maxDistance").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxDistance", value.AsString()); }
            }

        /// <summary>
        /// Pitch shift to apply to the sound. Default is 1 = play at normal speed.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::pitch 
        /// </summary>
        public float pitch
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".pitch").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".pitch", value.AsString()); }
            }

        /// <summary>
        /// Whether playback of the emitter's sound should start as soon as the emitter object is added to the level.\n     If this is true, the emitter will immediately start to play when the level is loaded. 
        /// </summary>
        public bool playOnAdd
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".playOnAdd").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".playOnAdd", value.AsString()); }
            }

        /// <summary>
        /// Distance at which to start volume attenuation of the 3D sound.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::referenceDistance 
        /// </summary>
        public float referenceDistance
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".referenceDistance").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".referenceDistance", value.AsString()); }
            }

        /// <summary>
        /// Bounds on random offset to apply to initial 3D sound position.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::scatterDistance 
        /// </summary>
        public Point3F scatterDistance
            {
            get
                {
                if (_scatterDistance != null)
                    _scatterDistance.DetachAllEvents();
                _scatterDistance = dnTorque.self.GetVar(_mSimObjectId + ".scatterDistance").AsPoint3F();
                _scatterDistance.OnChangeNotification += _scatterDistance_OnChangeNotification;
                return _scatterDistance;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".scatterDistance", value.AsString()); }
            }

        /// <summary>
        /// The SFXSource to which to assign the sound of this emitter as a child.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::sourceGroup 
        /// </summary>
        public coSFXSource sourceGroup
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".sourceGroup"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".sourceGroup", value.ToString()); }
            }

        /// <summary>
        /// The track which the emitter should play.\n     @note If assigned, this field will take precedence over a #fileName that may also be assigned to the       emitter. 
        /// </summary>
        public coSFXTrack track
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".track"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".track", value.ToString()); }
            }

        /// <summary>
        /// If this is true, all fields except for #playOnAdd and #track are ignored on the emitter object.\n     This is useful to prevent fields in the #track's description from being overridden by emitter fields. 
        /// </summary>
        public bool useTrackDescriptionOnly
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".useTrackDescriptionOnly").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".useTrackDescriptionOnly", value.AsString()); }
            }

        /// <summary>
        /// Volume level to apply to the sound.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::volume 
        /// </summary>
        public float volume
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".volume").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".volume", value.AsString()); }
            }

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
            return (this._mSimObjectId == (string) myReflections.ChangeType(obj, typeof (string)));
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
        public static implicit operator string(coSFXEmitter ts)
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
        public static implicit operator coSFXEmitter(string ts)
            {
            return new coSFXEmitter(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coSFXEmitter ts)
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
        public static implicit operator coSFXEmitter(int ts)
            {
            return new coSFXEmitter(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coSFXEmitter ts)
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
        public static implicit operator coSFXEmitter(uint ts)
            {
            return new coSFXEmitter(ts);
            }

        private void _scatterDistance_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".scatterDistance", e.NewValue);
            }

        /// <summary>
        /// Get the sound source object from the emitter.
        ///    @return The sound source used by the emitter or null.
        ///    @note This method will return null when called on the server-side SFXEmitter object.  Only client-side ghosts 
        ///       actually hold on to %SFXSources. )
        /// 
        /// </summary>
        public string getSource()
            {
            return TorqueScriptTemplate.m_ts.fnSFXEmitter_getSource(_mSimObjectId);
            }

        /// <summary>
        /// Manually start playback of the emitter's sound.
        ///    If this is called on the server-side object, the play command will be related to all client-side ghosts. )
        /// 
        /// </summary>
        public void play()
            {
            TorqueScriptTemplate.m_ts.fnSFXEmitter_play(_mSimObjectId);
            }

        /// <summary>
        /// Manually stop playback of the emitter's sound.
        ///    If this is called on the server-side object, the stop command will be related to all client-side ghosts. )
        /// 
        /// </summary>
        public void stop()
            {
            TorqueScriptTemplate.m_ts.fnSFXEmitter_stop(_mSimObjectId);
            }
        }
    }