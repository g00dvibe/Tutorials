//Write a program that reads two arrays from the console and compares them element by element.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Task2
    {
        static void Main()
        {
            Console.WriteLine("Input arrays lenght: \n(both will be the same)");
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int [n];
            int[] secondArr = new int [n];

            Console.WriteLine("Input the numbers of the first array:");
            for (int i =0; i < firstArr.Length; i++)
            {
               firstArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Input the numbers of the second array:");
            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Position to be compared - {0}",i);
                if (firstArr[i] == secondArr[i]) Console.WriteLine("{0} = {1}",firstArr[i] , secondArr[i]);
                if (firstArr[i] < secondArr[i]) Console.WriteLine("{0} < {1}", firstArr[i], secondArr[i]);
                if (firstArr[i] > secondArr[i]) Console.WriteLine("{0} > {1}", firstArr[i], secondArr[i]);
            }
            Console.WriteLine();
        }
    }
}
