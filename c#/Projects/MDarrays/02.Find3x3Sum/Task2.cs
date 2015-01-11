// Write a program that reads a rectangular matrix of size N x M 
// and finds in it the square 3 x 3 that has maximal sum of its elements.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find3x3Sum
{
    class Task2
    {
        static void Main()
        {
            Console.WriteLine("There's a matrix with NxM size. \nPlease input N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input M:");
            int m = int.Parse(Console.ReadLine());
            int[,] theArr = new int[n,m];
            int bestSum = 0;
            int[,] bufferArr = new int[3, 3];

            // input the numbers in the matrix
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < m; column++)
                {
                    Console.Write("matrix[ {0} , {1} ] = ", row, column);                    
                    theArr[row, column] = int.Parse(Console.ReadLine());
                }
            }



            // check the matrix
            for (int row =0; row<n-3; row++)
            {
                for (int col=0; col<m-3; col++)
                {
                    int sum = theArr[row, col] + theArr[row, col + 1] + theArr[row + 1, col] + theArr[row + 1, col + 1]
                        + theArr[row + 2, col + 2] + theArr[row + 2, col + 1] + theArr[row + 2, col] + theArr[row + 1, col + 2] + theArr[row, col + 2];
                    if (sum > bestSum)
                    { 
                        bestSum = sum;
                        bufferArr[0, 0] = theArr[row, col]; bufferArr[0, 1] = theArr[row, col + 1]; bufferArr[1, 0] = theArr[row + 1, col]; bufferArr[1,1] = theArr[row + 1, col + 1];
                        bufferArr[2,2] = theArr[row + 2, col + 2]; bufferArr[2,1] = theArr[row + 2, col + 1]; bufferArr[2,0] = theArr[row + 2, col];
                        bufferArr[1, 2] = theArr[row + 1, col + 2]; bufferArr[0, 2] = theArr[row, col + 2];
                    }
                }
            }

            // display the results
            Console.WriteLine("first here's the matrix you inputed:");

            for (int column = 0; column < theArr.GetLength(0) -1; column++)
            {
                for (int row = 0; row < theArr.GetLength(1) -1; row++)
                {
                    Console.Write("{0} ", theArr[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("The biggest sum achieved in a 3x3 block in the matrix is: {0}", bestSum);

            for (int column = 0; column < bufferArr.GetLength(0); column++)
            {
                for (int row = 0; row < bufferArr.GetLength(1); row++)
                {
                    Console.Write("{0} ", theArr[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
//im proud of myself