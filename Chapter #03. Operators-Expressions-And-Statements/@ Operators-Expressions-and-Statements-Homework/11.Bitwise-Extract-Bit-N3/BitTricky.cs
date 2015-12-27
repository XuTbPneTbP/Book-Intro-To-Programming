using System;

class BitTricky
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int thirdBitCheck = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(thirdBitCheck,2).PadLeft(16,'0') +
        " <-- This is the representation of the number {0}",thirdBitCheck); 
        
        int thirdBit = thirdBitCheck >> 3;
        Console.WriteLine(thirdBit);

        Console.WriteLine(Convert.ToString(thirdBit,2).PadLeft(16, '0') +
        " <-- This is the representation of the number {0}",thirdBit);

        int bit = thirdBit & 1;  // check if bit & 1 returns 1, besides with & 0 returns always 0         
        Console.WriteLine("Third bith value is {0}",bit); 
 
    }
}

