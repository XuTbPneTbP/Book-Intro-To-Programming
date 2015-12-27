using System;

class Program
{
    static void Main()
    {
        //Правим си масив от числа
        int[] числа = { 2, 3, 654, 754, 13, 654, 797, 6, 543, 122 };
         
        //Правим си нов масив, който ще ни сортира, числата по reminder --> 0, 1 и 2
        int[] sizes = new int[3];
        //Със foreach пълним елементите на sizes според reminder-а
        foreach (var number in числа)
        {
            //Правим си променлива,чрез която ще определим дължината на елементите на sizes
            int remainder = number % 3;
            sizes[remainder]++;
        }
        //След като вече знаем дължината на всеки елемент от sizes,  може да си създадем марица - jagged матрица, която да пълним със съответните числа, по reminder. За целта jagged ще използваме дължината на елементите от sizes[]
        int[][] numbersByRemainder = new int[3][] { 
        new int[sizes[0]], new int[sizes[1]], new int[sizes[2]]
        };
    }
}

