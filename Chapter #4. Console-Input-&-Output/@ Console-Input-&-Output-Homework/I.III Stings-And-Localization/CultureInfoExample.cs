using System;
using System.Threading;
using System.Globalization;
using System.Text;

class CultureInfoExample
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        DateTime now = DateTime.Now;
        DateTime fantase = new DateTime(3078, 02, 12, 23, 17, 48);

        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");

        Console.WriteLine("Българско време => {0:G}", now);
        Console.WriteLine("Българско време => {0:D}", fantase);

        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");

        Console.WriteLine("Френско време => {0:D}",fantase);
        Console.WriteLine("Френско време => {0:D}", now);
        Console.WriteLine("Френско време => {0:G}", fantase);
        Console.WriteLine("Френско време => {0:G}", now);

        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Console.WriteLine("{0:D}",now);
        Console.WriteLine("{0:G}",fantase);
    }
}

