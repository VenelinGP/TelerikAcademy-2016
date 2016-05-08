using System;
class CompareCharArrays
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        char[] firstCharArray = first.ToCharArray();
        char[] secondCharArray = second.ToCharArray();
        int n = Math.Min(firstCharArray.Length, secondCharArray.Length);
        string result = "=";
        for (int i = 0; i < n; i++)
        {
            if (firstCharArray[i] > secondCharArray[i])
            {
                result = ">";
                break;
            }
            if (firstCharArray[i] < secondCharArray[i])
            {
                result = "<";
                break;
            }
        }
        if (result == "=")
        {
            if (firstCharArray.Length > secondCharArray.Length)
            {
                result = ">";
            }
            if (firstCharArray.Length < secondCharArray.Length)
            {
                result = "<";
            }
        }
        Console.WriteLine(result);

    }
}
