using System;

class NumbeComparer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}", (a >= b) ? a : b);
    }
}

