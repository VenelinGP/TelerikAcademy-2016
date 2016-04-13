using System;
class SumОfNNumbers
{
    static void Main()
    {
        int numberOfNumbers = int.Parse(Console.ReadLine());
        double sum = 0;
        double[] numbers = new double[numberOfNumbers];
        for (int i = 0; i < numberOfNumbers; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}
