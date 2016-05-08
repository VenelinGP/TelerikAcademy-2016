using System;
class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int minNumber = int.MaxValue;
        int minIndex = 0;
        int currentNumber = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < n; j++)
        {
            for (int k = j; k < n; k++)
            {
                if (minNumber > arr[k])
                {
                    minNumber = arr[k];
                    minIndex = k;
                }
            }
            if (arr[j] > minNumber)
            {
                currentNumber = arr[j];
                arr[j] = minNumber;
                arr[minIndex] = currentNumber;

            }
            minNumber = int.MaxValue;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
