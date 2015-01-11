// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSum
{
    class Task6
    {
        static void Main()
        {
            Console.WriteLine("Input array lenght:");
            int n = int.Parse(Console.ReadLine());
            int[] theArr = new int[n];
            Console.WriteLine("Input the number \"K\":");
            int k = int.Parse(Console.ReadLine());
            int sum = 0;

            Console.WriteLine("Input the numbers of the array:");
            for (int i = 0; i < theArr.Length; i++)
            {
                theArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Array.Sort(theArr);
            Console.WriteLine("the array after sorting");
            for (int i = 0; i < theArr.Length; i++)
            {
                Console.Write ("{0} ",theArr[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = theArr.Length -1; i >= theArr.Length -k; i--)
            {
                Console.Write(theArr[i]);
                sum += theArr[i];
            }
            Console.WriteLine("the maximal sum achieved is: {0}", sum);
            Console.WriteLine();
        }
    }
}
