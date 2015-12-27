using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hash_Function
{
    public class Point3DEqualityComparer : IEqualityComparer<Point3D>
    {
        public bool Equals(Point3D pointA, Point3D pointB)
        {
            if (pointA == pointB)
            {
                return true;
            }
            if (pointA == null || pointB == null)
            {
                return false;
            }
            if (!pointA.X.Equals(pointB.X))
            {
                return false;
            }
            if (!pointA.Y.Equals(pointB.Y))
            {
                return false;
            }
            if (!pointA.Z.Equals(pointB.Z))
            {
                return false;
            }

            return true;
        }

        public int GetHashCode(Point3D obj)
        {
            Point3D test = obj as Point3D;

            if (test == null)
            {
                return 0;
            }

            int prime = 83;
            int result = 1;

            unchecked
            {
                result = result*prime + test.X.GetHashCode();
                result = result * prime + test.Y.GetHashCode();
                result = result * prime + test.Z.GetHashCode();
            }

            return result;
        }

    }
}
