using System;
class Sort3Numbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int temp = 0;
        if (a < b)
        {
            temp = b;
            b = a;
            a = temp;
        }
        if (a < c)
        {
            temp = c;
            c = a;
            a = temp;
        }
        if (b < c)
        {
            temp = b;
            b = c;
            c = temp;
        }
        Console.WriteLine("{0} {1} {2}", a, b, c);
    }
}

