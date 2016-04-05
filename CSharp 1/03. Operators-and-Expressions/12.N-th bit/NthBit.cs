using System;
class NthBit
{
    static void Main()
    {
        string stNumber = Console.ReadLine();
        long number = long.Parse(stNumber);
        string stP = Console.ReadLine();
        int p = int.Parse(stP);
        byte bitAtPositionP = (byte)((number >> p) & 1);
        Console.WriteLine("{0}", bitAtPositionP);
    }
}
