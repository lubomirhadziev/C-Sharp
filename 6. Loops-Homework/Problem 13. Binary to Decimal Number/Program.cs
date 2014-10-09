using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string str = Console.ReadLine();
            double output = 0;

            for (int i = 0; i < str.Length; i++)
            {
                output += (Char.GetNumericValue(str[i]) * Math.Pow(2, (str.Length - i-1)));
            }
            
            Console.WriteLine(output);
            Console.WriteLine();
        }
    }
}