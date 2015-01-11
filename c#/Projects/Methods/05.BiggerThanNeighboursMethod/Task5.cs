//  Write a method that checks if the element at given position in given array of integers
//  is bigger than its two neighbors (when such exist).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerThanNeighboursMethod
{
    class Task5
    {
        static void NeighbourCheck(int number, int[] someArr)
        {
            if (number -1 <= 0 || number + 1 >= someArr.Length - 1)
            {
                Console.WriteLine("The index doesn't have a left or right neighbour");                
            }
            else
            {
                if ((someArr[number] > someArr[number + 1]) && (someArr[number] > someArr[number - 1]))
                {
                    Console.WriteLine("The number at position {0} is bigger than it's neighbours", number);

                }
                else Console.WriteLine("The number at position {0} isn't bigger than it's neighbours", number);
            }
        }
        static void Main()
        {
            int[] theArr = new int[10];

            Console.WriteLine("Input the numbers of the array:");
            for (int i = 0; i < theArr.Length; i++)
            {
                theArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write("Which element would you like to check is it bigger than it's neighbours? \nInput the index of the element between 0 and {0} :", theArr.Length);
            int position = int.Parse(Console.ReadLine());          

            NeighbourCheck(position, theArr);            
        }
    }
}
