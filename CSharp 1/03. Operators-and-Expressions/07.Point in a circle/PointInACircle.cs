using System;
class PointInACircle
{
    static void Main()
    {
        string xAsString = Console.ReadLine();
        double x = double.Parse(xAsString);
        string yAsString = Console.ReadLine();
        double y = double.Parse(yAsString);

        double distance = Math.Sqrt(x * x + y * y);

        if (distance > 2)
        {
            Console.WriteLine("no {0:F2}", distance);
        }
        else
        {
            Console.WriteLine("yes {0:F2}", distance);
        }
    }
}
