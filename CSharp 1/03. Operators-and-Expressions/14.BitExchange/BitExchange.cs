using System;
class BitExchange
{
    static void Main()
    {

        string stNumber = Console.ReadLine();
        uint number = uint.Parse(stNumber);

        uint bit3 = (number >> 3) & 1;
        uint bit4 = (number >> 4) & 1;
        uint bit5 = (number >> 5) & 1;
        uint bit24 = (number >> 24) & 1;
        uint bit25 = (number >> 25) & 1;
        uint bit26 = (number >> 26) & 1;

        if (bit3 != bit24)
        {
            number = number ^ (1 << 3);
            number = number ^ (1 << 24);
        }
        if (bit4 != bit25)
        {
            number ^= (1 << 4);
            number ^= (1 << 25);
        }
        if (bit5 != bit26)
        {
            number ^= (1 << 5);
            number ^= (1 << 26);
        }

        Console.WriteLine("{0}", number);
    }
}
