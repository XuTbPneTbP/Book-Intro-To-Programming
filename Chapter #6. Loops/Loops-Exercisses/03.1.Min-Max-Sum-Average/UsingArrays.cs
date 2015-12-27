using System;

class UsingArrays
{
    static void Main()
    {
        Console.Write("Enter digit for lenght of numbers: ");
        int numbers = int.Parse(Console.ReadLine());

        int[] низОтЧисла = new int[numbers];          // Създаваме си масив и го кръщаваме низОтЧисла.

        for (int i = 0; i < numbers; i++)
        {
            Console.Write("{0}: ", i + 1);
            низОтЧисла[i] = Convert.ToInt32(Console.ReadLine()); //Чрез For Loop пълним масива с числа
        }

        int min = низОтЧисла[0];
        int max = низОтЧисла[0];
        int sum = 0;
        // Разделя сумата на числата на техния брой:  6+7+11 = 24 => 24/3 числа = 8
        double average = 0;                    

        for (int i = 0; i < numbers; i++)
        {
            // Сумата плюс следващото число от масива, което сме въвели
            sum += низОтЧисла[i];             

            if (min > низОтЧисла[i])
            {
                min = низОтЧисла[i];
            }
            if (max < низОтЧисла[i])
            {
                max = низОтЧисла[i];
            }
        }
        average = (double)sum / numbers;

        Console.WriteLine();

        Console.WriteLine("Min\t: {0}", min);
        Console.WriteLine("Max\t: {0}", max);
        Console.WriteLine("Sum Min + Max numbers\t: {0}", (min) + (max));
        Console.WriteLine("Average\t: {0,2:n} --> sum/numbers", average);
    }
}

