using System;
class MaximalSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int countMaxSeq = 1;
        int maxSeq = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int currentNumber = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (currentNumber == arr[i])
            {
                countMaxSeq++;
            }
            else
            {
                if (maxSeq < countMaxSeq)
                {
                    maxSeq = countMaxSeq;
                }
                currentNumber = arr[i];
                countMaxSeq = 1;

            }
        }
        if (maxSeq == 0)
        {
            maxSeq = countMaxSeq;
        }
        Console.WriteLine(maxSeq);
    }
}
