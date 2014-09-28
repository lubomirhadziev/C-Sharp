using System;

class Program
{
    static void Main()
    {
        int[] bitsToExchange = new int[3] {3, 4, 5};
        int[] exchangeBitsWith = new int[3] {24, 25, 26};

        int bitsToExchangeCount = bitsToExchange.Length;

        while(true)
        {
            uint number = uint.Parse(Console.ReadLine());

            for (int i = 0; i < bitsToExchangeCount; i++)
            {
                byte bitToExchange = getBitAtPosition(number, bitsToExchange[i]);
                byte exchangeBitWith = getBitAtPosition(number, exchangeBitsWith[i]);

                number = changeBitAtPoisiton(number, bitsToExchange[i], exchangeBitWith);
                number = changeBitAtPoisiton(number, exchangeBitsWith[i], bitToExchange);
            }

            Console.WriteLine(number);
            Console.WriteLine();
        }
    }

    static uint changeBitAtPoisiton(uint number, int position, byte bitToSet)
    {
        uint mask = (uint)(1 << position);
        uint newNumber = 0;

        if (bitToSet == 0)
        {
            newNumber = number & (~mask);
        }
        else
        {
            newNumber = number | mask;
        }

        return newNumber;
    }

    static byte getBitAtPosition(uint number, int position)
    {
        number = number >> position;

        uint mask = number & 1;

        return (byte)mask;
    }
}