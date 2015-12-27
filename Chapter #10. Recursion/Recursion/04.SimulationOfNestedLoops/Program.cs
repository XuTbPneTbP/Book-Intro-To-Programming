using System;

class Program
{
    static void Main()
    {
        // n = 2 --> което означава общо три цикъла: 0,1,2;
        // к = 3 --> числото, до което ще въртят циклите
        int k = int.Parse(Console.ReadLine());

        for (int a1 = 1; a1 <= k; a1++)
        {
            for (int a2 = 1; a2 <= k; a2++)
            {
                //Console.WriteLine("{0} {1} ", a1, a2);  
                for (int a3 = 1; a3 <= k; a3++)
                {
                Console.WriteLine("{0} {1} ", a1, a2,a3);
                }
            }            
        }
    }
}

