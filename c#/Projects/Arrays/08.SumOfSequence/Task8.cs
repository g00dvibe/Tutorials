// Write a program that finds the sequence of maximal sum in given array. 
//	Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSequence
{
    class Task8
    {
        static void Main()
        {
            Console.WriteLine("Input array lenght:");
            int n = int.Parse(Console.ReadLine());
            int[] theArr = new int[n];
            int maxSoFar = theArr[0];
            int maxEndingHere = theArr[0];
            int begin = 0;
            int begin_temp = 0;
            int end = 0;
            int i;

            Console.WriteLine("Input the numbers of the array:");
            for (i = 0; i < theArr.Length; i++)
            {
                theArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (i = 0; i< theArr.Length; i++)
            {
                if (maxEndingHere <0) // first we make sure to update the temporary variables to the first index of the array
                {
                    maxEndingHere = theArr[i];
                    begin_temp = i;
                }
                else
                {
                    maxEndingHere += theArr[i];
                }
                if (maxEndingHere >= maxSoFar) // then we update the total result, which probably will be printed on the screen
                {
                    maxSoFar = maxEndingHere;
                    begin = begin_temp;
                    end = i;
                }                
            }
            Console.WriteLine();
            Console.WriteLine("The sequence with the maximal sum is:");
            for (i = begin; i <= end; i++)
            {
                Console.Write("{0} ", theArr[i]);
            }
            Console.WriteLine("the maximum sum is: {0}", maxSoFar);
            Console.WriteLine();
        }
    }
}
