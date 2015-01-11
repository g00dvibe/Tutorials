// Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumInArr
{
    class Task9
    {
        static void Main()
        {
            Console.WriteLine("Input array lenght:");
            int n = int.Parse(Console.ReadLine());
            int[] theArr = new int[n];            
            int i,j;
            int temp = 0;
            int mostRepeated = 0;
            int theNumber = theArr[0];

            Console.WriteLine("Input the numbers of the array:");
            for (i = 0; i < theArr.Length; i++)
            {
                theArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            //this is where the magic happens
            for (i =0; i< theArr.Length; i++)
            {
                temp = 0;
                for (j = 0; j < theArr.Length; j++)
                {
                    if (theArr[i] == theArr[j])
                    {
                        temp++;
                    }
                    //Console.WriteLine("The number {0} is repeated {1} times.",element,mostRepeated);
                }
                if (mostRepeated < temp)
                {
                    mostRepeated = temp;
                    theNumber = theArr[i];
                }
            }
            Console.WriteLine("The number {0} is repeated {1} times.", theNumber, mostRepeated);
        }
    }
}
