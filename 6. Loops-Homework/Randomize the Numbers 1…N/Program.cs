using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int counter = 0;
        Random rnd = new Random();

        for (int i = 1; i <= n; i++, counter++)
        {
            numbers[counter] = i;
        }

        for (int i = 0; i < counter; i++)
        {
            int firstNumberRandomKey = rnd.Next(0, counter);
            int secondNumberRandomKey = rnd.Next(0, counter);

            int tempInt = numbers[firstNumberRandomKey];
            numbers[firstNumberRandomKey] = numbers[secondNumberRandomKey];
            numbers[secondNumberRandomKey] = tempInt;
        }

        for (int i = 0; i < counter; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}
