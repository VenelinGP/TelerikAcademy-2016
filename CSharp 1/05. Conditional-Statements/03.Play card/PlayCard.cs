using System;
class PlayCard
{
    static void Main()
    {
        string card = Console.ReadLine();
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string isTrue = "no ";
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i] == card)
            {
                isTrue = "yes ";
            }
        }
        Console.WriteLine(isTrue + card);
    }
}

