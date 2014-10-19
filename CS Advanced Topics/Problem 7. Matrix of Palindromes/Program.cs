using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            for (int row = 0; row < rows; row++)
            {
                char rowLetter = (char)('a' + row);
                    
                for (int col = 0; col < cols; col++)
                {
                    char colLetter = (char)(('a' + (row + col)));

                    Console.Write("{0}{1}{0} ", rowLetter, colLetter);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}