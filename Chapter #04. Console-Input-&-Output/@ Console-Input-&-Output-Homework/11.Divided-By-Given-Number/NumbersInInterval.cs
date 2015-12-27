using System;

class NumbersInInterval
{
    static void Main()
    {        
        Console.Write("Enter starting number: ");
        int startingNumber = int.Parse(Console.ReadLine());

        Console.Write("End counting at: ");
        int endCount = int.Parse(Console.ReadLine());        

        for (int i = startingNumber; i <= endCount; i++)
        {           
            if (i % 5 == 0)
            {
                Console.Write(i);
                if (i < endCount - 4) //THis is a bit tricky statement. It puts you comma after execution of the first statement
                {
                    Console.Write(",");                    
                }                
            }            
        }
        Console.WriteLine();
    }
}

