using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Print_Total_Amount_Of_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = new decimal[] {2.3m,8.5m,12m};
            PrintTotalAmountOfBooks(prices);
        }

        static void PrintTotalAmountOfBooks(decimal[] bookPrice)
        {
            decimal totalAmount = 0;
            foreach (decimal singleBookPrice in bookPrice)
            {
                totalAmount += singleBookPrice;
            }
            Console.WriteLine("The total amount of books is: " + totalAmount);
        }
    }
}
