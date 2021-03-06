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
    internal class tsObjectConvertercoPersistenceManager : TypeConverter
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
                return new coPersistenceManager(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoPersistenceManager))]
    public class coPersistenceManager : coSimObject
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coPersistenceManager(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coPersistenceManager(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coPersistenceManager(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coPersistenceManager ts, string simobjectid)
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
        public static bool operator !=(coPersistenceManager ts, string simobjectid)
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
        public static implicit operator string(coPersistenceManager ts)
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
        public static implicit operator coPersistenceManager(string ts)
            {
            return new coPersistenceManager(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coPersistenceManager ts)
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
        public static implicit operator coPersistenceManager(int ts)
            {
            return new coPersistenceManager(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coPersistenceManager ts)
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
        public static implicit operator coPersistenceManager(uint ts)
            {
            return new coPersistenceManager(ts);
            }

        /// <summary>
        /// ( PersistenceManager, clearAll, void, 2, 2, ()
        ///               Clears all the tracked objects without saving them. )
        /// 
        /// </summary>
        public void clearAll()
            {
            TorqueScriptTemplate.m_ts.fnPersistenceManager_clearAll(_mSimObjectId);
            }

        /// <summary>
        /// ( PersistenceManager, deleteObjectsFromFile, void, 3, 3, ( fileName )
        ///               Delete all of the objects that are created from the given file. )
        /// 
        /// </summary>
        public void deleteObjectsFromFile(string a2)
            {
            TorqueScriptTemplate.m_ts.fnPersistenceManager_deleteObjectsFromFile(_mSimObjectId, a2);
            }

        /// <summary>
        /// ( PersistenceManager, getDirtyObject, S32, 3, 3, ( index )
        ///               Returns the ith dirty object. )
        /// 
        /// </summary>
        public int getDirtyObject(string a2)
            {
            return TorqueScriptTemplate.m_ts.fnPersistenceManager_getDirtyObject(_mSimObjectId, a2);
            }

        /// <summary>
        /// ( PersistenceManager, getDirtyObjectCount, S32, 2, 2, ()
        ///               Returns the number of dirty objects. )
        /// 
        /// </summary>
        public int getDirtyObjectCount()
            {
            return TorqueScriptTemplate.m_ts.fnPersistenceManager_getDirtyObjectCount(_mSimObjectId);
            }

        /// <summary>
        /// ( PersistenceManager, hasDirty, bool, 2, 2, ()
        ///               Returns true if the manager has dirty objects to save. )
        /// 
        /// </summary>
        public bool hasDirty()
            {
            return TorqueScriptTemplate.m_ts.fnPersistenceManager_hasDirty(_mSimObjectId);
            }

        /// <summary>
        /// ( PersistenceManager, isDirty, bool, 3, 3, (SimObject object)
        ///               Returns true if the SimObject is on the dirty list.)
        /// 
        /// </summary>
        public bool isDirty(string a2)
            {
            return TorqueScriptTemplate.m_ts.fnPersistenceManager_isDirty(_mSimObjectId, a2);
            }

        /// <summary>
        /// ( PersistenceManager, listDirty, void, 2, 2, ()
        ///               Prints the dirty list to the console.)
        /// 
        /// </summary>
        public void listDirty()
            {
            TorqueScriptTemplate.m_ts.fnPersistenceManager_listDirty(_mSimObjectId);
            }

        /// <summary>
        /// ( PersistenceManager, removeDirty, void, 3, 3, (SimObject object)
        ///               Remove a SimObject from the dirty list.)
        /// 
        /// </summary>
        public void removeDirty(string a2)
            {
            TorqueScriptTemplate.m_ts.fnPersistenceManager_removeDirty(_mSimObjectId, a2);
            }

        /// <summary>
        /// ( PersistenceManager, removeField, void, 4, 4, (SimObject object, string fieldName)
        ///               Remove a specific field from an object declaration.)
        /// 
        /// </summary>
        public void removeField(string a2, string a3)
            {
            TorqueScriptTemplate.m_ts.fnPersistenceManager_removeField(_mSimObjectId, a2, a3);
            }

        /// <summary>
        /// ( PersistenceManager, removeObjectFromFile, void, 3, 4, (SimObject object, [filename])
        ///               Remove an existing SimObject from a file (can optionally specify a different file than \
        ///                the one it was created in.)
        /// 
        /// </summary>
        public void removeObjectFromFile(string a2, string a3 = "")
            {
            TorqueScriptTemplate.m_ts.fnPersistenceManager_removeObjectFromFile(_mSimObjectId, a2, a3);
            }

        /// <summary>
        /// ( PersistenceManager, saveDirty, bool, 2, 2, ()
        ///               Saves all of the SimObject's on the dirty list to their respective files.)
        /// 
        /// </summary>
        public bool saveDirty()
            {
            return TorqueScriptTemplate.m_ts.fnPersistenceManager_saveDirty(_mSimObjectId);
            }

        /// <summary>
        /// ( PersistenceManager, saveDirtyObject, bool, 3, 3, (SimObject object)
        ///               Save a dirty SimObject to it's file.)
        /// 
        /// </summary>
        public bool saveDirtyObject(string a2)
            {
            return TorqueScriptTemplate.m_ts.fnPersistenceManager_saveDirtyObject(_mSimObjectId, a2);
            }

        /// <summary>
        /// ( PersistenceManager, setDirty, void, 3, 4, (SimObject object, [filename])
        ///               Mark an existing SimObject as dirty (will be written out when saveDirty() is called).)
        /// 
        /// </summary>
        public void setDirty(string a2, string a3 = "")
            {
            TorqueScriptTemplate.m_ts.fnPersistenceManager_setDirty(_mSimObjectId, a2, a3);
            }
        }
    }