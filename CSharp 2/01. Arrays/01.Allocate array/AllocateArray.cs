using System;
class AllocateArray
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] arr = new int[number];
        for (int i = 0; i < number; i++)
        {
            arr[i] = i * 5;
            Console.WriteLine(arr[i]);
        }
    }
}

