/* Exercise 4: Write a program that reads two positive integer numbers and prints how many numbers p exist
 * between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2. */

using System;

namespace Ex04_PositiveInt
{
    class PositiveIntegers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second integer: ");
            int b = int.Parse(Console.ReadLine());
            int num;

            if (a > b)              // Exchanges the values of "a" and "b", if the first integer is bigger than the second.
            {
                num = a;
                a = b;
                b = num;
            }
            if (a < b)             
            {
                int count = 0;
                for (int i = a; i <= b; i++)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine("The number count is: {0}", count);
            }
        }
    }
}
