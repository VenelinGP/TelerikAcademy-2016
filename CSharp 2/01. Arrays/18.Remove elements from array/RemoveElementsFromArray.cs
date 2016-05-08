using System;
using System.Collections.Generic;

class RemoveElementsFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        List<int> newArr = new List<int>();
        int maxSeq = 0;


        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            newArr.Add(1);
        }

        for (int j = 1; j < n; j++)
        {
            for (int k = 0; k < j; k++)
            {
                if ((arr[k] <= arr[j]) && (newArr[j] < (newArr[k] + 1)))
                {
                    newArr[j] = newArr[k] + 1;
                    if (maxSeq < newArr[j])
                    {
                        maxSeq = newArr[j];
                    }
                }

            }
        }
        Console.WriteLine(n - maxSeq);
     }
}
