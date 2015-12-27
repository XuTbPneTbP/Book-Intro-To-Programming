using System;

class OnlyFiveIfs
{
    static void Main()
    {
        Console.Write("Enter five digits separated by space: ");
        string[] numbers = Console.ReadLine().Split();
        double one = Convert.ToDouble(numbers[0]);
        double two = Convert.ToDouble(numbers[1]);
        double three = Convert.ToDouble(numbers[2]);
        double four = Convert.ToDouble(numbers[3]);
        double five = Convert.ToDouble(numbers[4]);
        if((one > two) && (one > three) && (one > four) && (one > five))
        {
            Console.WriteLine("The bigger is {0}",one);
        }
        else if ((two > one) && (two > three) && (two > four) && (two > five))
        {
  
            Console.WriteLine("The bigger is {0}",two);
        }
        else if ((three > two) && (three > one) && (three > four) && (three > five))
        {
            Console.WriteLine("The bigger is {0}",three);    
        }
        else if ((four > two) && (four > three) && (four > one) && (four > five))
        {
            Console.WriteLine("The bigger is {0}", four);
        }
        else
        {
            Console.WriteLine("The bigger is {0}", five);
        }        
    }
}

