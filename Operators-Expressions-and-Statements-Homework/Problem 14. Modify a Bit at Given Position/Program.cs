using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());

            Console.WriteLine(changeBitAtPoisiton(n, p, v));
            Console.WriteLine();
        }
    }

    static int changeBitAtPoisiton(int number, int position, byte bitToSet)
    {
        int mask = 1 << position;

        if (bitToSet == 0)
        {
            mask = number & (~mask);
        }
        else
        {
            mask = number | mask;
        }

        return mask;
    }
}