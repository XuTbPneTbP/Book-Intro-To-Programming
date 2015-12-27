using System;

// GCD => Greatest Common Divisor
// LCM => Least Common Multiple
// Take this SHIT => LCM(a, b) = (a * b) / GCD(a, b)

namespace GCDandLCM
{
    class TwoNumbersInput
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            int gcd = GreatCommonDivisor(a, b);
            int lcm = LeastCommonMultiple(a, b, gcd);

            Console.WriteLine("GCD of |{0}, {1}| is => |{2}|", a, b, gcd);
            Console.WriteLine("##########################");
            Console.WriteLine("LCM of |{0}, {1}| is => |{2}|", a, b, lcm);

        }

        private static int LeastCommonMultiple(int a, int b, int gcd)
        {
            int leastCommonMultiple = (a*b)/GreatCommonDivisor(a, b);
            return leastCommonMultiple;
        }

        private static int GreatCommonDivisor(int a, int b)
        {
            int reminder = a % b;
            int currentDivider = a / b;
            int greatCommonDivider = 0;

            while (reminder != 0)
            {
                reminder = a%b;
                currentDivider = a/b;

                greatCommonDivider = (a - reminder) / currentDivider;
                a = greatCommonDivider;
                b = reminder;
            }

            return greatCommonDivider;
        }

    }
}
