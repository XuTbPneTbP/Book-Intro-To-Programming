using System;

class WithBool
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit@position who will be check for value 1: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));
       //onsole.WriteLine(Convert.ToString(position, 2).PadLeft(16, '0'));
        int i = 1;
        int mask = i << position;
        bool isValue1 = (num & mask) != 0;
        if ((num & mask) != 0)
        {
            Console.WriteLine(isValue1 + " <-- bit@position {0} have value = 1", position);
        }
        else
        {
            Console.WriteLine("bit@position {0} have value = 0", position);
        }
    }
}

