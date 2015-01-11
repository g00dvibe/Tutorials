// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).


using System;

namespace SomeMultiplication
{
    class Task5
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            decimal n = decimal.Parse(Console.ReadLine());
            Console.Write("Enter K (must be bigger than \"N\"): ");
            decimal k = decimal.Parse(Console.ReadLine());

            decimal nFact = 1;
            for (decimal i = 1; i <= n; i++)
            {
                nFact = nFact * i;
            }

            decimal resultRight = 1;
            for (decimal i = 0; i < (k - (k - n)); i++)
            {
                resultRight = resultRight * (k - i);
            }

            Console.WriteLine(nFact * resultRight);
        }
    }
}
