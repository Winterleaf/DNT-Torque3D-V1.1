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
    internal class tsObjectConvertercoSimSet : TypeConverter
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
                return new coSimSet(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoSimSet))]
    public class coSimSet : coSimObject
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coSimSet(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coSimSet(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coSimSet(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coSimSet ts, string simobjectid)
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
        public static bool operator !=(coSimSet ts, string simobjectid)
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
        public static implicit operator string(coSimSet ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSimSet(string ts)
            {
            return new coSimSet(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coSimSet ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSimSet(int ts)
            {
            return new coSimSet(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coSimSet ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSimSet(uint ts)
            {
            return new coSimSet(ts);
            }

        /// <summary>
        /// Test whether the given object may be added to the set.
        ///    @param obj The object to test for potential membership.
        ///    @return True if the object may be added to the set, false otherwise. )
        /// 
        /// </summary>
        public bool acceptsAsChild(string obj)
            {
            return TorqueScriptTemplate.m_ts.fnSimSet_acceptsAsChild(_mSimObjectId, obj);
            }

        /// <summary>
        /// ( SimSet, add, void, 3, 0,
        ///    ( SimObject objects... ) Add the given objects to the set.
        ///    @param objects The objects to add to the set. )
        /// 
        /// </summary>
        public void add(string a2, string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "")
            {
            TorqueScriptTemplate.m_ts.fnSimSet_add(_mSimObjectId, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
            }

        /// <summary>
        /// Make the given object the first object in the set.
        ///    @param obj The object to bring to the frontmost position.  Must be contained in the set. )
        /// 
        /// </summary>
        public void bringToFront(string obj)
            {
            TorqueScriptTemplate.m_ts.fnSimSet_bringToFront(_mSimObjectId, obj);
            }

        /// <summary>
        /// ( SimSet, callOnChildren, void, 3, 0,
        ///    ( string method, string args... ) Call a method on all objects contained in the set.
        ///    @param method The name of the method to call.
        ///    @param args The arguments to the method.
        ///    @note This method recurses into all SimSets that are children to the set.
        ///    @see callOnChildrenNoRecurse )
        /// 
        /// </summary>
        public void callOnChildren(string a2, string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "")
            {
            TorqueScriptTemplate.m_ts.fnSimSet_callOnChildren(_mSimObjectId, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
            }

        /// <summary>
        /// ( SimSet, callOnChildrenNoRecurse, void, 3, 0,
        ///    ( string method, string args... ) Call a method on all objects contained in the set.
        ///    @param method The name of the method to call.
        ///    @param args The arguments to the method.
        ///    @note This method does not recurse into child SimSets.
        ///    @see callOnChildren )
        /// 
        /// </summary>
        public void callOnChildrenNoRecurse(string a2, string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "")
            {
            TorqueScriptTemplate.m_ts.fnSimSet_callOnChildrenNoRecurse(_mSimObjectId, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
            }

        /// <summary>
        /// Remove all objects from the set. )
        /// 
        /// </summary>
        public void clear()
            {
            TorqueScriptTemplate.m_ts.fnSimSet_clear(_mSimObjectId);
            }

        /// <summary>
        /// ( SimSet, deleteAllObjects, void, 2, 2, () Delete all objects in the set. )
        /// 
        /// </summary>
        public void deleteAllObjects()
            {
            TorqueScriptTemplate.m_ts.fnSimSet_deleteAllObjects(_mSimObjectId);
            }

        /// <summary>
        /// Find an object in the set by its internal name.
        ///    @param internalName The internal name of the object to look for.
        ///    @param searchChildren If true, SimSets contained in the set will be recursively searched for the object.
        ///    @return The object with the given internal name or 0 if no match was found. )
        /// 
        /// </summary>
        public string findObjectByInternalName(string internalName, bool searchChildren)
            {
            return TorqueScriptTemplate.m_ts.fnSimSet_findObjectByInternalName(_mSimObjectId, internalName, searchChildren);
            }

        /// <summary>
        /// Get the number of objects contained in the set.
        ///    @return The number of objects contained in the set. )
        /// 
        /// </summary>
        public int getCount()
            {
            return TorqueScriptTemplate.m_ts.fnSimSet_getCount(_mSimObjectId);
            }

        /// <summary>
        /// ( SimSet, getFullCount, S32, 2, 2, () Get the number of direct and indirect child objects contained in the set.
        ///    @return The number of objects contained in the set as well as in other sets contained directly or indirectly in the set. )
        /// 
        /// </summary>
        public int getFullCount()
            {
            return TorqueScriptTemplate.m_ts.fnSimSet_getFullCount(_mSimObjectId);
            }

        /// <summary>
        /// Get the object at the given index.
        ///    @param index The object index.
        ///    @return The object at the given index or -1 if index is out of range. )
        /// 
        /// </summary>
        public string getObject(uint index)
            {
            return TorqueScriptTemplate.m_ts.fnSimSet_getObject(_mSimObjectId, index);
            }

        /// <summary>
        /// Return the index of the given object in this set.
        ///    @param obj The object for which to return the index.  Must be contained in the set.
        ///    @return The index of the object or -1 if the object is not contained in the set. )
        /// 
        /// </summary>
        public int getObjectIndex(string obj)
            {
            return TorqueScriptTemplate.m_ts.fnSimSet_getObjectIndex(_mSimObjectId, obj);
            }

        /// <summary>
        /// Return a random object from the set.
        ///    @return A randomly selected object from the set or -1 if the set is empty. )
        /// 
        /// </summary>
        public string getRandom()
            {
            return TorqueScriptTemplate.m_ts.fnSimSet_getRandom(_mSimObjectId);
            }

        /// <summary>
        /// Test whether the given object belongs to the set.
        ///    @param obj The object.
        ///    @return True if the object is contained in the set; false otherwise. )
        /// 
        /// </summary>
        public bool isMember(string obj)
            {
            return TorqueScriptTemplate.m_ts.fnSimSet_isMember(_mSimObjectId, obj);
            }

        /// <summary>
        /// Dump a list of all objects contained in the set to the console. )
        /// 
        /// </summary>
        public void listObjects()
            {
            TorqueScriptTemplate.m_ts.fnSimSet_listObjects(_mSimObjectId);
            }

        /// <summary>
        /// Make the given object the last object in the set.
        ///    @param obj The object to bring to the last position.  Must be contained in the set. )
        /// 
        /// </summary>
        public void pushToBack(string obj)
            {
            TorqueScriptTemplate.m_ts.fnSimSet_pushToBack(_mSimObjectId, obj);
            }

        /// <summary>
        /// ( SimSet, remove, void, 3, 0,
        ///    ( SimObject objects... ) Remove the given objects from the set.
        ///    @param objects The objects to remove from the set. )
        /// 
        /// </summary>
        public void remove(string a2, string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "")
            {
            TorqueScriptTemplate.m_ts.fnSimSet_remove(_mSimObjectId, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
            }

        /// <summary>
        /// Make sure child1 is ordered right before child2 in the set.
        ///    @param child1 The first child.  The object must already be contained in the set.
        ///    @param child2 The second child.  The object must already be contained in the set. )
        /// 
        /// </summary>
        public void reorderChild(string child1, string child2)
            {
            TorqueScriptTemplate.m_ts.fnSimSet_reorderChild(_mSimObjectId, child1, child2);
            }

        /// <summary>
        /// ( SimSet, sort, void, 3, 3, ( string callbackFunction ) Sort the objects in the set using the given comparison function.
        ///    @param callbackFunction Name of a function that takes two object arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal. )
        /// 
        /// </summary>
        public void sort(string a2)
            {
            TorqueScriptTemplate.m_ts.fnSimSet_sort(_mSimObjectId, a2);
            }
        }
    }