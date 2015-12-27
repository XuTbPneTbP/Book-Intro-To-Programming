using System;
using System.Collections;

namespace _03ArrayListExample
{
    public class Examples
    {
        public static void ElementsFromDifferentTypes()
        {
            ArrayList list = new ArrayList();
            list.AddRange(new object[] { "Bugs Bunny", 5, DateTime.Now, 3.14159, "Сашка Васева" });
            for (int i = 0; i < list.Count; i++)
            {
                object value = list[i];
                Console.WriteLine("Index |{0}| = > Value |{1,20}|", i, value);
            }
        }

        public static void ArrayListOfNumbers()
        {
            ArrayList list = new ArrayList();
            list.AddRange(new object[] { 2, 3.5f, 25u, " USD" });
            dynamic sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                // dynamic is universal data type intended to hold any value(numbers, string...)
                dynamic value = list[i];
                sum += value;
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
