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
    internal class tsObjectConvertercoFileObject : TypeConverter
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
                return new coFileObject(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoFileObject))]
    public class coFileObject : coSimObject
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coFileObject(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coFileObject(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coFileObject(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coFileObject ts, string simobjectid)
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
        public static bool operator !=(coFileObject ts, string simobjectid)
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
        public static implicit operator string(coFileObject ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coFileObject(string ts)
            {
            return new coFileObject(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coFileObject ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coFileObject(int ts)
            {
            return new coFileObject(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coFileObject ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coFileObject(uint ts)
            {
            return new coFileObject(ts);
            }

        /// <summary>
        /// @brief Close the file.
        ///    
        ///    It is EXTREMELY important that you call this function when you are finished reading or writing to a file. 
        ///    Failing to do so is not only a bad programming practice, but could result in bad data or corrupt files. 
        ///    Remember: Open, Read/Write, Close, Delete...in that order!
        ///    
        ///    @tsexample
        ///    // Create a file object for reading
        ///    %fileRead = new FileObject();
        ///    // Open a text file, if it exists
        ///    %fileRead.OpenForRead(\"./test.txt\");
        ///    // Peek the first line
        ///    %line = %fileRead.peekLine();
        ///    // Print the line we just peeked
        ///    echo(%line);
        ///    // If we peek again...
        ///    %line = %fileRead.peekLine();
        ///    // We will get the same output as the first time
        ///    // since the stream did not move forward
        ///    echo(%line);
        ///    // Close the file when finished
        ///    %fileWrite.close();
        ///    // Cleanup the file object
        ///    %fileWrite.delete();
        ///    @endtsexample)
        /// 
        /// </summary>
        public void close()
            {
            TorqueScriptTemplate.m_ts.fnFileObject_close(_mSimObjectId);
            }

        /// <summary>
        /// @brief Determines if the parser for this FileObject has reached the end of the file
        ///    
        ///    @tsexample
        ///    // Create a file object for reading
        ///    %fileRead = new FileObject();
        ///    // Open a text file, if it exists
        ///    %fileRead.OpenForRead(\"./test.txt\");
        ///    // Keep reading until we reach the end of the file
        ///    while( !%fileRead.isEOF() )
        ///    {
        ///       %line = %fileRead.readline();
        ///       echo(%line);
        ///    }
        ///    // Made it to the end
        ///    echo(\"Finished reading file\");
        ///    @endtsexample
        /// 
        ///    @return True if the parser has reached the end of the file, false otherwise)
        /// 
        /// </summary>
        public bool isEOF()
            {
            return TorqueScriptTemplate.m_ts.fnFileObject_isEOF(_mSimObjectId);
            }

        /// <summary>
        /// @brief Open a specified file for writing, adding data to the end of the file
        ///    
        ///    There is no limit as to what kind of file you can write. Any format and data is allowable, not just text. Unlike openForWrite(), 
        ///    which will erase an existing file if it is opened, openForAppend() preserves data in an existing file and adds to it.
        /// 
        ///    @param filename Path, name, and extension of file to append to
        ///    
        ///    @tsexample
        ///    // Create a file object for writing
        ///    %fileWrite = new FileObject();
        ///    // Open a file to write to, if it does not exist it will be created
        ///    // If it does exist, whatever we write will be added to the end
        ///    %result = %fileWrite.OpenForAppend(\"./test.txt\");
        ///    @endtsexample
        /// 
        ///    @return True if file was successfully opened, false otherwise)
        /// 
        /// </summary>
        public bool openForAppend(string filename)
            {
            return TorqueScriptTemplate.m_ts.fnFileObject_openForAppend(_mSimObjectId, filename);
            }

        /// <summary>
        /// @brief Open a specified file for reading
        ///    
        ///    There is no limit as to what kind of file you can read. Any format and data contained within is accessible, not just text
        /// 
        ///    @param filename Path, name, and extension of file to be read
        ///    
        ///    @tsexample
        ///    // Create a file object for reading
        ///    %fileRead = new FileObject();
        ///    // Open a text file, if it exists
        ///    %result = %fileRead.OpenForRead(\"./test.txt\");
        ///    @endtsexample
        /// 
        ///    @return True if file was successfully opened, false otherwise)
        /// 
        /// </summary>
        public bool openForRead(string filename)
            {
            return TorqueScriptTemplate.m_ts.fnFileObject_openForRead(_mSimObjectId, filename);
            }

        /// <summary>
        /// @brief Open a specified file for writing
        ///    
        ///    There is no limit as to what kind of file you can write. Any format and data is allowable, not just text
        /// 
        ///    @param filename Path, name, and extension of file to write to
        ///    
        ///    @tsexample
        ///    // Create a file object for writing
        ///    %fileWrite = new FileObject();
        ///    // Open a file to write to, if it does not exist it will be created
        ///    %result = %fileWrite.OpenForWrite(\"./test.txt\");
        ///    @endtsexample
        /// 
        ///    @return True if file was successfully opened, false otherwise)
        /// 
        /// </summary>
        public bool openForWrite(string filename)
            {
            return TorqueScriptTemplate.m_ts.fnFileObject_openForWrite(_mSimObjectId, filename);
            }

        /// <summary>
        /// @brief Read a line from the file without moving the stream position.
        ///    
        ///    Emphasis on *line*, as in you cannot parse individual characters or chunks of data.  
        ///    There is no limitation as to what kind of data you can read. Unlike readLine, the parser does not move forward after reading.
        /// 
        ///    @param filename Path, name, and extension of file to be read
        ///    
        ///    @tsexample
        ///    // Create a file object for reading
        ///    %fileRead = new FileObject();
        ///    // Open a text file, if it exists
        ///    %fileRead.OpenForRead(\"./test.txt\");
        ///    // Peek the first line
        ///    %line = %fileRead.peekLine();
        ///    // Print the line we just peeked
        ///    echo(%line);
        ///    // If we peek again...
        ///    %line = %fileRead.peekLine();
        ///    // We will get the same output as the first time
        ///    // since the stream did not move forward
        ///    echo(%line);
        ///    @endtsexample
        /// 
        ///    @return String containing the line of data that was just peeked)
        /// 
        /// </summary>
        public string peekLine()
            {
            return TorqueScriptTemplate.m_ts.fnFileObject_peekLine(_mSimObjectId);
            }

        /// <summary>
        /// @brief Read a line from file.
        ///    
        ///    Emphasis on *line*, as in you cannot parse individual characters or chunks of data.  
        ///    There is no limitation as to what kind of data you can read.
        ///    
        ///    @tsexample
        ///    // Create a file object for reading
        ///    %fileRead = new FileObject();
        ///    // Open a text file, if it exists
        ///    %fileRead.OpenForRead(\"./test.txt\");
        ///    // Read in the first line
        ///    %line = %fileRead.readline();
        ///    // Print the line we just read
        ///    echo(%line);
        ///    @endtsexample
        /// 
        ///    @return String containing the line of data that was just read)
        /// 
        /// </summary>
        public string readLine()
            {
            return TorqueScriptTemplate.m_ts.fnFileObject_readLine(_mSimObjectId);
            }

        /// <summary>
        /// @brief Write a line to the file, if it was opened for writing.
        ///    
        ///    There is no limit as to what kind of text you can write. Any format and data is allowable, not just text. 
        ///    Be careful of what you write, as whitespace, current values, and literals will be preserved.
        /// 
        ///    @param text The data we are writing out to file.
        ///    
        ///    @tsexample
        ///    // Create a file object for writing
        ///    %fileWrite = new FileObject();
        ///    // Open a file to write to, if it does not exist it will be created
        ///    %fileWrite.OpenForWrite(\"./test.txt\");
        ///    // Write a line to the text files
        ///    %fileWrite.writeLine(\"READ. READ CODE. CODE\");
        ///    @endtsexample
        /// 
        ///    @return True if file was successfully opened, false otherwise)
        /// 
        /// </summary>
        public void writeLine(string text)
            {
            TorqueScriptTemplate.m_ts.fnFileObject_writeLine(_mSimObjectId, text);
            }

        /// <summary>
        /// ( FileObject, writeObject, void, 3, 4, FileObject.writeObject(SimObject, object prepend) 
        /// 			  @hide)
        /// 
        /// </summary>
        public void writeObject(string a2, string a3 = "")
            {
            TorqueScriptTemplate.m_ts.fnFileObject_writeObject(_mSimObjectId, a2, a3);
            }
        }
    }