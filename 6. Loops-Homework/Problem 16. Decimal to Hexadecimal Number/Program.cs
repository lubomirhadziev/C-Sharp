using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            var numbersFromHex = new Dictionary<int, char>()
            { 
                {0, '0'},
                {1, '1'},
                {2, '2'},
                {3, '3'},
                {4, '4'},
                {5, '5'},
                {6, '6'},
                {7, '7'},
                {8, '8'},
                {9, '9'},
                {10, 'A'},
                {11, 'B'},
                {12, 'C'},
                {13, 'D'},
                {14, 'E'},
                {15, 'F'},
            };

            decimal number = decimal.Parse(Console.ReadLine());
            string hexademical = "";
            decimal divisible = number;

            while (divisible >= 1)
            {
                int ostatak = (int)(divisible % 16);
                hexademical += numbersFromHex[ostatak];
                divisible = (decimal)(divisible / 16);
            }

            //convert to char array and reverse the chars
            char[] charArray = hexademical.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(new string(charArray));
            Console.WriteLine();
        }
    }
}