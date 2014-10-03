using System;

class Program
{

    static void Main()
    {
        while (true)
        {
            //read all numbers from console and split by space
            string[] consoleStream = Console.ReadLine().Split(' ');

            //contain product of all odd numbers
            double productOdd = 1;

            //contain product of all even numbers
            double productEven = 1;

            for (int i = 0; i < consoleStream.Length; i++)
            {
                //parse string number to double number
                double parsedNumber = double.Parse(consoleStream[i]);

                //even
                if (i % 2 == 0 || i == 0)
                {
                    productEven *= parsedNumber;
                }
                else
                {
                    //odd
                    productOdd *= parsedNumber;
                }
            }

            //return results
            if (productEven == productOdd)
            {
                Console.WriteLine("yes\nproduct = {0,5}", productEven);
            }
            else
            {
                Console.WriteLine("no\nodd_product = {0,5} \neven_product = {1, 5}", productOdd, productEven);
            }

            Console.WriteLine();
        }
    }

}