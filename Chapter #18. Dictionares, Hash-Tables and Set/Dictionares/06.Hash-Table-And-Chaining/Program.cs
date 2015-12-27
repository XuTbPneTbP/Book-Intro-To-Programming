using System;
using System.Collections.Generic;
using System.Linq;
using _05.Hash_Function;

namespace _06.Hash_Table_And_Chaining
{
    // Resolve collisions
    public  class Program
    {
        static void Main()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("KeyValuePair.cs");

            KeyValuePair<int, int> test1 = new KeyValuePair<int, int>(12, 8);
            KeyValuePair<string, int> test2 = new KeyValuePair<string, int>("Zaiko Baiko", 22);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("CustomHashDictionary.cs");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

            CustomHashDictionary<string, int> students = new CustomHashDictionary<string, int>();
            students.Set("Dragan", 21);
            students.Set("Mirko", 34);
            students.Set("Ceca Mirkovi4", 78);
            students.Set("Bai Gino", 101);

            
            Console.WriteLine("Students: ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

            foreach (KeyValuePair<string, int> opsa in students)
            {
                Console.Write("Key = > |{0,-15}|", opsa.Key);
                Console.WriteLine(" Value = > |{0,5}|", opsa.Value);
            }

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Cartoon characters: ");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");

            CustomHashDictionary<string, int> cartoonCharacters = new CustomHashDictionary<string, int>(16, 0.75f);
            cartoonCharacters["Bugs Bunny"] = 2;
            cartoonCharacters["Franki"] = 3;
            cartoonCharacters["Taz"] = 69;
            cartoonCharacters.Set("Daffy Duck", 16);
            cartoonCharacters.Set("Daffy Duck", 16);
            cartoonCharacters.Set("Elmaira", 17);
            
            foreach (KeyValuePair<string, int> opsa in cartoonCharacters)
            {
                Console.Write("Key = > |{0,-15}|", opsa.Key);
                Console.WriteLine(" Value = > |{0,5}|", opsa.Value);
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(cartoonCharacters.Remove("Elmaira"));
            

            CustomHashDictionary<Point3D, int> testSubject = new CustomHashDictionary<Point3D, int>(3, 0.9f);

            testSubject.Set(new Point3D(1, 2, 3), 18);
            Console.WriteLine(testSubject[new Point3D(1, 2, 3)]);

            testSubject[new Point3D(1, 2, 3)] +=18;
            Console.WriteLine(testSubject[new Point3D(1, 2, 3)]);

            testSubject[new Point3D(3, 2, 2)] = 42;
            Console.WriteLine(testSubject[new Point3D(3, 2, 2)]);

            Console.WriteLine(testSubject[new Point3D(1, 2, 3)]);

            testSubject[new Point3D(4, 5, 6)] = 1042;

            testSubject.Remove(new Point3D(3, 2, 2));


            foreach (KeyValuePair<Point3D, int> entry in testSubject)
            {
                Console.WriteLine("Key: " + entry.Key + "; Value: " + entry.Value);
            }
        }
    }

    
}
