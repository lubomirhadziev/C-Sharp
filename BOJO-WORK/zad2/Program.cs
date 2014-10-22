using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int allNumbers = n * 2;
        int[] firstNumbers = new int[n];
        int[] secondNumbers = new int[n];

        for (int i = 1; i <= allNumbers; i++)
        {
            if (i <= n)
            {
                firstNumbers[i - 1] = int.Parse(Console.ReadLine());
            }
            else
            {
                secondNumbers[(i - n) - 1] = int.Parse(Console.ReadLine());
            }
        }

        int firstSum = firstNumbers.Sum();
        int secondSum = secondNumbers.Sum();

        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum={0}", firstSum);
        }
        else
        {
            if (firstSum > secondSum)
            {
                Console.WriteLine("No, diff={0}", firstSum - secondSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", secondSum - firstSum);
            }
        }
    }
}