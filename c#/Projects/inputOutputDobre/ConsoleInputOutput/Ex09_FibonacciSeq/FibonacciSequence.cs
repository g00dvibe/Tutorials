/* Exercise 9: Write a program to print the first 100 members of the sequence of
 * Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … */


using System;

namespace Ex09_FibonacciSeq
{
    class FibonacciSequence
    {
        static void Main()
        {
            decimal a = 0;
            decimal b = 1;
            for (int i = 1; i<100; i++)
            {
                Console.WriteLine(a);
                decimal sum = a + b;
                a = b;
                b = sum;
            }
        }
    }
}
