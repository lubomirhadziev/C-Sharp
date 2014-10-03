using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            byte n = byte.Parse(Console.ReadLine());

            for (byte row = 1; row <= n; row++)
            {
                for (byte col = row; col < (n + row); col++)
                {
                    Console.Write("{0,-3}", col);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }
    }
}