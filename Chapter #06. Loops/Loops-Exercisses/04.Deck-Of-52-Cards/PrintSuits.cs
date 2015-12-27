using System;
using System.Text;
namespace _04.Deck_Of_52_Cards
{
    class PrintSuits: Printer
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Black; 
            Console.Title = "pepi";
            Console.OutputEncoding = Encoding.UTF8;
               
            int[] cards = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] bigOnes = { "J", "Q", "K", "A" };

         //   Console.WriteLine("Enter: " +
                              //" \n1 --> heart '\u2665'" +
                              //" \n2 --> club '\u2663'" +
                              //" \n3 --> diamond '\u2666'" +
                              //" \n4 --> spade '\u2660'");

            // string choise = Convert.ToString(Console.ReadLine());
            //switch (choise)
            //{
            //    case "1": PrintHearts(cards, bigOnes); break;
            //    case "2": PrintClubs(cards, bigOnes); break;
            //    case "3": PrintDiamonds(cards, bigOnes); break;
            //    case "4": PrintSpades(cards, bigOnes); break;
            //    default: Console.WriteLine("xax"); break;
            //}

            Console.WriteLine(int.MaxValue);
            Console.WriteLine();
        }

 
    }
}


