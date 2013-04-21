using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WinterLeaf.Classes;
using WinterLeaf.Containers;

namespace WinterLeaf.Containers
    {


    internal class Point4FIConverter : TypeConverter
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
                return new Point4F(value as string);
                }

            return null;
            }
        }
    [TypeConverter(typeof(Point4FIConverter))]
    public class Point4F : IConvertible
        {

        private float _mX;
        private float _mY;
        private float _mZ;
        private float _mW;

        public float X
            {
            get { return _mX; }
            set { _mX = value; }
            }

        public float Y
            {
            get { return _mY; }
            set { _mY = value; }
            }

        public float Z
            {
            get { return _mZ; }
            set { _mZ = value; }
            }

        public float W
            {
            get { return _mW; }
            set { _mW = value; }
            }


        public Point4F(string point4f)
            {
            string[] val = point4f.Split(' ');
            X = val[0].AsFloat();
            Y = val[1].AsFloat();
            Z = val[2].AsFloat();
            W = val[3].AsFloat();
            }

        public Point4F(float x, float y, float z, float w)
            {
            X = x;
            Y = y;
            Z = z;
            W = w;
            }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return string.Format("{0} {1} {2} {3} ", X.AsString(), Y.AsString(), Z.AsString(), W.AsString());
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
            {
            return string.Format("{0} {1} {2} {3} ", X.AsString(), Y.AsString(), Z.AsString(), W.AsString());
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
