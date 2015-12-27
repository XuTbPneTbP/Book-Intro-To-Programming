using System;

namespace _02.DoubleLinkedList
{
    class Program
    {
        static void Main()
        {
            CustomDoubleLinked<int> nums = new CustomDoubleLinked<int>();
            //nums.AddRange(new int[] { 12, 18, 22 });
            //nums.ForEach(Console.WriteLine);
            //Console.WriteLine("Number of elements = > " + nums.Count);

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                nums.Add(rnd.Next(1, (int)Math.Pow(10, 2)));
            }
            nums.Add(13);
            Console.WriteLine("Number of elements = > " + nums.Count);
            Console.WriteLine("======================================================");
            Console.WriteLine("| 0 || 1 || 2 || 3 || 4 || 5 || 6 || 7 || 8 || 9 || 10|| 11|| 12|| 13|");
            Console.WriteLine("---------------------------------------------------------");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write("|{0,3}|", nums[i]);
            }
            Console.WriteLine();
           
            Console.WriteLine("=================================");

            Console.WriteLine("RemovedAt(3) = > " + nums.RemoveAt(3));
            Console.WriteLine("======================================================");
            Console.WriteLine("| 0 || 1 || 2 || 3 || 4 || 5 || 6 || 7 || 8 || 9 || 10|| 11|| 12|| 13|");
            Console.WriteLine("---------------------------------------------------------");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write("|{0,3}|", nums[i]);
            }
            Console.WriteLine();

            Console.WriteLine("=================================");

            Console.WriteLine("Remove(13) = > " + nums.Remove(13));
            Console.WriteLine("======================================================");
            Console.WriteLine("| 0 || 1 || 2 || 3 || 4 || 5 || 6 || 7 || 8 || 9 || 10|| 11|| 12|| 13|");
            Console.WriteLine("---------------------------------------------------------");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write("|{0,3}|", nums[i]);
            }
            Console.WriteLine();

            Console.WriteLine("=================================");
        }
    }
}
