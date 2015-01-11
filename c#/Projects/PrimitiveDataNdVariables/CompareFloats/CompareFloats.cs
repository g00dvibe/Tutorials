using System;

//Write a program that safely compares floating-point numbers with precision of 0.000001.
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

namespace CompareFloats
{
    class CompareFloats
    {
        static void Main()
        {
            
            Console.WriteLine("Please write down the first number for comparison:");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Please write down the second number for comparison:");
            float secondNumber = float.Parse(Console.ReadLine());
            float precision = 0.000001f;
            bool compare = Math.Abs(firstNumber - secondNumber) < precision;
            Console.WriteLine("Are the two numbers equal with precision 0.000001 ? - {0}", compare);   
        }
    }
}
