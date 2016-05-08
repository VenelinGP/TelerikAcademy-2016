using System;
class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int totalMax = arr[0];
        int currentMax = arr[0];
        for (int j = 1; j < n; j++)
        {

            currentMax = Math.Max(arr[j], currentMax + arr[j]);
            totalMax = Math.Max(currentMax, totalMax);
        }
        Console.WriteLine(totalMax);
    }
}
