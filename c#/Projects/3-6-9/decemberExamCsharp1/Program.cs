using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decemberExamCsharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long r = 0;
            long dividedR;
            long modR;

            if (b == 3) 
            {   r = a + c;}
            if (b == 6)
            {   r = a * c;}
            if (b == 9)
            {   r = a % c;}


            if (r % 3 == 0)
            { 
                dividedR = r / 3;
                
                Console.WriteLine(dividedR);
                Console.WriteLine(r);
            } 
            else
            {
                modR = r % 3;
               
                Console.WriteLine(modR);
                Console.WriteLine(r);
            }
        }
    }
}
