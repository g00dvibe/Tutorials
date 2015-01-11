using System;

/* Which of the following values can be assigned to a variable of type float 
 * and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091 */

namespace FloatOrDouble
{
    class Program
    {
        static void Main()
        {
            double doubleNum = 34.567839023D;
            float floatNum = 12.345F;
            double secondDoubleNum = 8923.1234857;
            float secondFloatNum = 3456.091F;

            Console.WriteLine("Values who can be assigned to float are: {0} and {1}", floatNum, secondFloatNum);
            Console.WriteLine("Values who can be assigned to double are: {0} and {1}", doubleNum, secondDoubleNum);
        }
    }
}
