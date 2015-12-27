using System;
using System.Collections.Generic;

namespace _05.Hash_Function
{
    class Program
    {
        static void Main()
        {
            Point3D pointAlpha = new Point3D(12, 17, 17);
            Point3D pointBeta = new Point3D(18, 11, 11);

            // Gives us hash representation of the key in int => override GetHashCode() metod
            Console.WriteLine("Point (A): \n{0} \nHash code= > {1}", pointAlpha, pointAlpha.GetHashCode());
            Console.WriteLine("=================================================");

            Console.WriteLine("Point (B): \n{0} \nHash code= > {1}", pointBeta, pointBeta.GetHashCode());
            Console.WriteLine("=================================================");

            // Compare for equality of the points => override Equals() method
            bool equalPoints = pointBeta.Equals(pointAlpha);
            Console.WriteLine("Equal points = >  {0} ", equalPoints);
            Console.WriteLine("=================================================");

            IEqualityComparer<Point3D> comparer = new Point3DEqualityComparer();
            Dictionary<Point3D, int> pointCollection = new Dictionary<Point3D, int>(comparer);


            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                double x =rnd.Next(1, 10);
                double y = rnd.Next(11, 20);
                double z = rnd.Next(21, 31);
                pointCollection.Add(new Point3D(x, y, z), i);

            }

            pointCollection[new Point3D(12, 118, 11)] = 5;
            pointCollection[new Point3D(12, 118, 11)] = 5;
            pointCollection[new Point3D(18, 11, 11)] = 12;
            pointCollection[new Point3D(127, 0, 161)] = 13;
            Console.WriteLine("|{0,30}| |{1,15}|", "Key", "Value");
            foreach (var point in pointCollection)
            {
                Console.Write("Point: {0} = > Value: |{1}| ", point.Key, point.Value);
                Console.WriteLine("Hash code => |{0,15}|", comparer.GetHashCode(point.Key));
            }


           
            
        }

        
        
    }
}
