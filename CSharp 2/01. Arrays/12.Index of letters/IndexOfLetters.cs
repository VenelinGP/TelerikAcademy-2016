using System;
class IndexOfLetters
{
    static void Main()
    {
        char[] arr = new char[122 - 96];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = (char)(97 + i);
        }
        string word = Console.ReadLine();
        foreach (var ch in word)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (ch == arr[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
