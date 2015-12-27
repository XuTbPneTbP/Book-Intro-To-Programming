using System;

class WithToCharArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write number in Hexadecimal format:");
        string hecadecimalInput = Console.ReadLine();

        decimal decValue = Convert.ToInt32(hecadecimalInput, 16);

        Console.WriteLine("Hexadecimal value ({0}) have decimal representation ({1})", hecadecimalInput, decValue);

        Console.WriteLine("=========================================");

        char[] values = hecadecimalInput.ToCharArray();

        foreach (char letter in values)
        {
            // Get the integral value of the character. 
            int value = Convert.ToInt32(letter);

            // Convert the decimal value to a hexadecimal value in string form. 
            Console.WriteLine("Hexadecimal value of {0} is {1:X}", letter, value);
        }
    }
}

