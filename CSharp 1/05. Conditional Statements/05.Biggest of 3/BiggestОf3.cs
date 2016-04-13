using System;
class BiggestОf3
{
    static void Main()
    {
        double biggestNumber = double.MinValue;
        for (int i = 0; i < 3; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (biggestNumber < number)
            {
                biggestNumber = number;
            }
        }
        Console.WriteLine(biggestNumber);
    }
}

