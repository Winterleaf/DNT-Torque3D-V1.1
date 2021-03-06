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
    internal class tsObjectConvertercoMessageVector : TypeConverter
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
                return new coMessageVector(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoMessageVector))]
    public class coMessageVector : coSimObject
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coMessageVector(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coMessageVector(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coMessageVector(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coMessageVector ts, string simobjectid)
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
        public static bool operator !=(coMessageVector ts, string simobjectid)
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
        public static implicit operator string(coMessageVector ts)
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
        public static implicit operator coMessageVector(string ts)
            {
            return new coMessageVector(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coMessageVector ts)
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
        public static implicit operator coMessageVector(int ts)
            {
            return new coMessageVector(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coMessageVector ts)
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
        public static implicit operator coMessageVector(uint ts)
            {
            return new coMessageVector(ts);
            }

        /// <summary>
        /// Clear all messages in the vector
        ///    @tsexample
        ///    HudMessageVector.clear();
        ///    @endtsexample)
        /// 
        /// </summary>
        public void clear()
            {
            TorqueScriptTemplate.m_ts.fnMessageVector_clear(_mSimObjectId);
            }

        /// <summary>
        /// Delete the line at the specified position.
        ///    @param deletePos Position in the vector containing the line to be deleted
        ///    @tsexample
        ///    // Delete the first line (index 0) in the vector...
        ///    HudMessageVector.deleteLine(0);
        ///    @endtsexample
        ///    @return False if deletePos is greater than the number of lines in the current vector)
        /// 
        /// </summary>
        public bool deleteLine(int deletePos)
            {
            return TorqueScriptTemplate.m_ts.fnMessageVector_deleteLine(_mSimObjectId, deletePos);
            }

        /// <summary>
        /// ( MessageVector, dump, void, 3, 4, (string filename, string header=NULL)
        ///               Dump the message vector to a file, optionally prefixing a header.
        /// 			  @hide)
        /// 
        /// </summary>
        public void dump(string a2, string a3 = "")
            {
            TorqueScriptTemplate.m_ts.fnMessageVector_dump(_mSimObjectId, a2, a3);
            }

        /// <summary>
        /// Scan through the vector, returning the line number of the first line that matches the specified tag; else returns -1 if no match was found.
        ///    @param tag Numerical value assigned to a message when it was added or inserted
        ///    @tsexample
        ///    // Locate a line of text tagged with the value \"1\", then delete it.
        ///    %taggedLine = HudMessageVector.getLineIndexByTag(1);
        ///    HudMessageVector.deleteLine(%taggedLine);
        ///    @endtsexample
        ///    @return Line with matching tag, other wise -1)
        /// 
        /// </summary>
        public int getLineIndexByTag(int tag)
            {
            return TorqueScriptTemplate.m_ts.fnMessageVector_getLineIndexByTag(_mSimObjectId, tag);
            }

        /// <summary>
        /// Get the tag of a specified line.
        ///    @param pos Position in vector to grab tag from
        ///    @tsexample
        ///    // Remove all lines that do not have a tag value of 1.
        ///    while( HudMessageVector.getNumLines())
        ///    {
        ///       %tag = HudMessageVector.getLineTag(1);
        ///       if(%tag != 1)
        ///          %tag.delete();
        ///       HudMessageVector.popFrontLine();
        ///    }
        ///    @endtsexample
        ///    @return Tag value of a given line, if the position is greater than the number of lines return 0)
        /// 
        /// </summary>
        public int getLineTag(int pos)
            {
            return TorqueScriptTemplate.m_ts.fnMessageVector_getLineTag(_mSimObjectId, pos);
            }

        /// <summary>
        /// Get the text at a specified line.
        ///    @param pos Position in vector to grab text from
        ///    @tsexample
        ///    // Print a line of text at position 1.
        ///    %text = HudMessageVector.getLineText(1);
        ///    echo(%text);
        ///    @endtsexample
        ///    @return Text at specified line, if the position is greater than the number of lines return \"\")
        /// 
        /// </summary>
        public string getLineText(int pos)
            {
            return TorqueScriptTemplate.m_ts.fnMessageVector_getLineText(_mSimObjectId, pos);
            }

        /// <summary>
        /// Scan through the lines in the vector, returning the first line that has a matching tag.
        ///    @param tag Numerical value assigned to a message when it was added or inserted
        ///    @tsexample
        ///    // Locate text in the vector tagged with the value \"1\", then print it
        ///    %taggedText = HudMessageVector.getLineTextByTag(1);
        ///    echo(%taggedText);
        ///    @endtsexample
        ///    @return Text from a line with matching tag, other wise \"\")
        /// 
        /// </summary>
        public string getLineTextByTag(int tag)
            {
            return TorqueScriptTemplate.m_ts.fnMessageVector_getLineTextByTag(_mSimObjectId, tag);
            }

        /// <summary>
        /// Get the number of lines in the vector.
        ///    @tsexample
        ///    // Find out how many lines have been stored in HudMessageVector
        ///    %chatLines = HudMessageVector.getNumLines();
        ///    echo(%chatLines);
        ///    @endtsexample)
        /// 
        /// </summary>
        public int getNumLines()
            {
            return TorqueScriptTemplate.m_ts.fnMessageVector_getNumLines(_mSimObjectId);
            }

        /// <summary>
        /// Push a line onto the back of the list.
        ///    @param msg Text that makes up the message
        ///    @param tag Numerical value associated with this message, useful for searching.
        ///    @tsexample
        ///    // Add the message...
        ///    HudMessageVector.insertLine(1, \"Hello World\", 0);
        ///    @endtsexample
        ///    @return False if insertPos is greater than the number of lines in the current vector)
        /// 
        /// </summary>
        public bool insertLine(int insertPos, string msg, int tag)
            {
            return TorqueScriptTemplate.m_ts.fnMessageVector_insertLine(_mSimObjectId, insertPos, msg, tag);
            }

        /// <summary>
        /// Pop a line from the back of the list; destroys the line.
        ///    @tsexample
        ///    HudMessageVector.popBackLine();
        ///    @endtsexample
        ///    @return False if there are no lines to pop (underflow), true otherwise)
        /// 
        /// </summary>
        public bool popBackLine()
            {
            return TorqueScriptTemplate.m_ts.fnMessageVector_popBackLine(_mSimObjectId);
            }

        /// <summary>
        /// Pop a line from the front of the vector, destroying the line.
        ///    @tsexample
        ///    HudMessageVector.popFrontLine();
        ///    @endtsexample
        ///    @return False if there are no lines to pop (underflow), true otherwise)
        /// 
        /// </summary>
        public bool popFrontLine()
            {
            return TorqueScriptTemplate.m_ts.fnMessageVector_popFrontLine(_mSimObjectId);
            }

        /// <summary>
        /// Push a line onto the back of the list.
        ///    @param msg Text that makes up the message
        ///    @param tag Numerical value associated with this message, useful for searching.
        ///    @tsexample
        ///    // Add the message...
        ///    HudMessageVector.pushBackLine(\"Hello World\", 0);
        ///    @endtsexample)
        /// 
        /// </summary>
        public void pushBackLine(string msg, int tag)
            {
            TorqueScriptTemplate.m_ts.fnMessageVector_pushBackLine(_mSimObjectId, msg, tag);
            }

        /// <summary>
        /// Push a line onto the front of the vector.
        ///    @param msg Text that makes up the message
        ///    @param tag Numerical value associated with this message, useful for searching.
        ///    @tsexample
        ///    // Add the message...
        ///    HudMessageVector.pushFrontLine(\"Hello World\", 0);
        ///    @endtsexample)
        /// 
        /// </summary>
        public void pushFrontLine(string msg, int tag)
            {
            TorqueScriptTemplate.m_ts.fnMessageVector_pushFrontLine(_mSimObjectId, msg, tag);
            }
        }
    }