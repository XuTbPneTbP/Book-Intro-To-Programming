using System;
using System.Collections.Generic;

namespace _04.Sorted_Set_Rock_Bands
{
    class UnionAndIntersect
    {
        static void Main()
        {
            SortedSet<string> bugsBunnyBands = new SortedSet<string>(new[]
            {
                "Manowar", "Megadeath", "Iron Maiden", "Kiss"
            });

            SortedSet<string> daffyDuckBands = new SortedSet<string>(new[]
            {
                "Metallica", "Black Sabbath", "Slayer", "Kiss", "Iron Maiden"
            });
            Console.WriteLine("=================================================");
            Console.Write("Bugs Bunny likes: ");
            Console.WriteLine(string.Join(", ", bugsBunnyBands));
            Console.WriteLine("=================================================");
            Console.Write("Daffy Duck likes: ");
            Console.WriteLine(string.Join(", ", daffyDuckBands));
            Console.WriteLine("=================================================");

            SortedSet<string> intersectBands = new SortedSet<string>(bugsBunnyBands);
            intersectBands.IntersectWith(daffyDuckBands);

            Console.WriteLine("Does Bugs and Daffy have the same rock interest? => {0}", intersectBands.Count  < 5 ? "No!" : "Yes!");
            Console.WriteLine("'Cuz both like only => " + string.Join(" & ", intersectBands));
            Console.WriteLine("=================================================");

            SortedSet<string> allGroups = new SortedSet<string>(bugsBunnyBands);
            allGroups.UnionWith(daffyDuckBands);

            Console.WriteLine("Both band names: \n|Band|: " + string.Join("\n|Band|: ", allGroups));
        }
    }
}
