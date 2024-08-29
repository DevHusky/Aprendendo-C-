using System;

class Area
{
    static void Main()
    {
        double pi = 3.14159, r;

        r = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A = " + (pi * (r * r)).ToString("0.0000"));
    }
}