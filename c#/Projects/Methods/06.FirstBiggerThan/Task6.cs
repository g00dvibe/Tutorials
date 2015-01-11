// Write a method that returns the index of the first element in array 
// that is bigger than its neighbors, or -1, if there’s no such element.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FirstBiggerThan
{
    class Task6
    {        
            static int NeighbourCheck(int[] someArr)
            {
                int index = -1;
                
                for (int j = 1; j < someArr.Length-1; j++ )
                {
                    
                    if ((someArr[j] > someArr[j + 1]) && (someArr[j] > someArr[j - 1]))
                    {
                        index = j;
                        return index;
                    }
                }

                return index;  
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

            Console.Write("Now the program will find the first \"bigger than it's neigbours\" number \nand print it on the screen.");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("The index of the number is: {0} \nThe number itself is: {1}", NeighbourCheck(theArr), theArr[NeighbourCheck(theArr)]);            
        }
        
    }
}