//// 01. Write a program that prints all the numbers from 1 to N.
/// first change ever

using System;

namespace From0toN
{
    class Task1
    {
        static void Main()
        {
            Console.Write("Enter the N number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
