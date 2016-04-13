using System;
class IntDoubleString
{
    static void Main()
    {
        string digit = Console.ReadLine();
        int number = 0;
        double real = 0.0;
        string text = "";
        switch (digit)
        {
            case "integer":
                number = int.Parse(Console.ReadLine());
                number += 1;
                Console.WriteLine(number);
                break;
            case "real":
                real = double.Parse(Console.ReadLine());
                real += 1;
                Console.WriteLine("{0:F2}", real);
                break;
            case "text":
                text = Console.ReadLine();
                Console.WriteLine(text + "*");
                break;
            default:
                break;
        }
    }
}
