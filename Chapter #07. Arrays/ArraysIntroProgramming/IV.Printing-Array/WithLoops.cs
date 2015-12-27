using System;

class WithLoops
{
    static void Main()
    {
        int[] myIntArray = new int[4];   //Създаване/локализиране на масив от пет integer-a/елемента.

        myIntArray[0] = 12;
        myIntArray[1] = 24;
        myIntArray[2] = myIntArray[0] * 4;
        myIntArray[3] = myIntArray[1] / 3;
        //myIntArray[4] = 25; //Тук ще даде 

        foreach (int number in myIntArray)
        {
            Console.WriteLine(number);
        }
    }
}

