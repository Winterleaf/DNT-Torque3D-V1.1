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
    internal class tsObjectConvertercoGuiTheoraCtrl : TypeConverter
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
                return new coGuiTheoraCtrl(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiTheoraCtrl))]
    public class coGuiTheoraCtrl : coGuiControl
        {
        private ColorI _backgroundColor;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiTheoraCtrl(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiTheoraCtrl(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiTheoraCtrl(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// Fill color when video is not playing. 
        /// </summary>
        public ColorI backgroundColor
            {
            get
                {
                if (_backgroundColor != null)
                    _backgroundColor.DetachAllEvents();
                _backgroundColor = dnTorque.self.GetVar(_mSimObjectId + ".backgroundColor").AsColorI();
                _backgroundColor.OnChangeNotification += _backgroundColor_OnChangeNotification;
                return _backgroundColor;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".backgroundColor", value.AsString()); }
            }

        /// <summary>
        /// Whether to automatically match control extents to the video size. 
        /// </summary>
        public bool matchVideoSize
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".matchVideoSize").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".matchVideoSize", value.AsString()); }
            }

        /// <summary>
        /// Whether to start playing video when control is woken up. 
        /// </summary>
        public bool playOnWake
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".playOnWake").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".playOnWake", value.AsString()); }
            }

        /// <summary>
        /// If true, displays an overlay on top of the video with useful debugging information. 
        /// </summary>
        public bool renderDebugInfo
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".renderDebugInfo").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".renderDebugInfo", value.AsString()); }
            }

        /// <summary>
        /// Whether to stop video when control is set to sleep.\n\n     If this is not set to true, the video will be paused when the control is put to sleep. This is because there is no support      for seeking in the video stream in the player backend and letting the time source used to synchronize video (either audio      or a raw timer) get far ahead of frame decoding will cause possibly very long delays when the control is woken up again. 
        /// </summary>
        public bool stopOnSleep
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stopOnSleep").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stopOnSleep", value.AsString()); }
            }

        /// <summary>
        /// Theora video file to play. 
        /// </summary>
        public String theoraFile
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".theoraFile").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".theoraFile", value.AsString()); }
            }

        /// <summary>
        /// The routine to use for Y'CbCr to RGB conversion. 
        /// </summary>
        public OggTheoraDecoder__ETranscoder transcoder
            {
            get { return (OggTheoraDecoder__ETranscoder) Enum.Parse(typeof (OggTheoraDecoder__ETranscoder), dnTorque.self.GetVar(_mSimObjectId + ".transcoder")); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".transcoder", value.ToString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiTheoraCtrl ts, string simobjectid)
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
        public static bool operator !=(coGuiTheoraCtrl ts, string simobjectid)
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
        public static implicit operator string(coGuiTheoraCtrl ts)
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
        public static implicit operator coGuiTheoraCtrl(string ts)
            {
            return new coGuiTheoraCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiTheoraCtrl ts)
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
        public static implicit operator coGuiTheoraCtrl(int ts)
            {
            return new coGuiTheoraCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiTheoraCtrl ts)
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
        public static implicit operator coGuiTheoraCtrl(uint ts)
            {
            return new coGuiTheoraCtrl(ts);
            }

        private void _backgroundColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".backgroundColor", e.NewValue);
            }

        /// <summary>
        /// Get the current playback time.
        ///    @return The elapsed playback time in seconds. )
        /// 
        /// </summary>
        public float getCurrentTime()
            {
            return TorqueScriptTemplate.m_ts.fnGuiTheoraCtrl_getCurrentTime(_mSimObjectId);
            }

        /// <summary>
        /// Test whether the video has finished playing.
        ///    @return True if the video has finished playing, false otherwise. )
        /// 
        /// </summary>
        public bool isPlaybackDone()
            {
            return TorqueScriptTemplate.m_ts.fnGuiTheoraCtrl_isPlaybackDone(_mSimObjectId);
            }

        /// <summary>
        /// Pause playback of the video.  If the video is not currently playing, the call is ignored.
        ///    While stopped, the control displays the last frame. )
        /// 
        /// </summary>
        public void pause()
            {
            TorqueScriptTemplate.m_ts.fnGuiTheoraCtrl_pause(_mSimObjectId);
            }

        /// <summary>
        /// Start playing the video.  If the video is already playing, the call is ignored. )
        /// 
        /// </summary>
        public void play()
            {
            TorqueScriptTemplate.m_ts.fnGuiTheoraCtrl_play(_mSimObjectId);
            }

        /// <summary>
        /// Set the video file to play.  If a video is already playing, playback is stopped and 
        ///    the new video file is loaded.
        ///    @param filename The video file to load. )
        /// 
        /// </summary>
        public void setFile(string filename)
            {
            TorqueScriptTemplate.m_ts.fnGuiTheoraCtrl_setFile(_mSimObjectId, filename);
            }

        /// <summary>
        /// Stop playback of the video.  The next call to play() will then start playback from the beginning of the video.
        ///    While stopped, the control renders empty with just the background color. )
        /// 
        /// </summary>
        public void stop()
            {
            TorqueScriptTemplate.m_ts.fnGuiTheoraCtrl_stop(_mSimObjectId);
            }
        }
    }