using System;

namespace Demos
{
    public static class StringExtensions
    {
        // Have in mind that type string is sealed => it cannot be inherit. So we need the keyword "this" in front of the type wich indicates the compiler that this is extension method
        public static int WordCount(this string str)
        {
            return str.Split(new char[] {' ', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
