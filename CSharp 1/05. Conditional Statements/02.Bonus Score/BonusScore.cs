using System;
class BonusScore
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int score = 0;

        if (0 < number && number <= 3)
        {
            score = number * 10;
            Console.WriteLine(score);
        }
        else if (3 < number && number <= 6)
        {
            score = number * 100;
            Console.WriteLine(score);
        }
        else if (6 < number && number <= 9)
        {
            score = number * 1000;
            Console.WriteLine(score);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}