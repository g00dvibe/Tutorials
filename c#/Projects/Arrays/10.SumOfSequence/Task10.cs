// Write a program that finds in given array of integers a sequence of given sum S (if present).
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSequence
{
    class Task10
    {
        static void Main()
        {
            Console.WriteLine("Input array lenght:");
            int n = int.Parse(Console.ReadLine());
            int[] theArr = new int[n];
            Console.WriteLine("Input the sum you're looking after \"S\":");
            int s = int.Parse(Console.ReadLine());
     //       int sum = 0;
            int i;
            
            

            Console.WriteLine("Input the numbers of the array:");
            for ( i = 0; i < theArr.Length; i++)
            {
                theArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            int maxSoFar = theArr[0];
            int maxEndingHere = theArr[0];
            int begin = 0;
            int begin_temp = 0;
            int end = 0;

            for (i = 0; i < theArr.Length; i++)
            {
                if (maxEndingHere != s) // first we make sure to update the temporary variables to the first index of the array
                {
                    maxEndingHere = theArr[i];
                    begin_temp = i;
                }
                else
                {
                    maxEndingHere += theArr[i];
                }
                if (maxEndingHere == s) 
                {
                    maxSoFar = maxEndingHere;
                    begin = begin_temp;
                    end = i;
                }                
            }
            Console.WriteLine();
            Console.WriteLine("The sequence with the sum \"S\" ({0}) is:",s);
            for (i = begin; i <= end; i++)
            {
                Console.Write("{0} ", theArr[i]);
            }
         //   Console.WriteLine("the maximum sum is: {0}", maxSoFar);
            Console.WriteLine();
        }
    }
}
