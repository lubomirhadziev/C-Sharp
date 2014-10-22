using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            while (true)
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                var result = primesInRange(first, second);
                string output = string.Join(", ", result.ToArray());
                Console.Write(output + '\n');
            }
        }
        static bool isPrime(int input)
        {
            bool isPrim = true;

            if (input > 1)
            {
                for (int i = 2; i < input; i++)
                {
                    if (input % i == 0)
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
        static List<int> primesInRange(int beginning, int end)
        {
            var result = new List<int>();
            for (int i = beginning; i <= end; i++)
            {
                if (isPrime(i) == true)
                {
                    result.Add(i);
                }
			}
            return result;
        }
    }
}
