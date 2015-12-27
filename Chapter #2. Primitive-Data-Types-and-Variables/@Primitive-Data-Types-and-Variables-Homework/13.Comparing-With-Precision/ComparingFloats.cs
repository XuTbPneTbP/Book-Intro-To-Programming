using System;
// use comma instead of dot
class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter two digits who will be compared with precision eps = 0.000001:  ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        if (Math.Abs((a - b) / b) < eps)
        {

            Console.WriteLine("{0} = {1} They are equal! eps {2} < 0.000001", a, b, (a - b) / b);
        }
        else  
        {
            Console.WriteLine("This numbers {0} and {1} are not equal. The reminder is  {2}", a, b, (a - b) / b);
        }
      
    }
    
}

