using System;
class Circle
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double p = 2 * r * Math.PI;
        double s = r * r * Math.PI;
        Console.WriteLine("{0:F2} {1:F2}", p, s);
    }
}

