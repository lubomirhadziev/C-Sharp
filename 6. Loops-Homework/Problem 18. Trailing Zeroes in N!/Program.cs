using System;
using System.Numerics;
using System.Linq;

class Program
{
    
    static void Main()
    {
        while(true)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorialOfNumber = factorial(number);

            //transform factorial number into char array
            char[] factorialChars = factorialOfNumber.ToString().ToCharArray();

            //reverse chars array and zeros to come to first position
            Array.Reverse(factorialChars);

            //make variable to count any zeros at the end of factorial number
            int zerosCounter = 0;

            foreach (var factorialNumber in factorialChars)
            {
                if (factorialNumber == '0')
                {
                    zerosCounter++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(zerosCounter);
            Console.WriteLine();
        }
    }

    private static BigInteger factorial(int number)
    {
        BigInteger factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

}
