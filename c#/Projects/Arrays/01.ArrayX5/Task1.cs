/* Write a program that allocates array of 20 integers and initializes
 * each element by its index multiplied by 5. Print the obtained array on the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayX5
{
    class Task1
    {
        static void Main()
        {
            int[] theArray = new int[20];
            
            for (int i = 0; i< theArray.Length; i++)
            {              
               theArray[i] = i*5;               
            }

            for (int j = 0; j<theArray.Length; j++)
            {
                Console.WriteLine("element[{0}] = {1}", j, theArray[j]);
            }
            Console.WriteLine();
        }
    }
}
