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
    internal class tsObjectConvertercoGuiButtonBaseCtrl : TypeConverter
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
                return new coGuiButtonBaseCtrl(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiButtonBaseCtrl))]
    public class coGuiButtonBaseCtrl : coGuiControl
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiButtonBaseCtrl(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiButtonBaseCtrl(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiButtonBaseCtrl(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// Button behavior type.\n 
        /// </summary>
        public GuiButtonBaseCtrl__ButtonType buttonType
            {
            get { return (GuiButtonBaseCtrl__ButtonType) Enum.Parse(typeof (GuiButtonBaseCtrl__ButtonType), dnTorque.self.GetVar(_mSimObjectId + ".buttonType")); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".buttonType", value.ToString()); }
            }

        /// <summary>
        /// Radio button toggle group number. All radio buttons that are assigned the same #groupNum and that      are parented to the same control will synchronize their toggle state, i.e. if one radio button is toggled on      all other radio buttons in its group will be toggled off.\n\n     The default group is -1. 
        /// </summary>
        public int groupNum
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".groupNum").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".groupNum", value.AsString()); }
            }

        /// <summary>
        /// Text label to display on button (if button class supports text labels). 
        /// </summary>
        public String text
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".text").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".text", value.AsString()); }
            }

        /// <summary>
        /// ID of string in string table to use for text label on button.\n\n     @see setTextID\n     @see GuiControl::langTableMod\n     @see LangTable\n\n 
        /// </summary>
        public String textID
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".textID").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".textID", value.AsString()); }
            }

        /// <summary>
        /// If true, mouse events will be passed on to script. Default is false.\n 
        /// </summary>
        public bool useMouseEvents
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".useMouseEvents").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".useMouseEvents", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiButtonBaseCtrl ts, string simobjectid)
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
        public static bool operator !=(coGuiButtonBaseCtrl ts, string simobjectid)
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
        public static implicit operator string(coGuiButtonBaseCtrl ts)
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
        public static implicit operator coGuiButtonBaseCtrl(string ts)
            {
            return new coGuiButtonBaseCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiButtonBaseCtrl ts)
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
        public static implicit operator coGuiButtonBaseCtrl(int ts)
            {
            return new coGuiButtonBaseCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiButtonBaseCtrl ts)
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
        public static implicit operator coGuiButtonBaseCtrl(uint ts)
            {
            return new coGuiButtonBaseCtrl(ts);
            }

        /// <summary>
        /// Get the text display on the button's label (if any).
        ///    @return The button's label. )
        /// 
        /// </summary>
        public string getText()
            {
            return TorqueScriptTemplate.m_ts.fnGuiButtonBaseCtrl_getText(_mSimObjectId);
            }

        /// <summary>
        /// Simulate a click on the button.
        ///    This method will trigger the button's action just as if the button had been pressed by the 
        ///    user. )
        /// 
        /// </summary>
        public void performClick()
            {
            TorqueScriptTemplate.m_ts.fnGuiButtonBaseCtrl_performClick(_mSimObjectId);
            }

        /// <summary>
        /// Reset the mousing state of the button.
        ///    This method should not generally be called. )
        /// 
        /// </summary>
        public void resetState()
            {
            TorqueScriptTemplate.m_ts.fnGuiButtonBaseCtrl_resetState(_mSimObjectId);
            }

        /// <summary>
        /// For toggle or radio buttons, set whether the button is currently activated or not.  For radio buttons, 
        ///    toggling a button on will toggle all other radio buttons in its group to off.
        ///    @param isOn If true, the button will be toggled on (if not already); if false, it will be toggled off.
        ///    @note Toggling the state of a button with this method will em>not/em> not trigger the action associated with the 
        ///       button.  To do that, use performClick(). )
        /// 
        /// </summary>
        public void setStateOn(bool isOn)
            {
            TorqueScriptTemplate.m_ts.fnGuiButtonBaseCtrl_setStateOn(_mSimObjectId, isOn);
            }

        /// <summary>
        /// Set the text displayed on the button's label.
        ///    @param text The text to display as the button's text label.
        ///    @note Not all buttons render text labels.
        ///    @see getText
        ///    @see setTextID )
        /// 
        /// </summary>
        public void setText(string text)
            {
            TorqueScriptTemplate.m_ts.fnGuiButtonBaseCtrl_setText(_mSimObjectId, text);
            }

        /// <summary>
        /// Set the text displayed on the button's label using a string from the string table 
        ///    assigned to the control.
        ///    @param id Name of the variable that contains the integer string ID.  Used to look up 
        ///       string in table.
        ///    @note Not all buttons render text labels.
        ///    @see setText
        ///    @see getText
        ///    @see GuiControl::langTableMod
        ///    @see LangTable
        ///    @ref Gui_i18n )
        /// 
        /// </summary>
        public void setTextID(string id)
            {
            TorqueScriptTemplate.m_ts.fnGuiButtonBaseCtrl_setTextID(_mSimObjectId, id);
            }
        }
    }