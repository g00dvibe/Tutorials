// Write a method that counts how many times given number appears in given array. 
// Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumCountInArray
{
    class Task4
    {
        static  int Counter(int number, int[] someArr) 
        {
            int count = 0;
            for (int i = 0; i < someArr.Length; i++)
            {
                if (number == someArr[i]) count++;
            }
            return count; 
        }
        static void Main()
        {
            int[] theArr = new int[10];

            Console.WriteLine("Input the numbers of the array:");
            for (int i = 0; i < theArr.Length; i++)
            {
                theArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write("What number are you looking for? \nNumber:");
            int theNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The number {0}, was found {1} times in the given array.", theNumber, Counter(theNumber, theArr));
        }
    }
}
