using System;

class Program
{
    static void Main()
    {
        for (int i = 2; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                if (i != 2)
                {
                    Console.Write(", ");
                }
                Console.Write(i);
            }
            else
            {
                Console.Write(", ");
                Console.Write(-i);
            }
        }
    }
}