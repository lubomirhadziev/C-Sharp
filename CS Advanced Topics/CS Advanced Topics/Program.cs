using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            int fibNumber = Fib(int.Parse(Console.ReadLine()));

            Console.WriteLine(fibNumber);
            Console.WriteLine();
        }
    }

    static int Fib(int n)
    {
        n += 2;
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            if (i > 1)
            {
                numbers[i] = (numbers[i - 1] + numbers[i - 2]);
            }
            else
            {
                numbers[i] = i;
            }
        }

        return numbers[n-1];
    }
}