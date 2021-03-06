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
    internal class tsObjectConvertercoGuiPopUpMenuCtrlEx : TypeConverter
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
                return new coGuiPopUpMenuCtrlEx(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiPopUpMenuCtrlEx))]
    public class coGuiPopUpMenuCtrlEx : coGuiTextCtrl
        {
        private Point2I _bitmapBounds;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiPopUpMenuCtrlEx(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiPopUpMenuCtrlEx(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiPopUpMenuCtrlEx(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// File name of bitmap to use
        /// </summary>
        public String bitmap
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".bitmap").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".bitmap", value.AsString()); }
            }

        /// <summary>
        /// Boundaries of bitmap displayed
        /// </summary>
        public Point2I bitmapBounds
            {
            get
                {
                if (_bitmapBounds != null)
                    _bitmapBounds.DetachAllEvents();
                _bitmapBounds = dnTorque.self.GetVar(_mSimObjectId + ".bitmapBounds").AsPoint2I();
                _bitmapBounds.OnChangeNotification += _bitmapBounds_OnChangeNotification;
                return _bitmapBounds;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".bitmapBounds", value.AsString()); }
            }

        /// <summary>
        /// Whether to provide a 'onHotTrackItem' callback when a list item is hovered over
        /// </summary>
        public bool hotTrackCallback
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".hotTrackCallback").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".hotTrackCallback", value.AsString()); }
            }

        /// <summary>
        /// Length of menu when it extends
        /// </summary>
        public int maxPopupHeight
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".maxPopupHeight").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxPopupHeight", value.AsString()); }
            }

        /// <summary>
        /// Reverses text list if popup extends up, instead of down
        /// </summary>
        public bool reverseTextList
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".reverseTextList").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".reverseTextList", value.AsString()); }
            }

        /// <summary>
        /// Deprecated @internal
        /// </summary>
        public bool sbUsesNAColor
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".sbUsesNAColor").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".sbUsesNAColor", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiPopUpMenuCtrlEx ts, string simobjectid)
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
        public static bool operator !=(coGuiPopUpMenuCtrlEx ts, string simobjectid)
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
        public static implicit operator string(coGuiPopUpMenuCtrlEx ts)
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
        public static implicit operator coGuiPopUpMenuCtrlEx(string ts)
            {
            return new coGuiPopUpMenuCtrlEx(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiPopUpMenuCtrlEx ts)
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
        public static implicit operator coGuiPopUpMenuCtrlEx(int ts)
            {
            return new coGuiPopUpMenuCtrlEx(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiPopUpMenuCtrlEx ts)
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
        public static implicit operator coGuiPopUpMenuCtrlEx(uint ts)
            {
            return new coGuiPopUpMenuCtrlEx(ts);
            }

        private void _bitmapBounds_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".bitmapBounds", e.NewValue);
            }

        /// <summary>
        /// ( GuiPopUpMenuCtrlEx, add, void, 3, 5, (string name, int idNum, int scheme=0))
        /// 
        /// </summary>
        public void add(string a2, string a3 = "", string a4 = "")
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_add(_mSimObjectId, a2, a3, a4);
            }

        /// <summary>
        /// @brief Add a category to the list.
        /// 
        /// 				   Acts as a separator between entries, allowing for sub-lists
        /// 
        /// 				   @param text Name of the new category)
        /// 
        /// </summary>
        public void addCategory(string text)
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_addCategory(_mSimObjectId, text);
            }

        /// <summary>
        /// @brief Create a new scheme and add it to the list of choices for when a new text entry is added.
        /// 				   @param id Numerical id associated with this scheme
        /// 				   @param fontColor The base text font color. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.
        /// 				   @param fontColorHL Color of text when being highlighted. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.
        /// 				   @param fontColorSel Color of text when being selected. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.)
        /// 
        /// </summary>
        public void addScheme(int id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL)
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_addScheme(_mSimObjectId, id, fontColor.AsString(), fontColorHL.AsString(), fontColorSEL.AsString());
            }

        /// <summary>
        /// @brief Clear the popup list.)
        /// 
        /// </summary>
        public new void clear()
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_clear(_mSimObjectId);
            }

        /// <summary>
        /// ( GuiPopUpMenuCtrlEx, clearEntry, void, 3, 3, (S32 entry))
        /// 
        /// </summary>
        public void clearEntry(string a2)
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_clearEntry(_mSimObjectId, a2);
            }

        /// <summary>
        /// ( GuiPopUpMenuCtrlEx, findText, S32, 3, 3, (string text)
        ///               Returns the id of the first entry containing the specified text or -1 if not found.
        /// 			  @param text String value used for the query
        /// 			  @return Numerical ID of entry containing the text.)
        /// 
        /// </summary>
        public int findText(string a2)
            {
            return TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_findText(_mSimObjectId, a2);
            }

        /// <summary>
        /// @brief Manually force this control to collapse and close.)
        /// 
        /// </summary>
        public void forceClose()
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_forceClose(_mSimObjectId);
            }

        /// <summary>
        /// @brief Manually for the onAction function, which updates everything in this control.)
        /// 
        /// </summary>
        public void forceOnAction()
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_forceOnAction(_mSimObjectId);
            }

        /// <summary>
        /// ( GuiPopUpMenuCtrlEx, getColorById, const char*, 3, 3,  
        /// 			  @brief Get color of an entry's box
        /// 			  @param id ID number of entry to query
        /// 			  @return ColorI in the format of \"Red Green Blue Alpha\", each of with is a value between 0 - 255)
        /// 
        /// </summary>
        public string getColorById(string a2)
            {
            return TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_getColorById(_mSimObjectId, a2);
            }

        /// <summary>
        /// @brief Get the current selection of the menu.
        /// 				   @return Returns the ID of the currently selected entry)
        /// 
        /// </summary>
        public int getSelected()
            {
            return TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_getSelected(_mSimObjectId);
            }

        /// <summary>
        /// @brief Get the.
        /// 
        /// 				   Detailed description
        /// 
        /// 				   @param param Description
        /// 
        /// 				   @tsexample
        /// 				   // Comment
        /// 				   code();
        /// 				   @endtsexample
        /// 
        /// 				   @return Returns current text in string format)
        /// 
        /// </summary>
        public string getText()
            {
            return TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_getText(_mSimObjectId);
            }

        /// <summary>
        /// @brief Get the text of an entry based on an ID.
        /// 				   @param id The ID assigned to the entry being queried
        /// 				   @return String contained by the specified entry, NULL if empty or bad ID)
        /// 
        /// </summary>
        public string getTextById(int id)
            {
            return TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_getTextById(_mSimObjectId, id);
            }

        /// <summary>
        /// ( GuiPopUpMenuCtrlEx, replaceText, void, 3, 3, 
        /// 			  @brief Flag that causes each new text addition to replace the current entry
        /// 			  @param True to turn on replacing, false to disable it)
        /// 
        /// </summary>
        public void replaceText(string a2)
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_replaceText(_mSimObjectId, a2);
            }

        /// <summary>
        /// ( GuiPopUpMenuCtrlEx, setEnumContent, void, 4, 4,
        /// 			  @brief This fills the popup with a classrep's field enumeration type info.
        ///               More of a helper function than anything.   If console access to the field list is added, 
        ///               at least for the enumerated types, then this should go away.
        /// 			  @param class Name of the class containing the enum
        /// 			  @param enum Name of the enum value to acces)
        /// 
        /// </summary>
        public void setEnumContent(string a2, string a3)
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_setEnumContent(_mSimObjectId, a2, a3);
            }

        /// <summary>
        /// ( GuiPopUpMenuCtrlEx, setFirstSelected, void, 2, 3, ([scriptCallback=true])
        /// 			  @hide)
        /// 
        /// </summary>
        public void setFirstSelected(string a2 = "")
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_setFirstSelected(_mSimObjectId, a2);
            }

        /// <summary>
        /// @brief Clears selection in the menu.)
        /// 
        /// </summary>
        public void setNoneSelected(int param)
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_setNoneSelected(_mSimObjectId, param);
            }

        /// <summary>
        /// ( GuiPopUpMenuCtrlEx, setSelected, void, 3, 4, (int id, [scriptCallback=true])
        /// 			  @hide)
        /// 
        /// </summary>
        public void setSelected(string a2, string a3 = "")
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_setSelected(_mSimObjectId, a2, a3);
            }

        /// <summary>
        /// @brief Set the current text to a specified value.
        /// 				   @param text String containing new text to set)
        /// 
        /// </summary>
        public new void setText(string text)
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_setText(_mSimObjectId, text);
            }

        /// <summary>
        /// ( GuiPopUpMenuCtrlEx, size, S32, 2, 2, 
        /// 			  @brief Get the size of the menu
        /// 			  @return Number of entries in the menu)
        /// 
        /// </summary>
        public int size()
            {
            return TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_size(_mSimObjectId);
            }

        /// <summary>
        /// @brief Sort the list alphabetically.)
        /// 
        /// </summary>
        public void sort()
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_sort(_mSimObjectId);
            }

        /// <summary>
        /// @brief Sort the list by ID.)
        /// 
        /// </summary>
        public void sortID()
            {
            TorqueScriptTemplate.m_ts.fnGuiPopUpMenuCtrlEx_sortID(_mSimObjectId);
            }
        }
    }