//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class Task7
    {
        static void Main()
        {
            bool isPrime = true;

            for (int i = 2; i <= 100; i++)
            {
                    for (int j = 2; j <= 100; j++) // This way the number cant be divided by a larger value than its own
                    {                               //
                        if (i != j && i % j == 0)  // and if the remainder is 0 the number the second cycle stops and the number is printed.
                        {                           
                            isPrime = false;
                            break;
                        }
                    }

                if (isPrime == true)
                    {
                        Console.WriteLine("Prime=" + i);
                    }
                isPrime = true;
            }
        }
    }
}
