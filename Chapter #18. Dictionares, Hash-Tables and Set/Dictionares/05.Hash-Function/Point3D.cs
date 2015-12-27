using System;

namespace _05.Hash_Function
{
    public class Point3D
    {
        public double X{ get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        
        public Point3D(double x, double y, double z )
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Point3D()
        {
        }

        public override string ToString()
        {
            return String.Format("X: ({0}), Y: ({1}), Z: ({2})", this.X, this.Y, this.Z);
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            Point3D test = obj as Point3D;

            if (test == null)
            {
                return false;
            }

            if (!this.X.Equals(test.X))
            {
                return false;
            }
            if (!this.Y.Equals(test.Y))
            {
                return false;
            }
            if (!this.Z.Equals(test.Z))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int prime = 83;
            int result = 1;
            unchecked
            {
                result = result*prime + X.GetHashCode();
                result = result * prime + Y.GetHashCode();
                result = result * prime + Z.GetHashCode();
            }

            return result;
        }


    }
}
