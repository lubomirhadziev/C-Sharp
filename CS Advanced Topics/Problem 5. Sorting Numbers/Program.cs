using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine("results:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();
        }
    }
}
