using System;

class Example
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int   numberInBin = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(numberInBin, 2).PadLeft(16, '0'));
       
        Console.Write("Enter bit @ position: ");
        int bitAtPosition = int.Parse(Console.ReadLine());  
  
        Console.WriteLine("Choose new bit value 0 or 1 : ");
        int newBitValue = int.Parse(Console.ReadLine());

        int maskPositive = 1 << bitAtPosition;
       // Console.WriteLine(maskPositive);
        int resultPositive = numberInBin | maskPositive;

        int maskNegative = ~ (1 << bitAtPosition);
        int resultNegative = numberInBin & maskNegative;

        if (newBitValue == 0)
        {
            Console.WriteLine(Convert.ToString(resultNegative,2).PadLeft(16, '0') + " <--  is the number {0}",resultNegative);
        }
        else
        {
            Console.WriteLine(Convert.ToString(resultPositive,2).PadLeft(16, '0') + " <-- is the number {0}",resultPositive);
        }
    }
}

