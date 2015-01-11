// Sorting an array means to arrange its elements in increasing order. 
// Write a program to sort an array. Use the "selection sort" algorithm:
// Find the smallest element, move it at the first position, 
// find the smallest from the rest, move it at the second position, etc.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAnArray
{
    class Task7
    {
        static void Main()
        {
            Console.WriteLine("Input array lenght:");
            int n = int.Parse(Console.ReadLine());
            int[] theArr = new int[n];
            int min = 0;
            int temp, i, j;

            Console.WriteLine("Input the numbers of the array:");
            for ( i = 0; i < theArr.Length; i++)
            {
                theArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            //this is where the magic happens
            for ( i = 0; i < theArr.Length - 1; i++)
            {
                min = i;

                for ( j = i+1; j<n; j++)
                {
                    if (theArr[j] < theArr[min]) min = j;
                }
                temp = theArr[i];
                theArr[i] = theArr[min];
                theArr[min] = temp;
            }           

            Console.WriteLine("The array after sorting:");
            for ( i = 0; i < theArr.Length; i++)
            {
                Console.Write("{0} ", theArr[i]);
            }
        }
    }
}
