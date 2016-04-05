using System;
class PrimeCheck
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = int.Parse(input);
        if (number < 0 || number == 0 || number == 1)
        {
            Console.WriteLine("false");
        }
        else
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
        }
    }
}
