using System;

class Program
{
    static void Main()
    {
        string[] cards = new string[12] {
            "2", "3", "4", "5", "6", "7", "8", "9", "10", "Q", "K", "A"
        };
        string[] cardsType = new string[4]{
            "♣", "♦", "♥", "♠"
        };

        for (int card = 0; card < 12; card++)
        {
            for (int type = 0; type < 4; type++)
            {
                Console.Write("{0,-4}", cards[card] + cardsType[type]);
            }
            Console.Write("\n");
        }
    }
}