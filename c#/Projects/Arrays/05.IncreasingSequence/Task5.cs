//Write a program that finds the maximal increasing sequence in an array.  
// Example:{3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequence
{
    class Task5
    {
        static void Main()
        {
            Console.WriteLine("Input array lenght:");
            int n = int.Parse(Console.ReadLine());
            int[] theArr = new int[n];
            int maxHits = 0;
            int consecutiveHits = 1;
            int sequenceNum = 0;


            Console.WriteLine("Input the numbers of the array:");
            for (int i = 0; i < theArr.Length; i++)
            {
                theArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < theArr.Length - 1; i++)
            {
                if (theArr[i] + 1 == theArr[i + 1]) consecutiveHits++;
                else
                {
                    if (maxHits < consecutiveHits)
                    {
                        maxHits = consecutiveHits; //nuff variables for every need
                        sequenceNum = theArr[i];
                    }
                    consecutiveHits = 1;
                }
            }
            // lez' display the results?!

            Console.WriteLine();
            Console.WriteLine("The longest increasing sequence is {0} numbers long.\nHere's also a visual representation:", maxHits);
            Console.WriteLine();
            for (int i = maxHits -1; i >=0 ; i--)
            {
                Console.Write("{0} ", (sequenceNum - i));
            }
            Console.WriteLine();

        }
    }
}
