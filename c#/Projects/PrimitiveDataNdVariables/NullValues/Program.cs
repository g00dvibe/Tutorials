using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValues
{
    class Program
    {
        static void Main()
        {
            int? isNullInteger = null;
            Console.WriteLine("This is the integer with null value -> {0}", isNullInteger); 
            isNullInteger = 5; 
            Console.WriteLine("This is the integer with null value 5 -> {0}", isNullInteger);

            double? isNullDouble = null;
            Console.WriteLine("This is the double with null value -> {0}", isNullDouble);
            isNullDouble = 10; 
            Console.WriteLine("This is the integer with null value 10 -> {0}", isNullDouble);
        }
    }
}
