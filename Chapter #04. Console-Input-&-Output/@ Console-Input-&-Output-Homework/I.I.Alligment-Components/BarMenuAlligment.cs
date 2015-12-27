using System;

class BarMenuAlligment
{
    static void Main()
    {
        string cola = "Coca Cola";
        double colaPrice = 1.20;
        string kamenitza = "Kamenitza";
        double kamenitzaPrice = 1.50;
        string kremKaramel = "Krem Karamel";
        double kremKaramelPrice = 1.65;

        Console.WriteLine("using standart Output: ");
        Console.WriteLine();
        Console.WriteLine("Menu: ");
        Console.WriteLine("1. {0} - {1}",cola,colaPrice);
        Console.WriteLine("2. {0} - {1}",kamenitza,kamenitzaPrice);
        Console.WriteLine("3. {0} - {1}",kremKaramel,kremKaramelPrice);
        Console.WriteLine();

        Console.WriteLine("using Formating Output: ");
        Console.WriteLine();
        string feed = "пържола";
        Console.WriteLine("|1. {0, -15} | {1, 10:c}|", cola, colaPrice);
        Console.WriteLine("|2. {0, -15} | {1, 10:c}| + {2} бонус!!!", kamenitza, kamenitzaPrice, feed);
        Console.WriteLine("|3. {0, -15} | {1, 10:c}|", kremKaramel, kremKaramelPrice);
        Console.WriteLine();
        Console.WriteLine("{0, 33}", "XA-XA-XA-XA!!");
        Console.WriteLine();
        Console.WriteLine("the hex value of {0} is {0:x10}", 325648797);
    }
}

