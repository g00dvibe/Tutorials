// Write a method GetMax() with two parameters that returns the bigger of two integers.
// Write a program that reads 3 integers from the console and prints 
// the biggest of them using the method GetMax().


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxMethod
{
    class Task2
    {
        static int GetMax(int num1, int num2)
        {
            int max = num1;
            if (num2 > num1)
            {
                max = num2;
            }
            return max;
        }
        static void Main()
        {
            int[] threeNums = new int[3];
            Console.WriteLine("Please input the three numbers for comparison:");
            int theMax = 0;
            for (int i = 0; i<3; i++)
            {
                Console.Write("number {0}: ", i+1);
                threeNums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            theMax = GetMax(threeNums[0], threeNums[1]);
            if (theMax < threeNums[2])
            {
                theMax = threeNums[2];
            }
            Console.WriteLine("The biggest number of them 3 is: {0}", theMax);
        }
    }
}