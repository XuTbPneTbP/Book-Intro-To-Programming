using System;

class WithBool
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLenght];
        Console.WriteLine("Enter the {0} values of the array:", arrayLenght);
        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        bool symmetric = true;
        for (int i = 0; i < arrayLenght/2; i++)
        {
            if (array[i] != array[arrayLenght - i - 1])
            {
                symmetric = false;
                break;
            }
        }
        Console.WriteLine("Is symmetric? {0}",symmetric);
    }
}

