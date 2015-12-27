using System.Collections.Generic;
using System.Text;

namespace Demos
{
    public static class IEnumerableExtensions
    {
        public static string ToString<T>(this IEnumerable<T> enumeration)
        {
            StringBuilder output = new StringBuilder();

            output.Append("[");

            foreach (var number in enumeration)
            {
                output.Append(number.ToString());
                output.Append(", ");
            }

            if (output.Length > 1)
            {
                output.Remove(output.Length - 2, 2);
            }

            output.Append("]");

            return output.ToString();
        }
    }
}
