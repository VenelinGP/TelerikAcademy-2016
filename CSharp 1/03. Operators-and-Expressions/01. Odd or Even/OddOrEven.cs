using System;

class OddOrEven
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = int.Parse(input);

        if (number % 2 == 0)
        {
            Console.WriteLine("even " + number);
        }
        else
        {
            Console.WriteLine("odd " + number);
        }
    }
}

