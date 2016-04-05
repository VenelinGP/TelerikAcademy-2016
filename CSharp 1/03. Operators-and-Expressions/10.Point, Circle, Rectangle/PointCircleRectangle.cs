using System;
class PointCircleRectangle
{
    static void Main()
    {
        string xAsString = Console.ReadLine();
        double x = double.Parse(xAsString);
        string yAsString = Console.ReadLine();
        double y = double.Parse(yAsString);

        double distance = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));
        string isInRectangle = "outside rectangle";
        if ((x >= -1 & x <= 5) & (y >= -1 & y <= 1))
        {
            isInRectangle = "inside rectangle";
        }

        if (distance > 1.5)
        {
            Console.WriteLine("outside circle " + isInRectangle);
        }
        else
        {
            Console.WriteLine("inside circle " + isInRectangle);
        }

    }
}
