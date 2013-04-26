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

namespace WinterLeaf.Containers
    {
    internal class PolyhedronIConverter : TypeConverter
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
                return new Polyhedron(value as string);
                }

            return null;
            }
        }

    /// <summary>
    /// Polyhedron Container
    /// </summary>
    [TypeConverter(typeof (PolyhedronIConverter))]
    public class Polyhedron : Notifier, IConvertible
        {
        /// <summary>
        /// Initializes a new instance of the Polyhedron class.
        /// </summary>
        private Point3F _mOrigin; // = new Point3F();

        private Point3F _mVector1; // = new Point3F(0, 0, 0);

        private Point3F _mVector2; // = new Point3F(0, 0, 0);

        private Point3F _mVector3; // = new Point3F(0, 0, 0);

        /// <summary>
        /// Constructor
        /// </summary>
        public Polyhedron()
            {
            _mOrigin = new Point3F();
            _mOrigin.OnChangeNotification += __OnChangeNotification;
            _mVector1 = new Point3F();
            _mVector1.OnChangeNotification += __OnChangeNotification;
            _mVector2 = new Point3F();
            _mVector2.OnChangeNotification += __OnChangeNotification;
            _mVector3 = new Point3F();
            _mVector3.OnChangeNotification += __OnChangeNotification;
            }

        /// <summary>
        /// Constructor Taking String
        /// </summary>
        /// <param name="poly"></param>
        public Polyhedron(string poly)
            {
            string[] pa = poly.Split(',');
            if (pa.Length >= 11)
                {
                _mOrigin = new Point3F();
                mOrigin.x = pa[0].AsFloat();
                mOrigin.y = pa[1].AsFloat();
                mOrigin.z = pa[2].AsFloat();
                _mVector1 = new Point3F();
                mVector1.x = pa[3].AsFloat();
                mVector1.y = pa[4].AsFloat();
                mVector1.z = pa[5].AsFloat();
                _mVector2 = new Point3F();
                mVector2.x = pa[6].AsFloat();
                mVector2.y = pa[7].AsFloat();
                mVector2.z = pa[8].AsFloat();
                _mVector3 = new Point3F();
                mVector3.x = pa[9].AsFloat();
                mVector3.y = pa[10].AsFloat();
                mVector3.z = pa[11].AsFloat();
                _mOrigin.OnChangeNotification += __OnChangeNotification;
                _mVector1.OnChangeNotification += __OnChangeNotification;
                _mVector2.OnChangeNotification += __OnChangeNotification;
                _mVector3.OnChangeNotification += __OnChangeNotification;
                }
            else
                {
                throw new Exception("Bad Source Data for Polyhedron '" + poly + "'");
                }
            }


        /// <summary>
        /// Vector 1
        /// </summary>
        public Point3F mVector1
            {
            get { return _mVector1; }
            set
                {
                _mVector1 = value;
                _mVector1.DetachAllEvents();
                _mVector1.OnChangeNotification += __OnChangeNotification;
                Notify(AsString());
                }
            }

        /// <summary>
        /// Vector 2
        /// </summary>
        public Point3F mVector2
            {
            get { return _mVector2; }
            set
                {
                _mVector2 = value;
                _mVector2.DetachAllEvents();
                _mVector2.OnChangeNotification += __OnChangeNotification;
                Notify(AsString());
                }
            }

        /// <summary>
        /// Vector 3
        /// </summary>
        public Point3F mVector3
            {
            get { return _mVector3; }
            set
                {
                _mVector3 = value;
                _mVector3.DetachAllEvents();
                _mVector3.OnChangeNotification += __OnChangeNotification;
                Notify(AsString());
                }
            }

        /// <summary>
        /// Origin
        /// </summary>
        public Point3F mOrigin
            {
            get { return _mOrigin; }
            set
                {
                _mOrigin = value;
                _mOrigin.DetachAllEvents();
                _mOrigin.OnChangeNotification += __OnChangeNotification;
                Notify(AsString());
                }
            }

        #region IConvertible Members

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public TypeCode GetTypeCode()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public bool ToBoolean(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public char ToChar(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public sbyte ToSByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public byte ToByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public short ToInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public ushort ToUInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public int ToInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public uint ToUInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public long ToInt64(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public ulong ToUInt64(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public float ToSingle(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public double ToDouble(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public decimal ToDecimal(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public DateTime ToDateTime(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Converts to string
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public string ToString(IFormatProvider provider)
            {
            return AsString();
            }

        /// <summary>
        /// NotImplementedException
        /// </summary>
        /// <returns></returns>
        public object ToType(Type conversionType, IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        ~Polyhedron()
            {
            this.DetachAllEvents();
            }

        private void __OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            Notify(AsString());
            }

        /// <summary>
        /// Converts Polyhedron to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            return AsString();
            }

        /// <summary>
        /// Converts Polyhedron to string
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            if ((((object) mOrigin) != null) && (((object) mVector1) != null) && (((object) mVector2) != null) && (((object) mVector3) != null))
                return mOrigin.x.AsString() + " " + mOrigin.y.AsString() + " " + mOrigin.z.AsString() + " " + mVector1.x.AsString() + " " + mVector1.y.AsString() + " " + mVector1.z.AsString() + " " + mVector2.x.AsString() + " " + mVector2.y.AsString() + " " + mVector2.z.AsString() + " " + mVector3.x.AsString() + " " + mVector3.y.AsString() + " " + mVector3.z.AsString() + " ";
            return "";
            }
        }
    }