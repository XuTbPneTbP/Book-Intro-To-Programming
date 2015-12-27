using System;
using System.Text;

class CharSymbol
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;   
      
       // You need to set console font to Lucida Console in case that copychar isn't appear.
        char copyright = '\u00A9';
        char starOrMultiply = '\u002a';
        char sht = 'щ';
            
        // With type casting we recognize char like int
        Console.WriteLine("The symbol with the Unicode code {0} have char {1}", (int)copyright, copyright);
        Console.WriteLine("The symbol with the Unicode code {0} have char {1}", (int)starOrMultiply, starOrMultiply);
        Console.WriteLine(sht);
    }
}

