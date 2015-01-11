// Write a program that reads from the console a positive integer
// number N (N < 20) and outputs a matrix .

using System;

namespace SomeMatrix
{
    class Task12
    {
        static void Main()
        {
            Console.WriteLine("input \"n\",which must be under 20:");
            int n = int.Parse(Console.ReadLine());

            if (n < 20)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 1 + i; j <= n + i; j++)
                    {
                        Console.Write("{0} ",j);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
