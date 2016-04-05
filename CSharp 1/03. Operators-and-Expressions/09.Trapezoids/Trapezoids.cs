using System;
class Trapezoids
{
    static void Main()
    {
        string aAsString = Console.ReadLine();
        double a = double.Parse(aAsString);
        string bAsString = Console.ReadLine();
        double b = double.Parse(bAsString);
        string hAsString = Console.ReadLine();
        double h = double.Parse(hAsString);

        double area = ((a + b) / 2) * h;
        Console.WriteLine("{0:F7}", area);
    }
}
