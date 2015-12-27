using System.Collections.Generic;

namespace CountWords
{
    public class ComparerInterface : IComparer<string>
    {
        //int IComparer<string>. Compare(string x, string y)
        //{
        //    return string.Compare(x, y, true);
        //}

        public int Compare(string x, string y)
        {
            return string.Compare(x, y, true);
        }
    }
}
