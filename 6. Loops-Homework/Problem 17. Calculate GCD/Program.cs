using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int exchange = 0;

            //if b > a exhange A and B
            if (b > a)
            {
                exchange = a;
                a = b;
                b = exchange;
            }

            //init remainder with -1 to start while
            int remainder = -1;

            while (remainder != 0)
            {
                remainder = a % b;

                if (remainder != 0)
                {
                    a = b;
                    b = remainder;
                }
            }

            Console.WriteLine(b);
            Console.WriteLine();
        }
    }
}