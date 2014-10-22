using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace IsPrimeMethod
{
    class IsPrimeMethod
    {
        static void Main()
        {
            while (true)
            {
                var result = isPrime(long.Parse(Console.ReadLine()));
                Console.WriteLine(result);
            }
        }
        static bool isPrime(long input)
        {
            long resultingiInput = (long)Math.Sqrt(input);
            bool isPrim = true;

            if (resultingiInput > 1)
            {
                for (int i = 2; i < input; i++)
                {
                    if (resultingiInput % i == 0 && i != input)
                    {
                        isPrim = false;
                        break;
                    }
                }
            }
            else
            {
                isPrim = false;
            }
            return isPrim;
        }
    }
}
