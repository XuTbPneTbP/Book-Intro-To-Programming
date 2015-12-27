using System;

class MethodsWithParameters
{   // Метода е начин  да запазваме или показваме нашите намерения.Качеството е важно!!
    static double CalcTriangleArea(double width, double height)
    {                                 // аргументи на метода  
        return width * height / 2;
    }

    static void Main()
    {
        Console.Write("Enter triangle width: ");
        double w = double.Parse(Console.ReadLine());
        Console.Write("Enter triangle height: ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine(CalcTriangleArea(w, h));
    }
}
