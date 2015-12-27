using System;

class InitializeAndDeclare
{
    static void Main()
    {
        //Declare single-dimension array wich have three elements, each of wich is single-dimension array
        int[][] jaggedArray = new int[3][];
        //To use  jagged arrays we must initialize the elements like this:
        jaggedArray[0] = new int[5]; // first element is array of five integers
        jaggedArray[1] = new int[3]; // second element is array of three integers
        jaggedArray[2] = new int[2]; //third element is array of two integers
        //We can also fill array elements with values
        jaggedArray[0] = new int[] { 2, 4, 6, 8, 10 };
        jaggedArray[1] = new int[] { 1, 3, 5 };
        jaggedArray[2] = new int[] { 7, 9,53 };

        //Another way to initialize 
        int[][] jaggedArrаy2 = new int[][] 
        {
            new int[] {2,3,4,9},
            new int[] {3,4,5},
            new int[] {4,5,6}
        };
        //Изискваме определена стойност от определен масив
        Console.WriteLine("{0}", jaggedArray[0][2]);
        Console.WriteLine("{0}",jaggedArray[2][2]);
        Console.WriteLine("{0}", jaggedArrаy2[2][2]);
    }
}

