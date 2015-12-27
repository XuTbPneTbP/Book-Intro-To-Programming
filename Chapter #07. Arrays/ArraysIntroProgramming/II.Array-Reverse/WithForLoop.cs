using System;

class WithForLoop
{
    static void Main()
    {
        int[] array = { 12, 34, -13, 35, 14, 36, 15, 37 };
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write(array[index] + " ");
        }

        //Get array size
        int lenght = array.Length;

        //Declare and create the reversed array
        int[] reversed = new int[lenght];

        //Initialize the reversed array
        for (int index = 0; index < lenght; index++)
        {
            reversed[lenght - index - 1] = array[index];
        }
        Console.WriteLine();

        //Print the reversed array
        for (int index = 0; index < lenght; index++)
        {
            Console.Write(reversed[index] + " ");
        }
        Console.WriteLine();        
    }
}

