using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double s = 1;

            for (int i = 1; i <= n; i++)
            {
                s += (calcFactorial(i) / Math.Pow(x, i));
            }

            Console.WriteLine("{0:F5}", s);
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