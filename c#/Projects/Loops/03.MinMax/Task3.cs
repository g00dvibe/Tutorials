// Write a program that reads from the console a sequence of N 
// integer numbers and returns the minimal and maximal of them.


using System;
using System.Linq;

namespace MinMax
{
    class Task3
    {
        static void Main()
        {
            Console.Write("Enter the numbers count: "); 
            int numberCount = int.Parse(Console.ReadLine());
            Console.Write("Now enter the numbers:\n");
            int[] numberArray = new int[numberCount];                   //used array for easier input and calculation
            int minimum;
            int maximum;

            for (int i = 0; i < numberCount; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }

            minimum = numberArray.Min();
            maximum = numberArray.Max();

            Console.WriteLine("The smallest number is {0}", minimum);
            Console.WriteLine("The biggest number is {0}", maximum);
        }
    }
}
