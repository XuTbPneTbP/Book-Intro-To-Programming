using System;

class CheckBitOnPosition
{
    static void Main()
    {
        Console.Write("Enter digit: ");
        int num = int.Parse(Console.ReadLine());      
        Console.WriteLine(Convert.ToString(num,2).PadLeft(16,'0'));       
        Console.Write("Enter bit position for check: ");
        int position = int.Parse(Console.ReadLine());
       // Console.WriteLine(Convert.ToString(position, 2).PadLeft(16, '0'));
        int i = 1;
        Console.WriteLine(Convert.ToString(i, 2).PadLeft(16, '0'));
        int mask = i << position;
        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0') + " <-- is the number {0}", mask);
        Console.WriteLine(((num & mask) != 0 ? 1 : 0) + " <-- is bit @ position {0}",position);
    }
}

