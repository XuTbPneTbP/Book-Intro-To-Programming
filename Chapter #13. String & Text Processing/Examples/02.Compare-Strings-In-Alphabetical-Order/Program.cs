using System;

namespace _02.Compare_Strings_In_Alphabetical_Order
{
    class Program
    {
        static void Main()
        {
            //ComparisonOfEquality();
            CompareLexicographically();
        }

        private static void CompareLexicographically()
        {
            string minka = "Minka";
            string o4ko = "O4k0";
            string o4k0 = "O4k0";
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("minka.CompareTo(o4ko)");
            Console.WriteLine("If lexicographically Minka is before O4kO it returns => {0}", minka.CompareTo(o4ko));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("o4ko.CompareTo(minka)");
            Console.WriteLine("If lexicographically O4kO is after Minka it returns => {0}", o4ko.CompareTo(minka));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("o4ko.CompareTo(o4k0)");
            Console.WriteLine("If lexicographically O4kO is equal to {0} it returns => {1}", o4k0, o4ko.CompareTo(o4k0));
        }

        private static void ComparisonOfEquality()
        {
            string word1 = "SHT";
            string word2 = "sht";
            Console.WriteLine("word1 => SHT");
            Console.WriteLine("word2 => sht");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("word1.Equals(\"SHT\") => {0}", word1.Equals("SHT"));
            Console.WriteLine("word1.Equals(\"sht\") => {0}", word1.Equals("sht"));
            Console.WriteLine("word1.Equals(word2) => {0}", word1.Equals(word2));
            Console.WriteLine();

            // To ignore difference between small and capital letters we use:
            Console.WriteLine("word1.Equals(word2, \n\tStringComparison\n\t.CurrentCultureIgnoreCase \n\t) => {0}",
                word1.Equals(word2, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
