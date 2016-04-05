using System;

class MoonGravity
{
    static void Main()
    {
        string input = Console.ReadLine();
        double weightOnEarth = double.Parse(input);

        double weightOnMoon = weightOnEarth * 0.17;

        Console.WriteLine("{0:F3}", weightOnMoon);

    }
}

