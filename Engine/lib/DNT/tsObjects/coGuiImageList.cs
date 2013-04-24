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
    internal class tsObjectConvertercoGuiImageList : TypeConverter
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
                return new coGuiImageList(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiImageList))]
    public class coGuiImageList : coSimObject
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiImageList(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiImageList(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coGuiImageList(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiImageList ts, string simobjectid)
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
        public static bool operator !=(coGuiImageList ts, string simobjectid)
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
        public static implicit operator string(coGuiImageList ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiImageList(string ts)
            {
            return new coGuiImageList(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiImageList ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiImageList(int ts)
            {
            return new coGuiImageList(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiImageList ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiImageList(uint ts)
            {
            return new coGuiImageList(ts);
            }

        /// <summary>
        /// @brief Clears the imagelist
        ///    @tsexample
        ///    // Inform the GuiImageList control to clear itself.
        ///    %isFinished = %thisGuiImageList.clear();
        ///    @endtsexample
        ///    @return Returns true when finished.
        ///    @see SimObject)
        /// 
        /// </summary>
        public bool clear()
            {
            return TorqueScriptTemplate.m_ts.fnGuiImageList_clear(_mSimObjectId);
            }

        /// <summary>
        /// @brief Gets the number of images in the list.
        ///    @tsexample
        ///    // Request the number of images from the GuiImageList control.
        ///    %imageCount = %thisGuiImageList.count();
        ///    @endtsexample
        ///    @return Number of images in the control.
        ///    @see SimObject)
        /// 
        /// </summary>
        public int count()
            {
            return TorqueScriptTemplate.m_ts.fnGuiImageList_count(_mSimObjectId);
            }

        /// <summary>
        /// @brief Get a path to the texture at the specified index.
        ///    @param index Index of the image in the list.
        ///    @tsexample
        ///    // Define the image index/n
        ///    %index = \"5\";
        ///    // Request the image path location from the control.
        ///    %imagePath = %thisGuiImageList.getImage(%index);
        ///    @endtsexample
        ///    @return File path to the image map for the specified index.
        ///    @see SimObject)
        /// 
        /// </summary>
        public string getImage(int index)
            {
            return TorqueScriptTemplate.m_ts.fnGuiImageList_getImage(_mSimObjectId, index);
            }

        /// <summary>
        /// @brief Retrieves the imageindex of a specified texture in the list.
        ///    @param imagePath Imagemap including filepath of image to search for
        ///    @tsexample
        ///    // Define the imagemap to search for
        ///    %imagePath = \"./game/client/data/images/thisImage\";
        ///    // Request the index entry for the defined imagemap
        ///    %imageIndex = %thisGuiImageList.getIndex(%imagePath);
        ///    @endtsexample
        ///    @return Index of the imagemap matching the defined image path.
        ///    @see SimObject)
        /// 
        /// </summary>
        public int getIndex(string imagePath)
            {
            return TorqueScriptTemplate.m_ts.fnGuiImageList_getIndex(_mSimObjectId, imagePath);
            }

        /// <summary>
        /// @brief Insert an image into imagelist- returns the image index or -1 for failure.
        ///    @param imagePath Imagemap, with path, to add to the list.
        ///    @tsexample
        ///    // Define the imagemap to add to the list
        ///    %imagePath = \"./game/client/data/images/thisImage\";
        ///    // Request the GuiImageList control to add the defined image to its list.
        ///    %imageIndex = %thisGuiImageList.insert(%imagePath);
        ///    @endtsexample
        ///    @return The index of the newly inserted imagemap, or -1 if the insertion failed.
        ///    @see SimObject)
        /// 
        /// </summary>
        public int insert(string imagePath)
            {
            return TorqueScriptTemplate.m_ts.fnGuiImageList_insert(_mSimObjectId, imagePath);
            }

        /// <summary>
        /// @brief Removes an image from the list by index.
        ///    @param index Image index to remove.
        ///    @tsexample
        ///    // Define the image index.
        ///    %imageIndex = \"4\";
        ///    // Inform the GuiImageList control to remove the image at the defined index.
        ///    %wasSuccessful = %thisGuiImageList.remove(%imageIndex);
        ///    @endtsexample
        ///    @return True if the operation was successful, false if it was not.
        ///    @see SimObject)
        /// 
        /// </summary>
        public bool remove(int index)
            {
            return TorqueScriptTemplate.m_ts.fnGuiImageList_remove(_mSimObjectId, index);
            }
        }
    }