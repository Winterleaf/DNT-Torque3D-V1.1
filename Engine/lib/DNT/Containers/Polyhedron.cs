using System;
using System.ComponentModel;
using WinterLeaf.Classes;

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
                return new Polyhedron(value as string);
                }

            return null;
            }
        }
    [TypeConverter(typeof(PolyhedronIConverter))]
    public class Polyhedron : TypeConverter
        {
        /// <summary>
        /// Initializes a new instance of the Polyhedron class.
        /// </summary>

        private Point3F _mOrigin = new Point3F();

        private Point3F _mVector1 = new Point3F(0, 0, 0);

        private Point3F _mVector2 = new Point3F(0, 0, 0);

        private Point3F _mVector3 = new Point3F(0, 0, 0);


        public Polyhedron()
            {
            }

        public Polyhedron(string poly)
            {
            string[] pa = poly.Split(',');
            if (pa.Length >= 11)
                {
                mOrigin.x = pa[0].AsFloat();
                mOrigin.y = pa[1].AsFloat();
                mOrigin.z = pa[2].AsFloat();
                mVector1.x = pa[3].AsFloat();
                mVector1.y = pa[4].AsFloat();
                mVector1.z = pa[5].AsFloat();
                mVector2.x = pa[6].AsFloat();
                mVector2.y = pa[7].AsFloat();
                mVector2.z = pa[8].AsFloat();
                mVector3.x = pa[9].AsFloat();
                mVector3.y = pa[10].AsFloat();
                mVector3.z = pa[11].AsFloat();
                }
            else
                {
                throw new Exception("Bad Source Data for Polyhedron '" + poly + "'");
                }

            }

        public override string ToString()
            {
            return mOrigin.x.AsString() + " " + mOrigin.y.AsString() + " " + mOrigin.z.AsString() + " " + mVector1.x.AsString() + " " + mVector1.y.AsString() + " " + mVector1.z.AsString() + " " + mVector2.x.AsString() + " " + mVector2.y.AsString() + " " + mVector2.z.AsString() + " " + mVector3.x.AsString() + " " + mVector3.y.AsString() + " " + mVector3.z.AsString() + " ";
            }
        public string AsString()
            {
            return mOrigin.x.AsString() + " " + mOrigin.y.AsString() + " " + mOrigin.z.AsString() + " " + mVector1.y.AsString() + " " + mVector1.z.AsString() + " " + mVector2.x.AsString() + " " + mVector2.y.AsString() + " " + mVector2.z.AsString() + " " + mVector3.x.AsString() + " " + mVector3.y.AsString() + " " + mVector3.z.AsString() + " ";
            }



        public Point3F mVector1
            {
            get { return _mVector1; }
            set { _mVector1 = value; }
            }

        public Point3F mVector2
            {
            get { return _mVector2; }
            set { _mVector2 = value; }
            }

        public Point3F mVector3
            {
            get { return _mVector3; }
            set { _mVector3 = value; }
            }

        public Point3F mOrigin
            {
            get { return _mOrigin; }
            set { _mOrigin = value; }
            }
        }
    }