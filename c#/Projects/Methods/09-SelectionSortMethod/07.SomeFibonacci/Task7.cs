// Write a program that reads a number N and calculates the sum of the first
// N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
// Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.


using System;


namespace SomeFibonacci
{
    class Task7
    {
        static void Main()
        {
            Console.WriteLine("\"N\" defines how much of the fibonnaci spiral u want to see.");
            Console.WriteLine("Input N:");
            ulong number = ulong.Parse(Console.ReadLine());
            ulong first = 0;
            ulong second = 1;
            ulong counter = 0;
            ulong fibonacci;
            Console.WriteLine("Here we go...."); System.Threading.Thread.Sleep(400);

            while (counter <= number)
            {
                Console.Write("{0},",first);
                fibonacci = first;
                first = second;
                second = fibonacci + second;
                counter++;
            }

        }
    }
}
