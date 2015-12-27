using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ListVsHashTable
{
    class Program
    {
        static void Main()
        {
            //ListExecutionTime();
            //SuckAZWithMarks();
        }

        private static void SuckAZWithMarks()
        {
            IDictionary<string, double> studentMarks = new Dictionary<string, double>(6);

            studentMarks["John Rambo"] = 3.00;
            studentMarks["Bugs Bunny"] = 4.20;
            studentMarks["Daffy Duck"] = 1.00;
            studentMarks["Tazmanian Devil"] = 5.40;
            studentMarks["Trifon"] = 2.50;
            studentMarks["Slavka Kalcheva"] = -1.23;

            double slavkaMark = studentMarks["Slavka Kalcheva"];

            Console.WriteLine("Does Slavka have mark?: {0}", studentMarks.TryGetValue("Slavka Kalcheva", out slavkaMark));

            Console.WriteLine("Slavka's mark is: {0:0.00}", slavkaMark);

            Console.WriteLine("==========================================>");

            Console.WriteLine("Slavka's mark removed!");
            studentMarks.Remove("Slavka Kalcheva");

            Console.WriteLine("Is this bitch Slavka in the dictionary?: {0}",
                studentMarks.ContainsKey("Slavka Kalcheva") ? "Yes" : "No this bitch is out!!!");

            Console.WriteLine("==========================================>");

            Console.WriteLine("Trifon mark is: {0:0.00}", studentMarks["Trifon"]);
            studentMarks["Trifon"] = 2.56;

            Console.WriteLine("But we all know that he deserve: {0:0.00}", studentMarks["Trifon"]);

            Console.WriteLine("==========================================>");

            double tazMark;
            bool findTazMark = studentMarks.TryGetValue("Tazmanian", out tazMark);

            Console.WriteLine("Is Tazmanian mark in the dictionary?: {0}", findTazMark);

            studentMarks["Tazmanian"] = 6.00;
            findTazMark = studentMarks.TryGetValue("Tazmanian", out tazMark);

            Console.WriteLine("Once again! Is Tazmanian mark in the deictionary?: {0}", findTazMark);
            Console.WriteLine("The mark is: {0}", tazMark);

            Console.WriteLine("==========================================>");

            Console.WriteLine("Students with marks:");

            foreach (KeyValuePair<string, double> studentMark in studentMarks)
            {
                Console.WriteLine("Student: {0} have mark: {1:0.00}", studentMark.Key, studentMark.Value);
            }

            Console.WriteLine("==========================================>");

            Console.WriteLine("There are {0} students in this SHIT!", studentMarks.Count);

            Console.WriteLine("==========================================>");

            Console.WriteLine("Now I'll clear all this SUCK@zZZ!!!");
            Console.WriteLine("Delete...!");
            studentMarks.Clear();
            Console.WriteLine(@"Is all SUCK@zZZ gone from the dictionary? {0}", studentMarks.Count == 0);
        }

        private static void ListExecutionTime()
        {
            List<int> someList = new List<int>();

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i <= 100000; i += 5)
            {
                someList.Add(i);

                if (i.Equals(99995))
                {
                    Console.WriteLine("{0} => Found!", i);
                    sw.Stop();
                    Console.WriteLine("Time taken: {0}ms", sw.Elapsed.Milliseconds);
                }
                else
                {
                    Console.WriteLine("{0} => Not Found!", i);
                }
            }

        }

    }
}
