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
    internal class tsObjectConvertercoGuiTSCtrl : TypeConverter
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
                return new coGuiTSCtrl(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiTSCtrl))]
    public class coGuiTSCtrl : coGuiContainer
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiTSCtrl(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiTSCtrl(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiTSCtrl(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// Z rotation angle of camera. 
        /// </summary>
        public float cameraZRot
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".cameraZRot").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".cameraZRot", value.AsString()); }
            }

        /// <summary>
        /// The vertical field of view in degrees or zero to use the normal camera FOV. 
        /// </summary>
        public float forceFOV
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".forceFOV").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".forceFOV", value.AsString()); }
            }

        /// <summary>
        /// The share of the per-frame reflection update work this control's rendering should run.\n     The reflect update priorities of all visible GuiTSCtrls are added together and each control is assigned      a share of the per-frame reflection update time according to its percentage of the total priority value. 
        /// </summary>
        public float reflectPriority
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".reflectPriority").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".reflectPriority", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiTSCtrl ts, string simobjectid)
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
        public static bool operator !=(coGuiTSCtrl ts, string simobjectid)
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
        public static implicit operator string(coGuiTSCtrl ts)
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
        public static implicit operator coGuiTSCtrl(string ts)
            {
            return new coGuiTSCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiTSCtrl ts)
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
        public static implicit operator coGuiTSCtrl(int ts)
            {
            return new coGuiTSCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiTSCtrl ts)
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
        public static implicit operator coGuiTSCtrl(uint ts)
            {
            return new coGuiTSCtrl(ts);
            }

        /// <summary>
        /// Given the camera's current FOV, get the distance from the camera's viewpoint at which the given radius will fit in the render area.
        ///    @param radius Radius in world-space units which should fit in the view.
        ///    @return The distance from the viewpoint at which the given radius would be fully visible. )
        /// 
        /// </summary>
        public float calculateViewDistance(float radius)
            {
            return TorqueScriptTemplate.m_ts.fnGuiTSCtrl_calculateViewDistance(_mSimObjectId, radius);
            }

        /// <summary>
        /// Get the ratio between world-space units and pixels.
        ///    @return The amount of world-space units covered by the extent of a single pixel. )
        /// 
        /// </summary>
        public Point2F getWorldToScreenScale()
            {
            return new Point2F(TorqueScriptTemplate.m_ts.fnGuiTSCtrl_getWorldToScreenScale(_mSimObjectId));
            }

        /// <summary>
        /// Transform world-space coordinates to screen-space (x, y, depth) coordinates.
        ///    @param worldPosition The world-space position to transform to screen-space.
        ///    @return The  )
        /// 
        /// </summary>
        public Point3F project(Point3F worldPosition)
            {
            return new Point3F(TorqueScriptTemplate.m_ts.fnGuiTSCtrl_project(_mSimObjectId, worldPosition.AsString()));
            }

        /// <summary>
        /// Transform 3D screen-space coordinates (x, y, depth) to world space.
        ///    This method can be, for example, used to find the world-space position relating to the current mouse cursor position.
        ///    @param screenPosition The x/y position on the screen plus the depth from the screen-plane outwards.
        ///    @return The world-space position corresponding to the given screen-space coordinates. )
        /// 
        /// </summary>
        public Point3F unproject(Point3F screenPosition)
            {
            return new Point3F(TorqueScriptTemplate.m_ts.fnGuiTSCtrl_unproject(_mSimObjectId, screenPosition.AsString()));
            }
        }
    }