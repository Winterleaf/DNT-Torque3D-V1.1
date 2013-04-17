
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
    internal class tsObjectConvertercoPostEffect : TypeConverter
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
                return new coPostEffect(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoPostEffect))]
    public class coPostEffect: coSimGroup
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coPostEffect(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coPostEffect(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coPostEffect(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coPostEffect ts, string simobjectid)
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
        public static bool operator !=(coPostEffect ts, string simobjectid)
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
        public static implicit operator string( coPostEffect ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coPostEffect(string ts)
            {
            return new coPostEffect(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coPostEffect ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coPostEffect(int ts)
            {
            return new coPostEffect(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coPostEffect ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coPostEffect(uint ts)
            {
            return new coPostEffect(ts);
            }
public bool allowReflectPass
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".allowReflectPass").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".allowReflectPass", value.AsString());
          }
       }
public bool isEnabled
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".isEnabled").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".isEnabled", value.AsString());
          }
       }
public bool oneFrameOnly
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".oneFrameOnly").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".oneFrameOnly", value.AsString());
          }
       }
public bool onThisFrame
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".onThisFrame").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".onThisFrame", value.AsString());
          }
       }
public String renderBin
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderBin").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderBin", value.AsString());
          }
       }
public float renderPriority
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderPriority").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderPriority", value.AsString());
          }
       }
public PFXRenderTime renderTime
       {
       get
          {          return (PFXRenderTime)Enum.Parse(typeof(PFXRenderTime), dnTorque.self.GetVar(_mSimObjectId + ".renderTime"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderTime", value.ToString());
          }
       }
public String shader
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".shader").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".shader", value.AsString());
          }
       }
public bool skip
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".skip").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".skip", value.AsString());
          }
       }
public coGFXStateBlockData stateBlock
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".stateBlock");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".stateBlock", value.ToString());
          }
       }
public String target
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".target").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".target", value.AsString());
          }
       }
public PFXTargetClear targetClear
       {
       get
          {          return (PFXTargetClear)Enum.Parse(typeof(PFXTargetClear), dnTorque.self.GetVar(_mSimObjectId + ".targetClear"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".targetClear", value.ToString());
          }
       }
public ColorF targetClearColor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".targetClearColor").AsColorF();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".targetClearColor", value.AsString());
          }
       }
public String targetDepthStencil
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".targetDepthStencil").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".targetDepthStencil", value.AsString());
          }
       }
public TypeGFXFormat targetFormat
       {
       get
          {          return (TypeGFXFormat)Enum.Parse(typeof(TypeGFXFormat), dnTorque.self.GetVar(_mSimObjectId + ".targetFormat"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".targetFormat", value.ToString());
          }
       }
public Point2F targetScale
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".targetScale").AsPoint2F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".targetScale", value.AsString());
          }
       }
public Point2I targetSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".targetSize").AsPoint2I();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".targetSize", value.AsString());
          }
       }
public String texture
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".texture").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".texture", value.AsString());
          }
       }
/// <summary>
/// Remove all shader macros. )
/// 
/// </summary>
public  void clearShaderMacros(){
TorqueScriptTemplate.m_ts.fnPostEffect_clearShaderMacros(_mSimObjectId);
}
/// <summary>
/// Disables the effect. )
/// 
/// </summary>
public  void disable(){
TorqueScriptTemplate.m_ts.fnPostEffect_disable(_mSimObjectId);
}
/// <summary>
/// Dumps this PostEffect shader's disassembly to a temporary text file.
///    @return Full path to the dumped file or an empty string if failed. )
/// 
/// </summary>
public  string dumpShaderDisassembly(){
return TorqueScriptTemplate.m_ts.fnPostEffect_dumpShaderDisassembly(_mSimObjectId);
}
/// <summary>
/// Enables the effect. )
/// 
/// </summary>
public  void enable(){
TorqueScriptTemplate.m_ts.fnPostEffect_enable(_mSimObjectId);
}
/// <summary>
/// @return Width over height of the backbuffer. )
/// 
/// </summary>
public  float getAspectRatio(){
return TorqueScriptTemplate.m_ts.fnPostEffect_getAspectRatio(_mSimObjectId);
}
/// <summary>
/// @return True if the effect is enabled. )
/// 
/// </summary>
public  bool GetEnabled(){
return TorqueScriptTemplate.m_ts.fnPostEffect_GetEnabled(_mSimObjectId);
}
/// <summary>
/// Reloads the effect shader and textures. )
/// 
/// </summary>
public  void reload(){
TorqueScriptTemplate.m_ts.fnPostEffect_reload(_mSimObjectId);
}
/// <summary>
/// Remove a shader macro. This will usually be called within the preProcess callback.
///    @param key Macro to remove. )
/// 
/// </summary>
public  void removeShaderMacro(string key){
TorqueScriptTemplate.m_ts.fnPostEffect_removeShaderMacro(_mSimObjectId, key);
}
/// <summary>
/// Sets the value of a uniform defined in the shader. This will usually 
///    be called within the setShaderConsts callback. Array type constants are 
///    not supported.    
///    @param name Name of the constanst, prefixed with '$'. 
///    @param value Value to set, space seperate values with more than one element.
///    @tsexample
///    function MyPfx::setShaderConsts( %this )
///    {
///       // example float4 uniform
///       %this.setShaderConst( \"$colorMod\", \"1.0 0.9 1.0 1.0\" );
///       // example float1 uniform
///       %this.setShaderConst( \"$strength\", \"3.0\" );
///       // example integer uniform
///       %this.setShaderConst( \"$loops\", \"5\" );
///    }
///    @endtsexample )   
/// 
/// </summary>
public  void setShaderConst(string name, string value){
TorqueScriptTemplate.m_ts.fnPostEffect_setShaderConst(_mSimObjectId, name, value);
}
/// <summary>
///  ),
///    Adds a macro to the effect's shader or sets an existing one's value. 
///    This will usually be called within the onAdd or preProcess callback.
///    @param key lval of the macro.
///    @param value rval of the macro, or may be empty.
///    @tsexample
///    function MyPfx::onAdd( %this )
///    {
///       %this.setShaderMacro( \"NUM_SAMPLES\", \"10\" );
///       %this.setShaderMacro( \"HIGH_QUALITY_MODE\" );
///       
///       // In the shader looks like... 
///       // #define NUM_SAMPLES 10
///       // #define HIGH_QUALITY_MODE
///    }
///    @endtsexample )
/// 
/// </summary>
public  void setShaderMacro(string key, string value){
TorqueScriptTemplate.m_ts.fnPostEffect_setShaderMacro(_mSimObjectId, key, value);
}
/// <summary>
/// This is used to set the texture file and load the texture on a running effect. 
///    If the texture file is not different from the current file nothing is changed.  If 
///    the texture cannot be found a null texture is assigned.    
///    @param index The texture stage index. 
///    @param filePath The file name of the texture to set. )
/// 
/// </summary>
public  void setTexture(int index, string filePath){
TorqueScriptTemplate.m_ts.fnPostEffect_setTexture(_mSimObjectId, index, filePath);
}
/// <summary>
/// Toggles the effect between enabled / disabled.
///    @return True if effect is enabled. )
/// 
/// </summary>
public  bool toggle(){
return TorqueScriptTemplate.m_ts.fnPostEffect_toggle(_mSimObjectId);
}
}}