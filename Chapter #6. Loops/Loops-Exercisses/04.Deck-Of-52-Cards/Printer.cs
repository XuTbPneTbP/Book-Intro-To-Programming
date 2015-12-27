using System;

namespace _04.Deck_Of_52_Cards
{
     public class Printer
    {
        public static void PrintSpades(int[] cards, string[] bigOnes)
        {
            foreach (var number in cards)
            {
                Console.WriteLine("{0,2} {1}", number, '\u2660');
            }foreach (var bigO in bigOnes)
            {
                Console.Write(bigO + "'\u2660' ");
            }
        }

        public static void PrintDiamonds(int[] cards, string[] bigOnes)
        {
            foreach (var number in cards)
            {
                Console.WriteLine(number + "'\u2666' ");
            }
            foreach (var bigO in bigOnes)
            {
                Console.Write(bigO + "'\u2666' ");
            }
        }

        public static void PrintClubs(int[] cards, string[] bigOnes)
        {
            foreach (var number in cards)
            {
                Console.WriteLine(number + "'\u2663' ");
            }
            foreach (var bigO in bigOnes)
            {
                Console.WriteLine(bigO + "'\u2663' ");
            }
        }

        public static void PrintHearts(int[] cards, string[] bigOnes)
        {
            foreach (var number in cards)
            {
                //Тука принтя всички бои едновременно. Просто задавам на съответния foreach да изпринти всички бои.
                Console.WriteLine(number + "'\u2665' " + number + "'\u2663' "
                                  + number + "'\u2666' " + number + "'\u2660' ");
            }
            foreach (var bigO in bigOnes)
            {
                Console.WriteLine(bigO + "'\u2665' " + bigO + "'\u2663' "
                                  + bigO + "'\u2666' " + bigO + "'\u2660' ");
            }
        }
    }
}
