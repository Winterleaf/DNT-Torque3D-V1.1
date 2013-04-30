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
using WinterLeaf.Enums;

#endregion

namespace WinterLeaf.tsObjects
    {
    /// <summary>
    /// 
    /// </summary>
    internal class tsObjectConvertercoPhysicsShapeData : TypeConverter
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
                return new coPhysicsShapeData(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoPhysicsShapeData))]
    public class coPhysicsShapeData : coGameBaseData
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coPhysicsShapeData(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coPhysicsShapeData(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coPhysicsShapeData(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// @brief Value that reduces an object's rotational velocity over time.\n\n     Larger values will cause velocity to decay quicker.\n\n 
        /// </summary>
        public float angularDamping
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".angularDamping").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".angularDamping", value.AsString()); }
            }

        /// <summary>
        /// @brief Minimum rotational velocity before the shape can be put to sleep.\n\n     This should be a positive value. Shapes put to sleep will not be simulated in order to save system resources.\n\n     @note The shape must be dynamic.
        /// </summary>
        public float angularSleepThreshold
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".angularSleepThreshold").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".angularSleepThreshold", value.AsString()); }
            }

        /// <summary>
        /// @brief The density of the shape for calculating buoyant forces.\n\n     The result of the calculated buoyancy is relative to the density of the WaterObject the PhysicsShape is within.\n\n     @see WaterObject::density
        /// </summary>
        public float buoyancyDensity
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".buoyancyDensity").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".buoyancyDensity", value.AsString()); }
            }

        /// <summary>
        /// @brief Name of a PhysicsDebrisData to spawn when this shape is destroyed (optional). 
        /// </summary>
        public coPhysicsDebrisData debris
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".debris"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".debris", value.ToString()); }
            }

        /// <summary>
        /// @brief Name of a PhysicsShapeData to spawn when this shape is destroyed (optional). 
        /// </summary>
        public coPhysicsShapeData destroyedShape
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".destroyedShape"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".destroyedShape", value.ToString()); }
            }

        /// <summary>
        /// @brief Name of an ExplosionData to spawn when this shape is destroyed (optional). 
        /// </summary>
        public coExplosionData explosion
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".explosion"); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".explosion", value.ToString()); }
            }

        /// <summary>
        /// @brief Coefficient of kinetic %friction to be applied to the shape.\n\n     Kinetic %friction reduces the velocity of a moving object while it is in contact with a surface.      A higher coefficient will result in a larger velocity reduction.      A shape's friction should be lower than it's staticFriction, but larger than 0.\n\n     @note This value is only applied while an object is in motion. For an object starting at rest, see PhysicsShape::staticFriction
        /// </summary>
        public float friction
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".friction").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".friction", value.AsString()); }
            }

        /// <summary>
        /// @brief Value that reduces an object's linear velocity over time.\n\n     Larger values will cause velocity to decay quicker.\n\n 
        /// </summary>
        public float linearDamping
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".linearDamping").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".linearDamping", value.AsString()); }
            }

        /// <summary>
        /// @brief Minimum linear velocity before the shape can be put to sleep.\n\n     This should be a positive value. Shapes put to sleep will not be simulated in order to save system resources.\n\n     @note The shape must be dynamic.
        /// </summary>
        public float linearSleepThreshold
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".linearSleepThreshold").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".linearSleepThreshold", value.AsString()); }
            }

        /// <summary>
        /// @brief Value representing the mass of the shape.\n\n     A shape's mass influences the magnitude of any force exerted on it.      For example, a PhysicsShape with a large mass requires a much larger force to move than      the same shape with a smaller mass.\n     @note A mass of zero will create a kinematic shape while anything greater will create a dynamic shape.
        /// </summary>
        public float mass
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".mass").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".mass", value.AsString()); }
            }

        /// <summary>
        /// @brief Coeffecient of a bounce applied to the shape in response to a collision.\n\n     Restitution is a ratio of a shape's velocity before and after a collision.      A value of 0 will zero out a shape's post-collision velocity, making it stop on contact.      Larger values will remove less velocity after a collision, making it \'bounce\' with a greater force.      Normal %restitution values range between 0 and 1.0.     @note Values near or equaling 1.0 are likely to cause undesirable results in the physics simulation.      Because of this it is reccomended to avoid values close to 1.0
        /// </summary>
        public float restitution
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".restitution").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".restitution", value.AsString()); }
            }

        /// <summary>
        /// @brief Path to the .DAE or .DTS file to use for this shape.\n\n     Compatable with Live-Asset Reloading. 
        /// </summary>
        public String shapeName
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".shapeName").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".shapeName", value.AsString()); }
            }

        /// <summary>
        /// @brief Controls whether this shape is simulated on the server, client, or both physics simulations.\n\n 
        /// </summary>
        public PhysicsShapeData__SimType simType
            {
            get { return (PhysicsShapeData__SimType) Enum.Parse(typeof (PhysicsShapeData__SimType), dnTorque.self.GetVar(_mSimObjectId + ".simType")); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".simType", value.ToString()); }
            }

        /// <summary>
        /// @brief Coefficient of static %friction to be applied to the shape.\n\n     Static %friction determines the force needed to start moving an at-rest object in contact with a surface.      If the force applied onto shape cannot overcome the force of static %friction, the shape will remain at rest.      A larger coefficient will require a larger force to start motion.      This value should be larger than zero and the physicsShape's friction.\n\n     @note This value is only applied while an object is at rest. For an object in motion, see PhysicsShape::friction
        /// </summary>
        public float staticFriction
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".staticFriction").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".staticFriction", value.AsString()); }
            }

        /// <summary>
        /// @brief Scale to apply to linear and angular dampening while underwater.\n\n      Used with the waterViscosity of the      @see angularDamping linearDamping 
        /// </summary>
        public float waterDampingScale
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".waterDampingScale").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".waterDampingScale", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coPhysicsShapeData ts, string simobjectid)
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
        public static bool operator !=(coPhysicsShapeData ts, string simobjectid)
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
        public static implicit operator string(coPhysicsShapeData ts)
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
        public static implicit operator coPhysicsShapeData(string ts)
            {
            return new coPhysicsShapeData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coPhysicsShapeData ts)
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
        public static implicit operator coPhysicsShapeData(int ts)
            {
            return new coPhysicsShapeData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coPhysicsShapeData ts)
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
        public static implicit operator coPhysicsShapeData(uint ts)
            {
            return new coPhysicsShapeData(ts);
            }
        }
    }