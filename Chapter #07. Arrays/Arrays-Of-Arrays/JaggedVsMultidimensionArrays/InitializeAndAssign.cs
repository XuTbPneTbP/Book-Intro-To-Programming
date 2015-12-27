using System;

class InitializeAndAssign
{
    static void Main()
    {
        int[][] jaggedMF = new int[3][];
        
        jaggedMF[0] = new int[2] {13,14};
        jaggedMF[1] =  new int[3] {17,18,19};
        jaggedMF[2] = new int[2] { 7, 8 };
        
        Console.WriteLine(jaggedMF.Length);
        //We can ask for the lenght of the jagged array --> how much arrays consist in it --> display the elements
        for (int i = 0; i < jaggedMF.Length; i++)
        {
            Console.Write("{0} --> ",i);

            for (int j = 0; j < jaggedMF[i].Length; j++)
            {
                Console.Write("{0}{1}", jaggedMF[i][j], j == (jaggedMF[i].Length - 1) ? "" : " ");
            }
            Console.WriteLine();
        }       
    }
}

