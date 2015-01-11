//Write a program that finds the greatest of given 5 variables.


using System;

namespace BiggestOfFive
{
    class Task7
    {
        static void Main()
        {
            Console.Write("input the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("input the second number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("input the third number:");
            int c = int.Parse(Console.ReadLine());
            Console.Write("input the fourth number:");
            int d = int.Parse(Console.ReadLine());
            Console.Write("input the fifth number:");
            int e = int.Parse(Console.ReadLine());
            int greater;

            greater = a;
            if (greater < b)
            {
                greater = b;
            }
            if (greater < c)
            {
                greater = c;
            }
            if (greater < d)
            {
                greater = d;
            }
            if (greater < e)
            {
                greater = e;
            }

            Console.WriteLine("The biggest number is: {0}", greater);
        }
    }
}
