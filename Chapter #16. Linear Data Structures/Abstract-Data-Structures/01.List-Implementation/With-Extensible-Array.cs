using System;

namespace _01.List_Implementation
{
    public class WithExtensibleArray :  PrintCustomLisTs
    {
        static void Main()
        {
            Console.WriteLine("We will add the numbers [ 12, 17, 22, 0, 19 ] to a List<int>");
            
            CustomArrayList<int> nums = new CustomArrayList<int>();
            nums.Add(12);
            nums.Add(17);
            nums.Add(22);
            nums.Add(0);
            nums.Add(19);
            //Console.WriteLine(nums.RemoveAt(2));
            //PrintCustomList(nums);
            //nums.Clear();
            Console.WriteLine("##############################");
            MesureExecutionTime(nums);

        }

       
    }
}
