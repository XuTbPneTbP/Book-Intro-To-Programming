using System.Collections.Generic;

namespace CaseInsensitiveComparer
{
    class ComparerInterface : IComparer<string>
    {
        static void Main()
        {
            string opsa = "Oplqnkaa";
            string lilOpsa = "opalqnka";
            Compare(opsa, lilOpsa);
        }

        public static int Compare(string x, string y)
        {
            return string.Compare(x, y, true);
        }
    }
}
