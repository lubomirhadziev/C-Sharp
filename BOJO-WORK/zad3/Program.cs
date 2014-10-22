using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int productN = n * 2;

        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.Write("{0}", new string('*', productN));
            }
            else if (i == n)
            {
                Console.Write("{0}", new string('*', productN));
            }
            else
            {
                Console.Write("*{0}*", new string('/', productN - 2));
            }
            
            //bridge
            if (i == Math.Ceiling(n / 2.0))
            {
                Console.Write("{0}", new string('|', n));
            }
            else
            {
                Console.Write("{0}", new string(' ', n));
            }

            //second glass
            if (i == 1)
            {
                Console.Write("{0}", new string('*', productN));
            }
            else if (i == n)
            {
                Console.Write("{0}", new string('*', productN));
            }
            else
            {
                Console.Write("*{0}*", new string('/', productN - 2));
            }

            //new line
            Console.WriteLine();
        }
    }
}
