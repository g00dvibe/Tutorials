// 04. Write a program that calculates N!/K! for given N and K (1<K<N).


using System;

namespace Division
{
    class Task4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K (must be smaller than \"N\"): ");
            int k = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = 0; i < (n - k); i++)
            {
                result = result * (n - i);
            }
            Console.WriteLine("{0}!/{1}! = {2}", n, k, result);
        }
    }
}
