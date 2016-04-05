using System;


class Divide_by_7_and_5
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = int.Parse(input);

        if (number % 35 == 0)
        {
            Console.WriteLine("true {0}", number);
        }
        else
        {
            Console.WriteLine("false {0}", number);
        }
    }
}
