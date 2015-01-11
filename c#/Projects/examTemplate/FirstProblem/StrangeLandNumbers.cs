using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeLandNumbers
{
    class StrangeLandNumbers
    {        
        static int numeralSystem = 7;

        static long ConvertNum(int number)
        {
            long inDecimal = 1;
            for (int i=0; i<number; i++)
            {
                inDecimal *= numeralSystem;
            }
            return inDecimal;
        }

        static void Main(string[] args)
        {
            string strangeNum = Console.ReadLine();
            char[] strangeSeparators = { 'f' , 'b' , 'o' , 'm' , 'l' , 'p' , 'h' } ;
            int smsPosition = strangeNum.Length;
            long result = 0;           

            

           string[] elements =  strangeNum.Split(strangeSeparators);
             smsPosition = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                result += symbolToNumber(elements[i]) * ConvertNum(smsPosition);
                smsPosition++;
            }
            Console.WriteLine(result);
        }
        
        static int symbolToNumber(string symbol)
        {
            switch (symbol)
            {
                 case   ""      :  return 0	 ;   break;
                 case   "IN"    :  return 1	 ;   break;
                 case   "BJEC"  :  return 2	 ;   break;
                 case   "NTRAVL":  return 3	 ;   break;
                 case   "PVKNQ" :  return 4	 ;   break;
                 case   "NWE"   :  return 5	 ;   break;
                 case   "T"     :  return 6	 ;   break;

                default: return -1; break;
            }       
        }
    }
 }
    