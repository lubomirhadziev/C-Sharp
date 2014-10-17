using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            var list = FindPrimesInRange(startNum, endNum);

            Console.WriteLine("{0}", string.Join(", ", Array.ConvertAll(list.ToArray(), i => i.ToString())));
            Console.WriteLine();
        }
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        var primeNumbers = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            if (isPrime(i))
            {
                primeNumbers.Add(i);
            }
        }

        return primeNumbers;
    }

    static bool isPrime(int n)
    {
        n = Math.Abs(n);

        int sqrt = (int)Math.Sqrt((double)n);
        bool isPrime = true;

        if (n < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        return isPrime;
    }
}