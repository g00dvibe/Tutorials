/* Exercise 7: Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. */

using System;

namespace NumberSum
{
    class Task7
    {
        static void Main()
        {
            Console.Write("Please enter the number count: ");
            int readCount = int.Parse(Console.ReadLine());
            int[] numbers = new int[readCount];
            for (int index = 0; index < readCount; index++)
            {
                Console.Write("Number {0}: ", index + 1);
                numbers[index] = int.Parse(Console.ReadLine());
            }
            int result = 0;
            foreach (int i in numbers)
            {
                result = result + i;
            }
            Console.WriteLine("The Sum is: {0}", result);
        }
    }
}
