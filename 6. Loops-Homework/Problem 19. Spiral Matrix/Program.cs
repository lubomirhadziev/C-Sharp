using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    private static string direction = "right";

    private static int number;
    private static int productNumber;
    
    private static int nextNumber = 1;

    private static int firstColumnNum = 1;

    //private static int row = 1;
    //private static int col = 1;

    private static int globalRow = 1;
    private static int globalCol = 1;

    private static Dictionary<string, int> matrix = new Dictionary<string, int>();

    static void Main()
    {
        //get number from console
        number = int.Parse(Console.ReadLine());

        int tempNumber = number;
        productNumber = number * number;

        //create matrix
        for (int i = 1; i <= productNumber; i++)
        {
            matrix[globalRow + "," + globalCol] = nextNumber;
            
            changeDirection();
        }


        //display matrix
        for (int row = 1; row <= tempNumber; row++)
        {
            for (int col = 1; col <= tempNumber; col++)
            {
                if (matrix.ContainsKey(row + "," + col))
                {
                    Console.Write("{0,3}", matrix[row + "," + col]);
                }
                else
                {
                    Console.Write("{0, 3}", 0);
                }
            }
            Console.WriteLine();
        }
    }

    static void changeDirection()
    {
        //
        if(nextNumber == productNumber)
        {
            return;
        }

        //turn right
        if (direction == "right" && (globalCol + 1) <= number)
        {
            globalCol++;
            nextNumber++;

            return;
        }
        else if (direction == "right" && (globalCol + 1) > number)
        {
            direction = "down";
        }


        //turn down
        if (direction == "down" && (globalRow + 1) <= number)
        {
            globalRow++;
            nextNumber++;
            return;
        }
        else if (direction == "down" && (globalRow + 1) > number)
        {
            direction = "left";
        }


        //turn left
        if (direction == "left" && (globalCol - 1) >= firstColumnNum)
        {
            globalCol--;
            nextNumber++;
            return;
        }
        else if (direction == "left" && (globalCol - 1) <= 0)
        {
            direction = "up";
        }


        //turn up
        if (direction == "up" && matrix.ContainsKey((globalRow - 1) + "," + globalCol) == false)
        {
            globalRow--;
            nextNumber++;
            return;
        }
        else if (direction == "up" && matrix.ContainsKey((globalRow - 1) + "," + globalCol))
        {
            direction = "right";
            number--;

            firstColumnNum++;

            changeDirection();
        }
    }


}