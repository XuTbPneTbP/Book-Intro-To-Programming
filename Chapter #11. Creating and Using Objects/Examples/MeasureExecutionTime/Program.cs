using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureExecutionTime
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int startTime = Environment.TickCount;

            /* Code fragment to be tested. Returned result is in miliseconds. */
            for (long i = 0; i < 100000000; i++)
            {
                sum++;
            }
            
            int endTime = Environment.TickCount;
            var elapsedTime = (endTime - startTime) / 1000.0;
            Console.WriteLine($"Time elapsed : {elapsedTime} sec.");
        }
    }
}
