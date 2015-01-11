/* Exercise 1: Write a program that reads 3 integer numbers from the console and prints their sum. */

using System;

namespace IntegerSum
{
    class Task1
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the third number: ");
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;
            Console.WriteLine("The summation of the entered numbers is {0}.", sum);

        }
    }
}