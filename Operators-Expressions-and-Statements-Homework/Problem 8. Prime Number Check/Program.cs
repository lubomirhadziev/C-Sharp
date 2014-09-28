using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (n != 1 && n > 0)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {
                isPrime = false;
            }

            Console.WriteLine(isPrime);
            Console.WriteLine();
        }
    }
}