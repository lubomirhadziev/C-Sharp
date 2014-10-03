using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            double n = double.Parse(Console.ReadLine());

            //calculate
            double result = calcFactorial(2 * n) / (calcFactorial(n + 1) * calcFactorial(n));

            //print result
            Console.WriteLine("{0}", result);
            Console.WriteLine();
        }
    }

    static double calcFactorial(double number)
    {
        //get real number
        number = Math.Abs(number);

        //set result
        double resultSum = 1;

        for (int i = 1; i <= number; i++)
        {
            resultSum *= i;
        }
        return resultSum;
    }
}