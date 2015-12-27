using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter: 2369124121");
        long sht =  int.Parse(Console.ReadLine());
        
        Console.WriteLine(Convert.ToString(sht,2).PadLeft(32, '0'));
       
        long bit3 = (sht >> 3) & 1;
        long bit4 = (sht >> 4) & 1;
        long bit5 = (sht >> 5) & 1;
        long bit24 = (sht >> 24) & 1;
        long bit25 = (sht >> 25) & 1;
        long bit26 = (sht >> 26) & 1;

         sht = sht & (~(1 << 24)) | (bit3 << 24);
         sht = sht & (~(1 << 3)) | (bit24 << 3);

         sht = sht & (~(1 << 25)) | (bit4 << 25);
         sht = sht & (~(1 << 4)) | (bit25 << 4);

         sht = sht & (~(1 << 26)) | (bit5 << 26);
         sht = sht & (~(1 << 5)) | (bit26 << 5);

        Console.WriteLine(Convert.ToString(sht,2).PadLeft(32, '0') + " <-- is {0}", sht);
      
    }
}

