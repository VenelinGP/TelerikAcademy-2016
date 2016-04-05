using System;
class ThirdBit
{
    static void Main()
    {
        string number = Console.ReadLine();
        int intNumber = int.Parse(number);
        intNumber = intNumber / 8;
        int bit = intNumber % 2;
        Console.WriteLine("{0}", bit);
    }
}

