using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if ((b * b - 4 * a * c) < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if ((b * b - 4 * a * c) == 0)
        {
            double x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("{0:F2}", x1);
        }
        else
        {
            double x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("{0:F2}", x1);
            Console.WriteLine("{0:F2}", x2);
        }

    }
}

