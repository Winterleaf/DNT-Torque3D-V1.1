﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WinterLeaf.Classes;
namespace WinterLeaf.Containers
    {
    internal class RectFIConverter : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return (typeof(string) == sourceType);
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
                return new RectF(value as string);
                }

            return null;
            }
        }
    [TypeConverter(typeof(RectFIConverter))]
    public class RectF : IConvertible
        {
        private Point2F _mPoint = new Point2F(0, 0);
        private Point2F _mExtent = new Point2F(0, 0);

        public RectF(string recti)
            {
            string[] vals = recti.Split(',');
            _mPoint.x = vals[0].AsFloat();
            _mPoint.y = vals[1].AsFloat();
            _mExtent.x = vals[2].AsFloat();
            _mExtent.y = vals[3].AsFloat();
            }
        public RectF(Point2F point, Point2F extent)
            {
            _mPoint = point;
            _mExtent = extent;
            }


        public Point2F mPoint
            {
            get { return _mPoint; }
            set { _mPoint = value; }
            }

        public Point2F mExtent
            {
            get { return _mExtent; }
            set { _mExtent = value; }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return string.Format("{0} {1} {2} {3} ", _mPoint.x.AsString(), _mPoint.y.AsString(), _mExtent.x.AsString(), _mExtent.y.AsString());
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
            {
            return string.Format("{0} {1} {2} {3} ", _mPoint.x.AsString(), _mPoint.y.AsString(), _mExtent.x.AsString(), _mExtent.y.AsString());
            }

        public TypeCode GetTypeCode()
            {
            throw new NotImplementedException();
            }

        public bool ToBoolean(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public char ToChar(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public sbyte ToSByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public byte ToByte(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public short ToInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public ushort ToUInt16(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public int ToInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public uint ToUInt32(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public long ToInt64(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public ulong ToUInt64(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public float ToSingle(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public double ToDouble(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public decimal ToDecimal(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public DateTime ToDateTime(IFormatProvider provider)
            {
            throw new NotImplementedException();
            }

        public string ToString(IFormatProvider provider)
            {
            return AsString();
            }

        public object ToType(Type conversionType, IFormatProvider provider)
            {
            throw new NotImplementedException();
            }
        }
    }