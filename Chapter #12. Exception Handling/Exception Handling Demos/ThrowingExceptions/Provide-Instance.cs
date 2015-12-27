using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingExceptions
{
    class ProvideInstance
    {
        static void Main(string[] args)
        {
            Exception custEx = new Exception("Q go Q!");
            throw custEx;
        }
    }
}
