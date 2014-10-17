using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            bool isPrimeNumber = isPrime(double.Parse(Console.ReadLine()));

            Console.WriteLine("{0}", isPrimeNumber);
            Console.WriteLine();
        }
    }


    static bool isPrime(double n)
    {
        n = Math.Abs(n);

        double sqrt = Math.Sqrt(n);
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