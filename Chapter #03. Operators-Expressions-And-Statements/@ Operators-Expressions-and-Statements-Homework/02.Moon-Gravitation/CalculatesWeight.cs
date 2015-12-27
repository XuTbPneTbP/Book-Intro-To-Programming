using System;

class CalculatesWeight
{
    static void Main()
    {   
        Console.WriteLine("Enter your weight: ");
        int ownWeightOnEarth = Convert.ToInt32(Console.ReadLine());
     
        //double  earthGravityAcceleration = 9.80665;    g=m/s^2
        double moonGravityAcceleration = 0.17;

        Console.WriteLine(moonGravityAcceleration + " is the Moon gravity acceleration");
        Console.WriteLine("{0}",moonGravityAcceleration*ownWeightOnEarth);
        
    }
}

