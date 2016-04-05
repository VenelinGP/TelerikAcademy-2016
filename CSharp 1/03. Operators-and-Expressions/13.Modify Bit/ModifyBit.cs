using System;
class ModifyBit
{
    static void Main()
    {

        string stNumber = Console.ReadLine();
        long number = long.Parse(stNumber);

        string stP = Console.ReadLine();
        byte p = byte.Parse(stP);

        string stBit = Console.ReadLine();
        byte bit = byte.Parse(stBit);

        int mask;
        long result;
        if (bit == 1)
        {
            mask = 1 << p;

            result = number | (long)mask;

        }
        else
        {
            mask = ~(1 << p);
            result = (number & mask);
        }
        Console.WriteLine("{0}", result);
    }
}