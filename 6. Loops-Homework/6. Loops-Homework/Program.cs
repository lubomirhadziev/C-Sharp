using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double min = 0;
        double max = 0;
        double sum = 0;
        double avg = 0;

        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());

            //min
            if (number < min || min == 0)
            {
                min = number;
            }

            //max
            if (number > max || max == 0)
            {
                max = number;
            }

            //sum
            sum += number;
        }

        //calculate avg number
        avg = sum / n;

        Console.WriteLine("min = {0:.##} \nmax = {1:.##} \nsum = {2:.##} \navg = {3:.##}", min, max, sum, avg);
    }
}