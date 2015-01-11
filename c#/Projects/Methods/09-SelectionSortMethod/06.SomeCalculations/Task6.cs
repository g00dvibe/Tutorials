using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeCalculations
{
    class Task6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Enter X: ");
            double x = double.Parse(Console.ReadLine());

            double numerator = 1;
            double denominator = 1;
            double singleResult = 0;
            double totalResult = 0;

            for (double i = n; i >= 1; i--)
            {
                for (double j = 1; j <= i; j++)
                {
                    numerator = numerator * j;
                    denominator = denominator * x;
                }
                singleResult = numerator / denominator;
                Console.WriteLine("{0}!/{1}^{0} = {2} / {3} = {4}", i, x, numerator, denominator, singleResult);
                numerator = 1;
                denominator = 1;
                totalResult += singleResult;
            }
            Console.WriteLine("-----------");
            Console.WriteLine("Total Sum: {0}", totalResult + 1);
        }
    }
}
