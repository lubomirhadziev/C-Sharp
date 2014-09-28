using System;

class Program
{
    static void Main(string[] args)
    {
        double precision = 0.000001d;

        double number1 = -4.999999d;
        double number2 = 4.999998d;

        double difference = Math.Abs(number1 - number2);

        bool areEqual = difference < precision;

        Console.WriteLine(areEqual);
    }
}