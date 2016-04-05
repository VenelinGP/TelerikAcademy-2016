using System;
class ThirdDigit
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = int.Parse(input);

        int isSeven = number / 100;
        if (isSeven % 10 == 7)
        {
            Console.WriteLine("true");
        } 
        else
        {
            Console.WriteLine("false {0}", isSeven%10);
        }
    }
}
