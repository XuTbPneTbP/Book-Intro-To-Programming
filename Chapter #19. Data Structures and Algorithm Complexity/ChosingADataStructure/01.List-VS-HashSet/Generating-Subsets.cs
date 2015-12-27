using System;
using System.Collections;
using System.Collections.Generic;

namespace _01.List_VS_HashSet
{
    class GeneratingSubsets
    {
        //static string[] cars = { "Audi R8", "BMW i8", "Mercedes CLK GTR 640", "Porche Carrera 911", "Dodge Viper", "Ferrari", "Aston Martin", "Lamborgini Diablo f7" };
        static string[] cars = { "Audi R8", "BMW i8", "Mercedes CLK" };
        static void Main()
        {
            // With a data struchture HashSet we can quickly add elements
            // and check whether given element belongs to a set.
            // We can't avoid duplicates!!!
            QueueWithHashSet();
        }

        private static void QueueWithHashSet()
        {
            Queue<HashSet<string>> carSubsets = new Queue<HashSet<string>>();

            // We add the empty set first
            HashSet<string> emptySet = new HashSet<string>();

            // Enqueue означава да добавим най-отзад в опашката
            carSubsets.Enqueue(emptySet);

            while (carSubsets.Count > 0)
            {
                HashSet<String> subset = carSubsets.Dequeue();

                // Print current subset
                Console.Write("{ ");
                foreach (var word in subset)
                {
                    Console.Write("|{0, -15}| ", word);
                }
                Console.WriteLine("}");

                // Generate and enqueue all possible subsets
                foreach (string element in cars)
                {
                    if (!subset.Contains(element))
                    {
                        HashSet<string> newSubset = new HashSet<string>();
                        newSubset.UnionWith(subset);
                        newSubset.Add(element);
                        carSubsets.Enqueue(newSubset);
                    }
                }
            }
        }
    }
}
