﻿using System;

class WithForLoop
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());        
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);          
        }
    }
}
