using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WinterLeaf.Classes;

namespace WinterLeaf.Containers
    {
    internal class EaseFIConverter : TypeConverter
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
                return new EaseF(value as string);
                }

            return null;
            }
        }
    [TypeConverter(typeof(EaseFIConverter))]
    public class EaseF:IConvertible
        {
        private int _mDirection;
        private int _mType;
        private int _mParam1;
        private int _mParam2;

        public int mDirection
            {
            get { return _mDirection; }
            set { _mDirection = value; }
            }

        public int mType
            {
            get { return _mType; }
            set { _mType = value; }
            }

        public int mParam1
            {
            get { return _mParam1; }
            set { _mParam1 = value; }
            }

        public int mParam2
            {
            get { return _mParam2; }
            set { _mParam2 = value; }
            }

        public EaseF(string easef)
            {
            string[] v = easef.Split(' ');
            _mDirection = v[0].AsInt();
            _mType = v[1].AsInt();
            try
                {
                _mParam1 = v[2].AsInt();
                _mParam2 = v[3].AsInt();
                }
            catch (Exception)
                {
                    
                }
            }

        public EaseF(int direction,int type)
            {
            _mDirection = direction;
            _mType = type;
            }
        public EaseF(int direction, int type,int param1)
            {
            _mDirection = direction;
            _mType = type;
            _mParam1 = param1;

            }
        public EaseF(int direction, int type, int param1, int param2)
            {
            _mDirection = direction;
            _mType = type;
            _mParam1 = param1;
            _mParam2 = param2;

            }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string AsString()
            {
            return string.Format("{0} {1} {2} {3} ", _mDirection, _mType, _mParam1, _mParam2);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
            {
            return string.Format("{0} {1} {2} {3} ", _mDirection, _mType, _mParam1, _mParam2);
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
