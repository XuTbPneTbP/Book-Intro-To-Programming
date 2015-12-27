using System;

class FewQuoteWays
{
    static void Main()
    {
        string doubleQuotation = @"The ""use"" of quotations causes difficulties!";
        string withBackSlash = "The \"use\" of quotations causes difficulties!";
        // The more clearity prefer backslash.
        Console.WriteLine(doubleQuotation);
        Console.WriteLine(withBackSlash);




        Console.WriteLine( "{0:c1}", 123.4545);

    }
}

