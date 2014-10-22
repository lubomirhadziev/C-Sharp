using System;
using System.Collections.Generic;
using System.Linq;
namespace SortingNumbers
{
    class SortingNumbers
    {
        static void Main()
        {
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                int[] numbers = new int[input];
                for (int i = 0; i < input; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                Array.Sort(numbers);
                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
