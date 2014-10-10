using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            var numbersFromHex = new Dictionary<char, int>()
            { 
                {'0', 0}, 
                {'1', 1}, 
                {'2', 2},
                {'3', 3},
                {'4', 4}, 
                {'5', 5},
                {'6', 6},
                {'7', 7},
                {'8', 8},
                {'9', 9}, 
                {'A', 10}, 
                {'B', 11},
                {'C', 12}, 
                {'D', 13},
                {'E', 14}, 
                {'F', 15},
            };

            string hexadecimal = Console.ReadLine();
            int stringLength = hexadecimal.Length;

            double resultNumber = 0;
            int hexStringPosition = 0;

            for (int i = stringLength - 1; i >= 0; i--)
            {
                int numberInHex = numbersFromHex[hexadecimal[i]];

                resultNumber += numberInHex * Math.Pow(16, hexStringPosition);

                hexStringPosition++;
            }

            Console.WriteLine(resultNumber);
            Console.WriteLine();
        }
    }
}