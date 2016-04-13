using System;
class BiggestOf5
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double result = double.MinValue;

        if (result < a)
        {
            result = a;
        }
        if (result < b)
        {
            result = b;
        }
        if (result < c)
        {
            result = c;
        }
        if (result < d)
        {
            result = d;
        }
        if (result < e)
        {
            result = e;
        }
        Console.WriteLine(result);
    }
}
