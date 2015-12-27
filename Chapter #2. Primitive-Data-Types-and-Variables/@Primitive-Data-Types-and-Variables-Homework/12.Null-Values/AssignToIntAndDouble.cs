using System;
//use comma instead of dot for doubles
class AssignToIntAndDouble
{
    static void Main()
    {
        int? firstNull = null;
        double? secondNull = null;
        Console.WriteLine("firstNull value --> {0}", firstNull == null ? "null" : "not null");
        Console.WriteLine("secondNull value -->{0}", secondNull == null ? "null" : "not null");
        Console.WriteLine("Enter two digits");
        Console.WriteLine("int: ");        
         firstNull = int.Parse(Console.ReadLine());
         Console.WriteLine("double: ");
         secondNull = double.Parse(Console.ReadLine());
         Console.WriteLine("firstNull have value --> " + firstNull);
         Console.WriteLine("secondNull have value --> " + secondNull);
    }
}

