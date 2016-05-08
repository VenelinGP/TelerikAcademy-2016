using System;
class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int maxNumber = 0;
        int maxCount = 1;
        int currentCount = 1;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < n; j++)
        {
            int currentNumber = arr[j];
            for (int k = j + 1; k < n; k++)
            {
                if (arr[j] == arr[k])
                {
                    currentCount++;
                }
            }
            if (currentCount > maxCount)
            {
                maxNumber = arr[j];
                maxCount = currentCount;

            }
            currentCount = 1;
        }
        Console.WriteLine("{0} ({1} times)", maxNumber, maxCount);
    }
}
