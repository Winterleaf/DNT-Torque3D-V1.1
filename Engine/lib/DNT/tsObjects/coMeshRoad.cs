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
    internal class tsObjectConvertercoMeshRoad : TypeConverter
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
                return new coMeshRoad(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoMeshRoad))]
    public class coMeshRoad : coSceneObject
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coMeshRoad(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coMeshRoad(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coMeshRoad(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// Material for the bottom surface of the road. 
        /// </summary>
        public String bottomMaterial
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".bottomMaterial").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".bottomMaterial", value.AsString()); }
            }

        /// <summary>
        /// Angle in degrees - MeshRoad will subdivide the spline if its curve is greater than this threshold. 
        /// </summary>
        public float breakAngle
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".breakAngle").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".breakAngle", value.AsString()); }
            }

        /// <summary>
        /// Do not modify, for internal use. 
        /// </summary>
        public String Node
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".Node").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".Node", value.AsString()); }
            }

        /// <summary>
        /// Material for the left, right, front, and back surfaces of the road. 
        /// </summary>
        public String sideMaterial
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".sideMaterial").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".sideMaterial", value.AsString()); }
            }

        /// <summary>
        /// The length in meters of textures mapped to the MeshRoad. 
        /// </summary>
        public float textureLength
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".textureLength").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".textureLength", value.AsString()); }
            }

        /// <summary>
        /// Material for the upper surface of the road. 
        /// </summary>
        public String topMaterial
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".topMaterial").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".topMaterial", value.AsString()); }
            }

        /// <summary>
        /// Subdivide segments widthwise this many times when generating vertices. 
        /// </summary>
        public int widthSubdivisions
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".widthSubdivisions").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".widthSubdivisions", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coMeshRoad ts, string simobjectid)
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
        public static bool operator !=(coMeshRoad ts, string simobjectid)
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
        public static implicit operator string(coMeshRoad ts)
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
        public static implicit operator coMeshRoad(string ts)
            {
            return new coMeshRoad(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coMeshRoad ts)
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
        public static implicit operator coMeshRoad(int ts)
            {
            return new coMeshRoad(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coMeshRoad ts)
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
        public static implicit operator coMeshRoad(uint ts)
            {
            return new coMeshRoad(ts);
            }

        /// <summary>
        /// Intended as a helper to developers and editor scripts.
        ///                    Force trigger an inspectPostApply. This will transmit 
        ///                    material and other fields ( not including nodes ) to client objects.
        ///                    )
        /// 
        /// </summary>
        public void postApply()
            {
            TorqueScriptTemplate.m_ts.fnMeshRoad_postApply(_mSimObjectId);
            }

        /// <summary>
        /// Intended as a helper to developers and editor scripts.
        ///                    Force MeshRoad to recreate its geometry.
        ///                    )
        /// 
        /// </summary>
        public void regenerate()
            {
            TorqueScriptTemplate.m_ts.fnMeshRoad_regenerate(_mSimObjectId);
            }

        /// <summary>
        /// Intended as a helper to developers and editor scripts.
        ///                    Sets the depth in meters of a particular node.
        ///                    )
        /// 
        /// </summary>
        public void setNodeDepth(int idx, float meters)
            {
            TorqueScriptTemplate.m_ts.fnMeshRoad_setNodeDepth(_mSimObjectId, idx, meters);
            }
        }
    }