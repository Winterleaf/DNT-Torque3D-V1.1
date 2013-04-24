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
    internal class tsObjectConvertercoSimXMLDocument : TypeConverter
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
                return new coSimXMLDocument(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoSimXMLDocument))]
    public class coSimXMLDocument : coSimObject
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coSimXMLDocument(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coSimXMLDocument(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        public coSimXMLDocument(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coSimXMLDocument ts, string simobjectid)
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
        public static bool operator !=(coSimXMLDocument ts, string simobjectid)
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
        public static implicit operator string(coSimXMLDocument ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSimXMLDocument(string ts)
            {
            return new coSimXMLDocument(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coSimXMLDocument ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSimXMLDocument(int ts)
            {
            return new coSimXMLDocument(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coSimXMLDocument ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSimXMLDocument(uint ts)
            {
            return new coSimXMLDocument(ts);
            }

        /// <summary>
        /// @brief Add the given comment as a child of the document.
        ///   @param comment String containing the comment.
        /// 
        ///    @tsexample
        ///    // Create a new XML document with a header, a comment and single element.
        ///    %x = new SimXMLDocument();
        ///    %x.addHeader();
        ///    %x.addComment(\"This is a test comment\");
        ///    %x.addNewElement(\"NewElement\");
        ///    %x.saveFile(\"test.xml\");
        ///    // Produces the following file:
        ///    // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>
        ///    // !--This is a test comment-->
        ///    // NewElement />
        ///    @endtsexample
        ///    
        ///    @see readComment())
        /// 
        /// </summary>
        public void addComment(string comment)
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_addComment(_mSimObjectId, comment);
            }

        /// <summary>
        /// @brief Add the given text as a child of current Element.
        /// 
        ///    Use getData() to retrieve any text from the current Element.
        /// 
        ///    addData() and addText() may be used interchangeably.  As there is no 
        ///    difference between data and text, you may also use removeText() to clear 
        ///    any data from the current Element.
        /// 
        ///    @param text String containing the text.
        /// 
        ///    @tsexample
        ///    // Create a new XML document with a header and single element
        ///    // with some added data.
        ///    %x = new SimXMLDocument();
        ///    %x.addHeader();
        ///    %x.addNewElement(\"NewElement\");
        ///    %x.addData(\"Some text\");
        ///    %x.saveFile(\"test.xml\");
        ///    // Produces the following file:
        ///    // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>
        ///    // NewElement>Some text/NewElement>
        ///    @endtsexample
        /// 
        ///    @see getData()
        ///    @see addText()
        ///    @see getText()
        ///    @see removeText())
        /// 
        /// </summary>
        public void addData(string text)
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_addData(_mSimObjectId, text);
            }

        /// <summary>
        /// @brief Add a XML header to a document.
        /// 
        ///    Sometimes called a declaration, you typically add a standard header to 
        ///    the document before adding any elements.  SimXMLDocument always produces 
        ///    the following header:
        ///    ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>
        ///   
        ///    @tsexample
        ///    // Create a new XML document with just a header and single element.
        ///    %x = new SimXMLDocument();
        ///    %x.addHeader();
        ///    %x.addNewElement(\"NewElement\");
        ///    %x.saveFile(\"test.xml\");
        ///    // Produces the following file:
        ///    // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>
        ///    // NewElement />
        ///    @endtsexample)
        /// 
        /// </summary>
        public void addHeader()
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_addHeader(_mSimObjectId);
            }

        /// <summary>
        /// @brief Create a new element with the given name as child of current Element's 
        ///    parent and push it onto the Element stack making it the current one.
        /// 
        ///    @note This differs from pushNewElement() in that it adds the new Element to the 
        ///    current Element's parent (or document if there is no parent Element).  This makes 
        ///    the new Element a sibling of the current one.
        /// 
        ///    @param name XML tag for the new Element.
        ///    
        ///    @see pushNewElement())
        /// 
        /// </summary>
        public void addNewElement(string name)
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_addNewElement(_mSimObjectId, name);
            }

        /// <summary>
        /// @brief Add the given text as a child of current Element.
        /// 
        ///    Use getText() to retrieve any text from the current Element and removeText() 
        ///    to clear any text.
        /// 
        ///    addText() and addData() may be used interchangeably.
        /// 
        ///    @param text String containing the text.
        /// 
        ///    @tsexample
        ///    // Create a new XML document with a header and single element
        ///    // with some added text.
        ///    %x = new SimXMLDocument();
        ///    %x.addHeader();
        ///    %x.addNewElement(\"NewElement\");
        ///    %x.addText(\"Some text\");
        ///    %x.saveFile(\"test.xml\");
        ///    // Produces the following file:
        ///    // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>
        ///    // NewElement>Some text/NewElement>
        ///    @endtsexample
        /// 
        ///    @see getText()
        ///    @see removeText()
        ///    @see addData()
        ///    @see getData())
        /// 
        /// </summary>
        public void addText(string text)
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_addText(_mSimObjectId, text);
            }

        /// <summary>
        /// @brief Get a string attribute from the current Element on the stack.
        ///    @param attributeName Name of attribute to retrieve.
        ///    @return The attribute string if found.  Otherwise returns an empty string.)
        /// 
        /// </summary>
        public string attribute(string attributeName)
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_attribute(_mSimObjectId, attributeName);
            }

        /// <summary>
        /// @brief Tests if the requested attribute exists.
        ///    @param attributeName Name of attribute being queried for.
        ///    @return True if the attribute exists.)
        /// 
        /// </summary>
        public bool attributeExists(string attributeName)
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_attributeExists(_mSimObjectId, attributeName);
            }

        /// <summary>
        /// ( SimXMLDocument, attributeF32, F32, 3, 3, (string attributeName)
        ///    @brief Get float attribute from the current Element on the stack.
        ///    @param attributeName Name of attribute to retrieve.
        ///    @return The value of the given attribute in the form of a float.
        ///    @deprecated Use attribute().)
        /// 
        /// </summary>
        public float attributeF32(string a2)
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_attributeF32(_mSimObjectId, a2);
            }

        /// <summary>
        /// (SimXMLDocument, attributeS32, S32, 3, 3, (string attributeName)
        ///    @brief Get int attribute from the current Element on the stack.
        ///    @param attributeName Name of attribute to retrieve.
        ///    @return The value of the given attribute in the form of an integer.
        ///    @deprecated Use attribute().)
        /// 
        /// </summary>
        public int attributeS32(string a2)
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_attributeS32(_mSimObjectId, a2);
            }

        /// <summary>
        /// @brief Set this document to its default state.
        ///    
        ///    Clears all Elements from the documents.  Equivalent to using reset()
        ///    
        ///    @see reset())
        /// 
        /// </summary>
        public void clear()
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_clear(_mSimObjectId);
            }

        /// <summary>
        /// @brief Clear the last error description.)
        /// 
        /// </summary>
        public void clearError()
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_clearError(_mSimObjectId);
            }

        /// <summary>
        /// @brief Get the Element's value if it exists.
        ///    Usually returns the text from the Element.
        ///    @return The value from the Element, or an empty string if none is found.)
        /// 
        /// </summary>
        public string elementValue()
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_elementValue(_mSimObjectId);
            }

        /// <summary>
        /// @brief Obtain the name of the current Element's first attribute.
        ///    @return String containing the first attribute's name, or an empty string if none is found.
        ///    @see nextAttribute()
        ///    @see lastAttribute()
        ///    @see prevAttribute())
        /// 
        /// </summary>
        public string firstAttribute()
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_firstAttribute(_mSimObjectId);
            }

        /// <summary>
        /// @brief Gets the text from the current Element.
        /// 
        ///    Use addData() to add text to the current Element.
        /// 
        ///    getData() and getText() may be used interchangeably.  As there is no 
        ///    difference between data and text, you may also use removeText() to clear 
        ///    any data from the current Element.
        /// 
        ///    @return String containing the text in the current Element.
        /// 
        ///    @tsexample
        ///    // Using the following test.xml file as an example:
        ///    // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>
        ///    // NewElement>Some data/NewElement>
        /// 
        ///    // Load in the file
        ///    %x = new SimXMLDocument();
        ///    %x.loadFile(\"test.xml\");
        /// 
        ///    // Make the first Element the current one
        ///    %x.pushFirstChildElement(\"NewElement\");
        /// 
        ///    // Store the current Element's data ('Some data' in this example)
        ///    // into 'result'
        ///    %result = %x.getData();
        ///    echo( %result );
        ///    @endtsexample
        ///    
        ///    @see addData()
        ///    @see addText()
        ///    @see getText()
        ///    @see removeText())
        /// 
        /// </summary>
        public string getData()
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_getData(_mSimObjectId);
            }

        /// <summary>
        /// @brief Get last error description.
        ///    @return A string of the last error message.)
        /// 
        /// </summary>
        public string getErrorDesc()
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_getErrorDesc(_mSimObjectId);
            }

        /// <summary>
        /// @brief Gets the text from the current Element.
        /// 
        ///    Use addText() to add text to the current Element and removeText() 
        ///    to clear any text.
        /// 
        ///    getText() and getData() may be used interchangeably.
        /// 
        ///    @return String containing the text in the current Element.
        /// 
        ///    @tsexample
        ///    // Using the following test.xml file as an example:
        ///    // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>
        ///    // NewElement>Some text/NewElement>
        /// 
        ///    // Load in the file
        ///    %x = new SimXMLDocument();
        ///    %x.loadFile(\"test.xml\");
        /// 
        ///    // Make the first Element the current one
        ///    %x.pushFirstChildElement(\"NewElement\");
        /// 
        ///    // Store the current Element's text ('Some text' in this example)
        ///    // into 'result'
        ///    %result = %x.getText();
        ///    echo( %result );
        ///    @endtsexample
        ///    
        ///    @see addText()
        ///    @see removeText()
        ///    @see addData()
        ///    @see getData())
        /// 
        /// </summary>
        public string getText()
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_getText(_mSimObjectId);
            }

        /// <summary>
        /// @brief Obtain the name of the current Element's last attribute.
        ///    @return String containing the last attribute's name, or an empty string if none is found.
        ///    @see prevAttribute()
        ///    @see firstAttribute()
        ///    @see lastAttribute())
        /// 
        /// </summary>
        public string lastAttribute()
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_lastAttribute(_mSimObjectId);
            }

        /// <summary>
        /// @brief Load in given filename and prepare it for use.
        ///    @note Clears the current document's contents.
        ///    @param fileName Name and path of XML document
        ///    @return True if the file was loaded successfully.)
        /// 
        /// </summary>
        public bool loadFile(string fileName)
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_loadFile(_mSimObjectId, fileName);
            }

        /// <summary>
        /// @brief Get the name of the next attribute for the current Element after a call to firstAttribute().
        ///    @return String containing the next attribute's name, or an empty string if none is found.
        ///    @see firstAttribute()
        ///    @see lastAttribute()
        ///    @see prevAttribute())
        /// 
        /// </summary>
        public string nextAttribute()
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_nextAttribute(_mSimObjectId);
            }

        /// <summary>
        /// @brief Put the next sibling Element with the given name on the stack, making it the current one.
        ///    @param name String containing name of the next sibling.
        ///    @return True if the Element was found and made the current one.)
        /// 
        /// </summary>
        public bool nextSiblingElement(string name)
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_nextSiblingElement(_mSimObjectId, name);
            }

        /// <summary>
        /// @brief Create a document from a XML string.
        ///    @note Clears the current document's contents.
        ///    @param xmlString Valid XML to parse and store as a document.)
        /// 
        /// </summary>
        public void parse(string xmlString)
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_parse(_mSimObjectId, xmlString);
            }

        /// <summary>
        /// @brief Pop the last Element off the stack.)
        /// 
        /// </summary>
        public void popElement()
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_popElement(_mSimObjectId);
            }

        /// <summary>
        /// @brief Get the name of the previous attribute for the current Element after a call to lastAttribute().
        ///    @return String containing the previous attribute's name, or an empty string if none is found.
        ///    @see lastAttribute()
        ///    @see firstAttribute()
        ///    @see nextAttribute())
        /// 
        /// </summary>
        public string prevAttribute()
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_prevAttribute(_mSimObjectId);
            }

        /// <summary>
        /// @brief Push the child Element at the given index onto the stack, making it the current one.
        ///    @param index Numerical index of Element being pushed.
        ///    @return True if the Element was found and made the current one.)
        /// 
        /// </summary>
        public bool pushChildElement(int index)
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_pushChildElement(_mSimObjectId, index);
            }

        /// <summary>
        /// @brief Push the first child Element with the given name onto the stack, making it the current Element.
        /// 
        ///    @param name String containing name of the child Element.
        ///    @return True if the Element was found and made the current one.
        /// 
        ///    @tsexample
        ///    // Using the following test.xml file as an example:
        ///    // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>
        ///    // NewElement>Some text/NewElement>
        /// 
        ///    // Load in the file
        ///    %x = new SimXMLDocument();
        ///    %x.loadFile(\"test.xml\");
        /// 
        ///    // Make the first Element the current one
        ///    %x.pushFirstChildElement(\"NewElement\");
        /// 
        ///    // Store the current Element's text ('Some text' in this example)
        ///    // into 'result'
        ///    %result = %x.getText();
        ///    echo( %result );
        ///    @endtsexample)
        /// 
        /// </summary>
        public bool pushFirstChildElement(string name)
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_pushFirstChildElement(_mSimObjectId, name);
            }

        /// <summary>
        /// @brief Create a new element with the given name as child of current Element 
        ///    and push it onto the Element stack making it the current one.
        /// 
        ///    @note This differs from addNewElement() in that it adds the new Element as a 
        ///    child of the current Element (or a child of the document if no Element exists).
        /// 
        ///    @param name XML tag for the new Element.
        /// 
        ///    @see addNewElement())
        /// 
        /// </summary>
        public void pushNewElement(string name)
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_pushNewElement(_mSimObjectId, name);
            }

        /// <summary>
        /// Gives the comment at the specified index, if any.
        /// 
        ///    Unlike addComment() that only works at the document level, readComment() may read 
        ///    comments from the document or any child Element.  The current Element (or document 
        ///    if no Elements have been pushed to the stack) is the parent for any comments, and the 
        ///    provided index is the number of comments in to read back.
        /// 
        ///    @param index Comment index number to query from the current Element stack
        ///    @return String containing the comment, or an empty string if no comment is found.
        /// 
        ///    @see addComment())
        /// 
        /// </summary>
        public string readComment(int index)
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_readComment(_mSimObjectId, index);
            }

        /// <summary>
        /// @brief Remove any text on the current Element.
        /// 
        ///    Use getText() to retrieve any text from the current Element and addText() 
        ///    to add text to the current Element.  As getData() and addData() are equivalent 
        ///    to getText() and addText(), removeText() will also remove any data from the 
        ///    current Element.
        ///    
        ///    @see addText()
        ///    @see getText()
        ///    @see addData()
        ///    @see getData())
        /// 
        /// </summary>
        public void removeText()
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_removeText(_mSimObjectId);
            }

        /// <summary>
        /// @brief Set this document to its default state.
        ///    
        ///    Clears all Elements from the documents.  Equivalent to using clear()
        ///    
        ///    @see clear())
        /// 
        /// </summary>
        public void reset()
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_reset(_mSimObjectId);
            }

        /// <summary>
        /// @brief Save document to the given file name.
        ///    @param fileName Path and name of XML file to save to.
        ///    @return True if the file was successfully saved.)
        /// 
        /// </summary>
        public bool saveFile(string fileName)
            {
            return TorqueScriptTemplate.m_ts.fnSimXMLDocument_saveFile(_mSimObjectId, fileName);
            }

        /// <summary>
        /// @brief Set the attribute of the current Element on the stack to the given value.
        ///    @param attributeName Name of attribute being changed
        ///    @param value New value to assign to the attribute)
        /// 
        /// </summary>
        public void setAttribute(string attributeName, string value)
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_setAttribute(_mSimObjectId, attributeName, value);
            }

        /// <summary>
        /// @brief Add the given SimObject's fields as attributes of the current Element on the stack.
        ///    @param objectID ID of SimObject being copied.)
        /// 
        /// </summary>
        public void setObjectAttributes(string objectID)
            {
            TorqueScriptTemplate.m_ts.fnSimXMLDocument_setObjectAttributes(_mSimObjectId, objectID);
            }
        }
    }