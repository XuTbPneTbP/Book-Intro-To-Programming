using System;

class ChooseTypeForEachVariable
{
    static void Main()
    { // Declare five variables choosing for each of them the most appropriate of the types
        //byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
        //52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. 

        ushort firstNumber = 52130; //from 0 to 65535
        sbyte secondNumber = -115; //from -128 to 127
        int thirdNumber = 4825932;
        byte fourthNumber = 97;    //from 0 to 255
        short fifthNumber = -10000; //from -32768 to 32767

        Console.WriteLine("ushort = {0} \nsbyte = {1} \nint = {2} \nbyte = {3} \nshort = {4}",
            firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        Console.WriteLine("suck it");
    }
}
