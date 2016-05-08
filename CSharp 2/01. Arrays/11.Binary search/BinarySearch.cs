using System;
class BinarySearch
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());

        int high = arr.Length - 1;
        int low = 0;
        int mid;
        int result = -1;

        if (arr[0] == x)
            result = low;
        else if (arr[high] == x)
            result = high;
        else
        {
            while (low <= high)
            {
                mid = (high + low) / 2;
                if (arr[mid] == x)
                {
                    result = mid;
                    break;
                }
                else
                {
                    if (arr[mid] > x)
                        high = mid - 1;
                    else
                        low = mid + 1;
                }

            }
            //if (low > high)
            //{
            //    result = -1;
            //}
        }

        //int result = Searching(arr, x);
        Console.WriteLine(result);
    }
}
