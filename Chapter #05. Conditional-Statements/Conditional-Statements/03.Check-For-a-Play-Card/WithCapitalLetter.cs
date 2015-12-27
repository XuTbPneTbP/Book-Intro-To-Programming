using System;

class WithCapitalLetter
{
    static void Main()
    {     
        string letter = Convert.ToString(Console.ReadLine());       

        switch (letter)
        {           
            case "J":
            case "Q":
            case "K":
            case "A":
                Console.WriteLine("Yes --> {0} is in the game!", letter);
                break;
            case "j":
            case "q":
            case "k":
            case "a":
                Console.WriteLine("Verry low letter! XA-XA-XA!!!");
                break;
            case "0":
            case "1":
                Console.WriteLine("Not in the GAME!!"); 
                break;
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
                Console.WriteLine("Yes --> {0} is in the GAME!", letter); 
                break;           
        dafault:
                Console.WriteLine("Unknown!!");
                break;        
        }        
    }
}

