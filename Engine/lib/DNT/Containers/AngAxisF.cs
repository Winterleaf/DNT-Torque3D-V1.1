using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WinterLeaf.Classes;
namespace WinterLeaf.Containers
    {
    internal class AngAxisFIConverter : TypeConverter
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
                return new AngAxisF(value as string);
                }

            return null;
            }
        }
    [TypeConverter(typeof(AngAxisFIConverter))]
    public class AngAxisF:IConvertible
        {


        private Point3F _mAxis = new Point3F(0, 0, 0);
        private float _mAngle;

        public Point3F mAxis
            {
            get { return _mAxis; }
            set { _mAxis = value; }
            }

        public float mAngle
            {
            get { return _mAngle; }
            set { _mAngle = value; }
            }

        public AngAxisF(string angaxisf)
            {
            string[] fl = angaxisf.Split(' ');
            _mAxis.x = fl[0].AsFloat();
            _mAxis.y = fl[1].AsFloat();
            _mAxis.z = fl[2].AsFloat();
            _mAngle = fl[3].AsFloat();
            }
        public AngAxisF(Point3F axis, float angle)
            {
            _mAxis = axis;
            _mAngle = angle;
            }
        public AngAxisF(float x, float y, float z, float angle)
            {
            _mAxis.x = x;
            _mAxis.y = y;
            _mAxis.z = z;
            _mAngle = angle;
            }

        public float x
            {
            get { return _mAxis.x; }
            set { _mAxis.x = value; }
            }
        public float y
            {
            get { return _mAxis.y; }
            set { _mAxis.y = value; }
            }
        public float z
            {
            get { return _mAxis.z; }
            set { _mAxis.z = value; }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return string.Format("{0} {1} {2} {3} ", _mAxis.x, _mAxis.y, _mAxis.z, _mAngle);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
            {
            return string.Format("{0} {1} {2} {3} ", _mAxis.x, _mAxis.y, _mAxis.z, _mAngle);
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
