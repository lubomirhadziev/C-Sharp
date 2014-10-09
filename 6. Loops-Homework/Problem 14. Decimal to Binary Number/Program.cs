using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            double number = double.Parse(Console.ReadLine());
            string binary = "";
            double divisible = number;

            while (divisible >= 1)
            {
                binary += divisible % 2;
                divisible = (int)(divisible / 2);

                //for debug only --> Console.WriteLine("{0}:2={1} | {2}", oldDivisible, divisible, oldDivisible%2);
            }

            //convert to char array and reverse the chars
            char[] charArray = binary.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(new string(charArray));
            Console.WriteLine();
        }
    }
}