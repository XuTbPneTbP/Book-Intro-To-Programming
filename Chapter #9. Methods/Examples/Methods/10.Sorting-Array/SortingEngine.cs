using System;

class SortingEngine
{
    static void Main()
    {
        int[] numbers = SortNumbers(10, 3, 5, -1, 0, 12, 8);
        PrintNumbers(numbers);
    }

    static int[] SortNumbers(params int[] numbers)
    {
        //Sorting logic
        for (int i = 0; i < numbers.Length -1; i++)
        {
            //Loop wich operates under the un-sorted part of the array --> the loop search for the minimal element at each step and if find it --> replace it /swap it/ with the first element of the array
            for (int j = i+1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int oldNum = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = oldNum;
                }
            }            
        }// End of sorting logic
        return numbers;
    }
    static void PrintNumbers(params int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0}",numbers[i]);
            if (i < (numbers.Length-1))
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

