using System;
using System.Text;

class IntDoubleString
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Enter \n1 --> Int \n2 --> Double \n3 --> String");

        string theChoice = Convert.ToString(Console.ReadLine());

        switch (theChoice)
        {
            case "1":                
                int one = int.Parse(Console.ReadLine());
                Console.WriteLine("The Int is: {0}",one);
                break;
            case "2":                
                double two = double.Parse(Console.ReadLine());
                Console.WriteLine("The Double is: {0}",two);
                break;
            case "3":                
                string someWord = Convert.ToString(Console.ReadLine());
                Console.WriteLine("The word is: {0}" + '\u00A9', someWord);
                break;
            default:
                Console.WriteLine("No such animal!!!XAXAXA");
                break;
        }
    }
}

