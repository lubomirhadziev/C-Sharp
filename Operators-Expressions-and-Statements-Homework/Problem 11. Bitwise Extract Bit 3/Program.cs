using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());

            n = n >> 3;

            int mask = n & 1;

            Console.WriteLine(mask);
            Console.WriteLine();
        }
    }
}
