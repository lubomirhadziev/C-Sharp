using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            n = n >> p;

            int mask = n & 1;

            Console.WriteLine(mask);
            Console.WriteLine();
        }
    }
}
