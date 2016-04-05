using System;

class Rectangles
{
    static void Main()
    {
        string aAsString = Console.ReadLine();
        double a = double.Parse(aAsString);
        string bAsString = Console.ReadLine();
        double b = double.Parse(bAsString);

        double p = 2 * (a + b);
        double s = a * b;
        Console.WriteLine("{0:F2} {1:F2}", s, p);

    }
}
