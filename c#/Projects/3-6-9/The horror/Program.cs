using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_horror
{
    class Program
    {
        static void Main(string[] args)
        {
            string sheit = Console.ReadLine();
            int evenDigits = 0;
            int evenDigitsSum =0;
            char symbol = 'a';
            int symbolValue = 0;

            for (int i = 0; i <= (sheit.Length -1); i++)
            {
               
                if (i == 0 || (i % 2 == 0))
                {
                    symbolValue = 0;

                    if (char.IsDigit(sheit, i))
                    {
                        
                    evenDigits++;
                    symbol = sheit[i];
                    symbolValue = int.Parse((symbol.ToString()));                    
                    }
                    evenDigitsSum += symbolValue;
                }


            }

                Console.WriteLine("{0} {1}", evenDigits, evenDigitsSum);
        }
    }
}
