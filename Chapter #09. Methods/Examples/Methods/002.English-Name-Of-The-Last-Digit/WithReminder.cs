using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.English_Name_Of_The_Last_Digit
{
    class WithReminder
    {

        //int i = 7658;
        //Console.WriteLine(i % 10); //Last digit.
        //i = i / 10;
        //Console.WriteLine(i % 10); //Third digit.
        //i = i / 10;
        //Console.WriteLine(i % 10); //Second gidit.
        //i = i / 10;
        //Console.WriteLine(i % 10); //First digit.

        //int i = 7658;
        //    Console.WriteLine(i%10);
        //    i = i / 10;
        //    Console.WriteLine(i);
        //    Console.WriteLine(i%10);
        static void Main()
        {
            Console.Write("Enter random digit & I'll tell ya the last digit on english: ");
            int number = int.Parse(Console.ReadLine());
            ReturnDigitAsWord(number);
        }
        static void ReturnDigitAsWord(int number)
        {
            int result = number % 10;
            switch (result)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;

                default:
                    Console.WriteLine("Fuck You!!");
                    break;
            }
        }
    }
}
