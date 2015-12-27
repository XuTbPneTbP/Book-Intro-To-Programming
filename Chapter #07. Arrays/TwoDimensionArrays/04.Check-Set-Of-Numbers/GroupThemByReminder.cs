using System;

class GroupThemByReminder
{
    static void Main()
    {
        int[] number = { 0, 1, 2, 3, 44, 55, 65, 42, 543, 5, 21, 432, 45, 678, 9 };
        int[] matrixSize = new int[3]; //Масив, който пази размерите,които ще попълваме в колоните 
        int[] offsets = new int[3]; //Пази данни на кой индекс сме попълнили и на кой ще трябва да попълваме
        //след това
        //Изчисляваме размера на всеки reminder (0, 1 & 2)
        foreach (var num in number)
        {
            int remainder = num % 3;
            matrixSize[remainder]++;
        }
        //Изчисляваме  големината на всеки лист от reminders
        int[][] numberByReminder = new int[3][]
        {
            new int[matrixSize[0]],
            new int[matrixSize[1]],
            new int [matrixSize[2]]
        };
        //Обикаляме всички числа
        foreach (var num in number)
        {
            int remainder = num % 3;
            int index = offsets[remainder];
            numberByReminder[remainder][index] = num;
            offsets[remainder]++;
        }
        //Print result
        for (int row = 0; row < numberByReminder.GetLength(0); row++)
        {
            foreach (var num in numberByReminder[row])
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
