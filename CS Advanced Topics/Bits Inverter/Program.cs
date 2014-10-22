using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        //num of numbers
        byte n = byte.Parse(Console.ReadLine());

        //step
        byte step = byte.Parse(Console.ReadLine());

        //contain numbers
        var numbers = new List<byte>();

        for (int i = 0; i < n; i++)
        {
            numbers.Add(byte.Parse(Console.ReadLine()));
        }


        //convert all numbers to string in binary notation
        string stringNumbers = "";

        foreach (var number in numbers)
        {
            stringNumbers += Convert.ToString(number, 2).PadLeft(8, '0');
        }


        //convert string numbers to char array
        char[] numberChars = stringNumbers.ToCharArray();

        //steal from Bojzo: i += step
        for (int i = 0; i < numberChars.Length; i += step)
        {
            numberChars[i] = invertByte(numberChars[i]);
        }


        //convert binary notation to byte
        string binaryNotation = "";

        for (int i = 0; i < numberChars.Length; i++)
        {
            //append new bit
            binaryNotation += numberChars[i];

            //check for length
            if(binaryNotation.Length == 8)
            {
                //print new number
                Console.WriteLine("{0}", Convert.ToInt32(binaryNotation, 2));

                //clear binary buffer
                binaryNotation = "";
            }
        }
    }


    private static char invertByte(char currentByte)
    {
        char invertedByte = '0';

        if (currentByte == '0')
        {
            invertedByte = '1';
        }

        return invertedByte;
    }


}
