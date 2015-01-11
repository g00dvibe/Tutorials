//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSequence
{
    class Task4
    {
        static void Main()
        {
            Console.WriteLine("Input array lenght:");
            int n = int.Parse(Console.ReadLine());
            int[] theArr = new int[n];
            int maxHits = 0;
            int consecutiveHits = 1;
            int sequenceNum =0;


            Console.WriteLine("Input the numbers of the array:");
            for (int i = 0; i < theArr.Length; i++)
            {
                theArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i<theArr.Length -1 ; i++)
            {
                if (theArr[i] == theArr[i + 1]) consecutiveHits++;
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
            Console.WriteLine("The longest sequence is {0} numbers long, and consist of \"{1}\" \nHere's also a visual representation:", maxHits, sequenceNum);
            Console.WriteLine();
            for (int i=0; i<maxHits; i++)
            {
                Console.Write("{0},", sequenceNum );
            }
            Console.WriteLine();

        }
    }
}
