// Write a program that fills and prints a matrix of size (n, n) as shown below
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillMatrix
{
    class Task1
    {
        static void Main()
        {
            // Im going to use the same input for all the subprograms
            int n = int.Parse(Console.ReadLine());
            int[,] theArr = new int[n, n];
            int counter = 1;
            Console.WriteLine("subtask A)");
            //automaticly fill the matrix
            for (int row = 0; row < theArr.GetLength(0); row++)
            {
                for (int column = 0; column < theArr.GetLength(1); column++)
                {
                    theArr[row,column] = counter;
                    counter++;
                }
            }
            //display the results
            for (int column = 0; column < theArr.GetLength(0); column++)
            {
                for (int row = 0; row < theArr.GetLength(1); row++ )
                {
                    Console.Write("{0} ",theArr[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // here's point B) 

            Console.WriteLine("subtask B)");
            counter = 1;
            //automaticly fill the matrix
            for (int row = 0; row < theArr.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int column = 0; column < theArr.GetLength(1); column++)
                    {

                        theArr[row, column] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int column =theArr.GetLength(1) - 1; column >= 0; column--)
                    {
                        theArr[row, column] = counter;
                        counter++;
                    }
                }
            }
            //display the results
            for (int column = 0; column < theArr.GetLength(0); column++)
            {
                for (int row = 0; row < theArr.GetLength(1); row++)
                {
                    Console.Write("{0} ", theArr[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            /*
            // here's pont C)
            Console.WriteLine("subtask C)");
            counter = 1;
            int startRow, startCol;
            startRow = n-1;
            startCol = 0;

            //
            
            for (int row = theArr.GetLength(0) - 1; row <= 0; row--)
            {

                {
                    if (startRow != 0)
                    {
                        for (int column = 0; column < theArr.GetLength(1); column++)
                        {

                            theArr[row, column] = counter;
                            counter++;
                        }
                    }
                    else
                    {
                        for (int column = theArr.GetLength(1) - 1; column >= 0; column--)
                        {
                            theArr[row, column] = counter;
                            counter++;
                        }
                    }
                }
                //display the results
                for (int column = 0; column < theArr.GetLength(0); column++)
                {
                    for (int row = 0; row < theArr.GetLength(1); row++)
                    {
                        Console.Write("{0} ", theArr[row, column]);
                    }
                    Console.WriteLine();
                }



            }
            */
        }
    }
}
