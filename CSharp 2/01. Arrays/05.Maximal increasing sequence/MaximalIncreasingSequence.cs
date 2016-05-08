using System;
class MaximalIncreasingSequence
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        int count = 1;
        int maxSeq = 1;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < (n - 1); i++)
        {
            if (arr[i] < arr[i + 1])
            {
                count++;
                if (count > maxSeq)
                {
                    maxSeq = count;

                }

            }
            else
            {
                count = 1;
            }
        }
        Console.WriteLine(maxSeq);
    }
}

