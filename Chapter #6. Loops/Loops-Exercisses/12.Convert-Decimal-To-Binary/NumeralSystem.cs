using System;

class NumeralSystem
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string command = Console.ReadLine();
        while (command != "end")
        {
            int n = int.Parse(command);
            Console.WriteLine("Binary representation of {0} is: \n{1}", n, Convert.ToString(n, 2));
            command = Console.ReadLine();
        }
        

        
    }
}

