using System;
using System.Collections.Generic;

namespace _03.Hash_Set_Students
{
    class UnionAndIntersect
    {
        static void Main()
        {
            //=> List doesn't support Union and Intersect
            HashSet<string> sportCars = new HashSet<string>();
            sportCars.Add("Ferrari");
            sportCars.Add("Lada Niva");
            sportCars.Add("Lamborgini");
            sportCars.Add("Lada 1500s");
            Console.WriteLine("Sport Cars are: \n" + string.Join(", ", sportCars));
            Console.WriteLine("=======================================================");

            HashSet<string> offroadCars = new HashSet<string>();
            offroadCars.Add("Mitsubishi Pajero");
            offroadCars.Add("Lada Niva");
            offroadCars.Add("BMW X5");
            offroadCars.Add("Lada 1500s");
            Console.WriteLine("Offroad Cars are: \n" + string.Join(", ", offroadCars));
            Console.WriteLine("=======================================================");
            AllVechicles_UnionExample(sportCars, offroadCars);
            Console.WriteLine("=======================================================");
            ModelInBoth_IntersectExample(sportCars, offroadCars);
           
        }

        private static void ModelInBoth_IntersectExample(HashSet<string> sportCars, HashSet<string> offroadCars)
        {
            HashSet<string> intesectModel = new HashSet<string>(sportCars);
            intesectModel.IntersectWith(offroadCars);

            Console.WriteLine("Model in both categories: \nModel: " + string.Join("\nModel: ", intesectModel));
        }

        private static void AllVechicles_UnionExample(HashSet<string> sportCars, HashSet<string> offroadCars)
        {
            HashSet<string> allVechicles = new HashSet<string>();

            allVechicles.UnionWith(sportCars);
            allVechicles.UnionWith(offroadCars);

            Console.WriteLine("All vechicles =>\nModel: " + string.Join("\nModel: ", allVechicles));
        }
    }
}
