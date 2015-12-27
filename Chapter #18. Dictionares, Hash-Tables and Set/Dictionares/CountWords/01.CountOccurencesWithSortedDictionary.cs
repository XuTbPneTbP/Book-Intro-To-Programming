using System.Collections.Generic;
using CountWords;

namespace _01.CountWordsInText
{
    class CountOccurencesWithSortedDictionary : ExamplesLogic
    {
        private static readonly string someText = "Bla? Bla bla!!, bla? bla ?Blaaaaa. blaaaaa Opsa opsa";
        private static readonly string Sonnet98WilliamShakespeare =
            " --From you have I been absent in the spring," +
            " When proud-pied April, dressed in all his trim," +
            " Hath put a spirit of youth in every thing," +
            " That heavy Saturn laughed and leaped with him." +
            "   Yet nor the lays of birds, nor the sweet smell" +
            " Of different flowers in odour and in hue" +
            " Could make me any  ummer's story tell," +
            " Or from their proud lap pluck them where they grew." +
            " Nor did I wonder at the lily's white," +
            " Nor praise the deep vermilion in the rose; " +
            " They were but sweet, but  igures of delight" +
            " Drawn after you, you pattern of all those." +
            " Yet seemed it winter still, and you away," +
            " As with your shadow I with these did play. ";
        static void Main()
        {
            // Logic => read the text word by word. for each word we check if already exists in the dictionary. If no => we add new element in the dictionary with value of 1. If yes => we increase the old value by 1

         //   Sample();

            IDictionary<string, int> wordOccurence = GetOccurences(someText);

            PrintWordOccurences(wordOccurence);
        }

      

    }
}
