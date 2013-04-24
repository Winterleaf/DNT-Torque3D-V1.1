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
    internal class tsObjectConvertercoAITurretShapeData : TypeConverter
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
                return new coAITurretShapeData(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoAITurretShapeData))]
    public class coAITurretShapeData : coTurretShapeData
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coAITurretShapeData(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coAITurretShapeData(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coAITurretShapeData(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// @brief Maximum distance to scan.\n\n   When combined with maxScanHeading and maxScanPitch this forms a 3D scanning wedge used to initially    locate a target.\n
        /// </summary>
        public float maxScanDistance
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".maxScanDistance").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxScanDistance", value.AsString()); }
            }

        /// <summary>
        /// @brief Maximum number of degrees to scan left and right.\n\n   @note Maximum scan heading is 90 degrees.\n
        /// </summary>
        public float maxScanHeading
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".maxScanHeading").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxScanHeading", value.AsString()); }
            }

        /// <summary>
        /// @brief Maximum number of degrees to scan up and down.\n\n   @note Maximum scan pitch is 90 degrees.\n
        /// </summary>
        public float maxScanPitch
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".maxScanPitch").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxScanPitch", value.AsString()); }
            }

        /// <summary>
        /// @brief Maximum distance that the weapon will fire upon a target.\n\n
        /// </summary>
        public float maxWeaponRange
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".maxWeaponRange").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxWeaponRange", value.AsString()); }
            }

        /// <summary>
        /// @brief How often should we perform a full scan when looking for a target.\n\n   Expressed as the number of ticks between full scans, but no less than 1.\n
        /// </summary>
        public int scanTickFrequency
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".scanTickFrequency").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".scanTickFrequency", value.AsString()); }
            }

        /// <summary>
        /// @brief Random amount that should be added to the scan tick frequency each scan period.\n\n   Expressed as the number of ticks to randomly add, but no less than zero.\n
        /// </summary>
        public int scanTickFrequencyVariance
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".scanTickFrequencyVariance").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".scanTickFrequencyVariance", value.AsString()); }
            }

        /// <summary>
        /// @brief Direction of the animation to play in this state.\n\n     True is forward, false is backward. 
        /// </summary>
        public bool stateDirection
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateDirection").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateDirection", value.AsString()); }
            }

        /// <summary>
        /// The first state with this set to true is the state entered by the      client when it receives the 'fire' event. 
        /// </summary>
        public bool stateFire
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateFire").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateFire", value.AsString()); }
            }

        /// <summary>
        /// Name of this state. 
        /// </summary>
        public String stateName
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateName").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateName", value.AsString()); }
            }

        /// <summary>
        /// If true, the timeScale of the stateSequence animation will be adjusted      such that the sequence plays for stateTimeoutValue seconds.  
        /// </summary>
        public bool stateScaleAnimation
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateScaleAnimation").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateScaleAnimation", value.AsString()); }
            }

        /// <summary>
        /// Indicates the turret should perform a continuous scan looking for targets. 
        /// </summary>
        public bool stateScan
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateScan").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateScan", value.AsString()); }
            }

        /// <summary>
        /// @brief Method to execute on entering this state.\n\n     Scoped to AITurretShapeData.
        /// </summary>
        public String stateScript
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateScript").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateScript", value.AsString()); }
            }

        /// <summary>
        /// Name of the sequence to play on entry to this state. 
        /// </summary>
        public String stateSequence
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateSequence").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateSequence", value.AsString()); }
            }

        /// <summary>
        /// Time in seconds to wait before transitioning to stateTransitionOnTimeout. 
        /// </summary>
        public float stateTimeoutValue
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateTimeoutValue").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateTimeoutValue", value.AsString()); }
            }

        /// <summary>
        /// Name of the state to transition to when the turret goes from deactivated to activated.
        /// </summary>
        public String stateTransitionOnActivated
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateTransitionOnActivated").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateTransitionOnActivated", value.AsString()); }
            }

        /// <summary>
        /// Name of the state to transition to when the turret is at rest (static).
        /// </summary>
        public String stateTransitionOnAtRest
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateTransitionOnAtRest").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateTransitionOnAtRest", value.AsString()); }
            }

        /// <summary>
        /// Name of the state to transition to when the turret goes from activated to deactivated
        /// </summary>
        public String stateTransitionOnDeactivated
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateTransitionOnDeactivated").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateTransitionOnDeactivated", value.AsString()); }
            }

        /// <summary>
        /// Name of the state to transition to when the turret loses a target. 
        /// </summary>
        public String stateTransitionOnNoTarget
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateTransitionOnNoTarget").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateTransitionOnNoTarget", value.AsString()); }
            }

        /// <summary>
        /// Name of the state to transition to when the turret is not at rest (not static).
        /// </summary>
        public String stateTransitionOnNotAtRest
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateTransitionOnNotAtRest").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateTransitionOnNotAtRest", value.AsString()); }
            }

        /// <summary>
        /// Name of the state to transition to when the turret gains a target. 
        /// </summary>
        public String stateTransitionOnTarget
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateTransitionOnTarget").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateTransitionOnTarget", value.AsString()); }
            }

        /// <summary>
        /// Name of the state to transition to when we have been in this state      for stateTimeoutValue seconds. 
        /// </summary>
        public String stateTransitionOnTimeout
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateTransitionOnTimeout").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateTransitionOnTimeout", value.AsString()); }
            }

        /// <summary>
        /// If false, this state ignores stateTimeoutValue and transitions      immediately if other transition conditions are met. 
        /// </summary>
        public bool stateWaitForTimeout
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".stateWaitForTimeout").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".stateWaitForTimeout", value.AsString()); }
            }

        /// <summary>
        /// @brief How long after the turret has lost the target should it still track it.\n\n   Expressed in seconds.\n
        /// </summary>
        public float trackLostTargetTime
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".trackLostTargetTime").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".trackLostTargetTime", value.AsString()); }
            }

        /// <summary>
        /// @brief Velocity used to lead target.\n\n   If value = 0, don't lead target.\n
        /// </summary>
        public float weaponLeadVelocity
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".weaponLeadVelocity").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".weaponLeadVelocity", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coAITurretShapeData ts, string simobjectid)
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
        public static bool operator !=(coAITurretShapeData ts, string simobjectid)
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
        public static implicit operator string(coAITurretShapeData ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coAITurretShapeData(string ts)
            {
            return new coAITurretShapeData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coAITurretShapeData ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coAITurretShapeData(int ts)
            {
            return new coAITurretShapeData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coAITurretShapeData ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coAITurretShapeData(uint ts)
            {
            return new coAITurretShapeData(ts);
            }
        }
    }