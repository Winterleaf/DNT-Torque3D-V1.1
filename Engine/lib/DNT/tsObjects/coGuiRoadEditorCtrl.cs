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
    internal class tsObjectConvertercoGuiRoadEditorCtrl : TypeConverter
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
                return new coGuiRoadEditorCtrl(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiRoadEditorCtrl))]
    public class coGuiRoadEditorCtrl : coEditTSCtrl
        {
        private ColorI _HoverNodeColor;
        private ColorI _HoverSplineColor;
        private ColorI _SelectedSplineColor;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiRoadEditorCtrl(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiRoadEditorCtrl(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiRoadEditorCtrl(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        public float DefaultWidth
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".DefaultWidth").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".DefaultWidth", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public ColorI HoverNodeColor
            {
            get
                {
                if (_HoverNodeColor != null)
                    _HoverNodeColor.DetachAllEvents();
                _HoverNodeColor = dnTorque.self.GetVar(_mSimObjectId + ".HoverNodeColor").AsColorI();
                _HoverNodeColor.OnChangeNotification += _HoverNodeColor_OnChangeNotification;
                return _HoverNodeColor;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".HoverNodeColor", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public ColorI HoverSplineColor
            {
            get
                {
                if (_HoverSplineColor != null)
                    _HoverSplineColor.DetachAllEvents();
                _HoverSplineColor = dnTorque.self.GetVar(_mSimObjectId + ".HoverSplineColor").AsColorI();
                _HoverSplineColor.OnChangeNotification += _HoverSplineColor_OnChangeNotification;
                return _HoverSplineColor;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".HoverSplineColor", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public bool isDirty
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".isDirty").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".isDirty", value.AsString()); }
            }

        /// <summary>
        /// Default Material used by the Road Editor on road creation. 
        /// </summary>
        public String materialName
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".materialName").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".materialName", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        public ColorI SelectedSplineColor
            {
            get
                {
                if (_SelectedSplineColor != null)
                    _SelectedSplineColor.DetachAllEvents();
                _SelectedSplineColor = dnTorque.self.GetVar(_mSimObjectId + ".SelectedSplineColor").AsColorI();
                _SelectedSplineColor.OnChangeNotification += _SelectedSplineColor_OnChangeNotification;
                return _SelectedSplineColor;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".SelectedSplineColor", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiRoadEditorCtrl ts, string simobjectid)
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
        public static bool operator !=(coGuiRoadEditorCtrl ts, string simobjectid)
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
        public static implicit operator string(coGuiRoadEditorCtrl ts)
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
        public static implicit operator coGuiRoadEditorCtrl(string ts)
            {
            return new coGuiRoadEditorCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiRoadEditorCtrl ts)
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
        public static implicit operator coGuiRoadEditorCtrl(int ts)
            {
            return new coGuiRoadEditorCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiRoadEditorCtrl ts)
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
        public static implicit operator coGuiRoadEditorCtrl(uint ts)
            {
            return new coGuiRoadEditorCtrl(ts);
            }

        private void _HoverNodeColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".HoverNodeColor", e.NewValue);
            }

        private void _HoverSplineColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".HoverSplineColor", e.NewValue);
            }

        private void _SelectedSplineColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".SelectedSplineColor", e.NewValue);
            }

        /// <summary>
        /// ( GuiRoadEditorCtrl, deleteNode, void, 2, 2, deleteNode() )
        /// 
        /// </summary>
        public void deleteNode()
            {
            TorqueScriptTemplate.m_ts.fnGuiRoadEditorCtrl_deleteNode(_mSimObjectId);
            }

        /// <summary>
        /// ( GuiRoadEditorCtrl, deleteRoad, void, 2, 2,  )
        /// 
        /// </summary>
        public void deleteRoad()
            {
            TorqueScriptTemplate.m_ts.fnGuiRoadEditorCtrl_deleteRoad(_mSimObjectId);
            }

        /// <summary>
        /// ( GuiRoadEditorCtrl, getMode, const char*, 2, 2,  )
        /// 
        /// </summary>
        public string getMode()
            {
            return TorqueScriptTemplate.m_ts.fnGuiRoadEditorCtrl_getMode(_mSimObjectId);
            }

        /// <summary>
        /// ( GuiRoadEditorCtrl, getNodePosition, const char*, 2, 2,  )
        /// 
        /// </summary>
        public string getNodePosition()
            {
            return TorqueScriptTemplate.m_ts.fnGuiRoadEditorCtrl_getNodePosition(_mSimObjectId);
            }

        /// <summary>
        /// ( GuiRoadEditorCtrl, getNodeWidth, F32, 2, 2,  )
        /// 
        /// </summary>
        public float getNodeWidth()
            {
            return TorqueScriptTemplate.m_ts.fnGuiRoadEditorCtrl_getNodeWidth(_mSimObjectId);
            }

        /// <summary>
        /// ( GuiRoadEditorCtrl, getSelectedNode, S32, 2, 2,  )
        /// 
        /// </summary>
        public int getSelectedNode()
            {
            return TorqueScriptTemplate.m_ts.fnGuiRoadEditorCtrl_getSelectedNode(_mSimObjectId);
            }

        /// <summary>
        /// ( GuiRoadEditorCtrl, getSelectedRoad, const char*, 2, 2,  )
        /// 
        /// </summary>
        public string getSelectedRoad()
            {
            return TorqueScriptTemplate.m_ts.fnGuiRoadEditorCtrl_getSelectedRoad(_mSimObjectId);
            }

        /// <summary>
        /// ( GuiRoadEditorCtrl, setNodePosition, void, 3, 3,  )
        /// 
        /// </summary>
        public void setNodePosition(string a2)
            {
            TorqueScriptTemplate.m_ts.fnGuiRoadEditorCtrl_setNodePosition(_mSimObjectId, a2);
            }

        /// <summary>
        /// ( GuiRoadEditorCtrl, setNodeWidth, void, 3, 3,  )
        /// 
        /// </summary>
        public void setNodeWidth(string a2)
            {
            TorqueScriptTemplate.m_ts.fnGuiRoadEditorCtrl_setNodeWidth(_mSimObjectId, a2);
            }

        /// <summary>
        /// ( GuiRoadEditorCtrl, setSelectedRoad, void, 2, 3,  )
        /// 
        /// </summary>
        public void setSelectedRoad(string a2 = "")
            {
            TorqueScriptTemplate.m_ts.fnGuiRoadEditorCtrl_setSelectedRoad(_mSimObjectId, a2);
            }
        }
    }