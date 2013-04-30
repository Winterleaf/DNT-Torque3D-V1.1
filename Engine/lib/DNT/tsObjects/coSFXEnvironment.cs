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
    internal class tsObjectConvertercoSFXEnvironment : TypeConverter
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
                return new coSFXEnvironment(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoSFXEnvironment))]
    public class coSFXEnvironment : coSimDataBlock
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coSFXEnvironment(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coSFXEnvironment(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coSFXEnvironment(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// Change in level per meter at high frequencies. 
        /// </summary>
        public float airAbsorptionHF
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".airAbsorptionHF").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".airAbsorptionHF", value.AsString()); }
            }

        /// <summary>
        /// High-frequency to mid-frequency decay time ratio. 
        /// </summary>
        public float decayHFRatio
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".decayHFRatio").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".decayHFRatio", value.AsString()); }
            }

        /// <summary>
        /// Low-frequency to mid-frequency decay time ratio. 
        /// </summary>
        public float decayLFRatio
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".decayLFRatio").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".decayLFRatio", value.AsString()); }
            }

        /// <summary>
        /// Reverberation decay time at mid frequencies. 
        /// </summary>
        public float decayTime
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".decayTime").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".decayTime", value.AsString()); }
            }

        /// <summary>
        /// Value that controls the modal density in the late reverberation decay. 
        /// </summary>
        public float density
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".density").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".density", value.AsString()); }
            }

        /// <summary>
        /// Value that controls the echo density in the late reverberation decay. 
        /// </summary>
        public float diffusion
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".diffusion").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".diffusion", value.AsString()); }
            }

        /// <summary>
        /// Echo depth. 
        /// </summary>
        public float echoDepth
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".echoDepth").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".echoDepth", value.AsString()); }
            }

        /// <summary>
        /// Echo time. 
        /// </summary>
        public float echoTime
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".echoTime").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".echoTime", value.AsString()); }
            }

        /// <summary>
        /// Environment diffusion. 
        /// </summary>
        public float envDiffusion
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".envDiffusion").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".envDiffusion", value.AsString()); }
            }

        /// <summary>
        /// Environment size in meters. 
        /// </summary>
        public float envSize
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".envSize").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".envSize", value.AsString()); }
            }

        /// <summary>
        /// A bitfield of reverb flags.\n     @see REVERB_DECAYTIMESCALE\n     @see REVERB_REFLECTIONSSCALE\n     @see REVERB_REFLECTIONSDELAYSCALE\n     @see REVERB_REVERBSCALE\n     @see REVERB_REVERBDELAYSCALE\n     @see REVERB_DECAYHFLIMIT\n     @see REVERB_ECHOTIMESCALE\n     @see REVERB_MODULATIONTIMESCALE\n     @see REVERB_CORE0\n     @see REVERB_CORE1\n     @see REVERB_HIGHQUALITYREVERB\n     @see REVERB_HIGHQUALITYDPL2REVERB\n 
        /// </summary>
        public int flags
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".flags").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".flags", value.AsString()); }
            }

        /// <summary>
        /// Reference high frequency in Hertz. 
        /// </summary>
        public float HFReference
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".HFReference").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".HFReference", value.AsString()); }
            }

        /// <summary>
        /// Reference low frequency in Hertz. 
        /// </summary>
        public float LFReference
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".LFReference").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".LFReference", value.AsString()); }
            }

        /// <summary>
        /// Modulation depth. 
        /// </summary>
        public float modulationDepth
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".modulationDepth").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".modulationDepth", value.AsString()); }
            }

        /// <summary>
        /// Modulation time. 
        /// </summary>
        public float modulationTime
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".modulationTime").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".modulationTime", value.AsString()); }
            }

        /// <summary>
        /// Early reflections level relative to room effect. 
        /// </summary>
        public int reflections
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".reflections").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".reflections", value.AsString()); }
            }

        /// <summary>
        /// Initial reflection delay time. 
        /// </summary>
        public float reflectionsDelay
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".reflectionsDelay").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".reflectionsDelay", value.AsString()); }
            }

        /// <summary>
        /// Early reflections panning vector. 
        /// </summary>
        public float reflectionsPan
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".reflectionsPan").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".reflectionsPan", value.AsString()); }
            }

        /// <summary>
        /// Late reverberation level relative to room effect. 
        /// </summary>
        public int reverb
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".reverb").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".reverb", value.AsString()); }
            }

        /// <summary>
        /// Late reverberation delay time relative to initial reflection. 
        /// </summary>
        public float reverbDelay
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".reverbDelay").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".reverbDelay", value.AsString()); }
            }

        /// <summary>
        /// Late reverberation panning vector. 
        /// </summary>
        public float reverbPan
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".reverbPan").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".reverbPan", value.AsString()); }
            }

        /// <summary>
        /// Room effect level at mid-frequencies. 
        /// </summary>
        public int room
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".room").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".room", value.AsString()); }
            }

        /// <summary>
        /// Relative room effect level at high frequencies. 
        /// </summary>
        public int roomHF
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".roomHF").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".roomHF", value.AsString()); }
            }

        /// <summary>
        /// Relative room effect level at low frequencies. 
        /// </summary>
        public int roomLF
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".roomLF").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".roomLF", value.AsString()); }
            }

        /// <summary>
        /// Logarithmic distance attenuation rolloff scale factor for reverb room size effect. 
        /// </summary>
        public float roomRolloffFactor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".roomRolloffFactor").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".roomRolloffFactor", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coSFXEnvironment ts, string simobjectid)
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
        public static bool operator !=(coSFXEnvironment ts, string simobjectid)
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
        public static implicit operator string(coSFXEnvironment ts)
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
        public static implicit operator coSFXEnvironment(string ts)
            {
            return new coSFXEnvironment(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coSFXEnvironment ts)
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
        public static implicit operator coSFXEnvironment(int ts)
            {
            return new coSFXEnvironment(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coSFXEnvironment ts)
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
        public static implicit operator coSFXEnvironment(uint ts)
            {
            return new coSFXEnvironment(ts);
            }
        }
    }