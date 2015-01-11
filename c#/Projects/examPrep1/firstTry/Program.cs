using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace firstTry
{
    class ZergProblem
    {
        static int numeralSystem = 15;

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
            string zergChat = Console.ReadLine();
            int smsPosition = zergChat.Length / 4 - 1;
            long result = 0;
            int in15numeral = 0;
            for (int i = 0; i < zergChat.Length; i+=4)
            {
                var decryptedNum = zergChat.Substring(i, 4);
            //    in15numeral = decryptZerg(decryptedNum);
                result += decryptZerg(decryptedNum) * ConvertNum(smsPosition);
                
                smsPosition--;
            }
            Console.WriteLine(result);
        }
        
        static int decryptZerg(string zergSMS)
        {
            switch (zergSMS)
            {
                case  "Rawr" : return 0;    break;
                case  "Rrrr" : return 1;    break;
                case  "Hsst" : return 2;    break;
                case  "Ssst" : return 3;    break;
                case  "Grrr" : return 4;    break;
                case  "Rarr" : return 5;    break;
                case  "Mrrr" : return 6;    break;
                case  "Psst" : return 7;    break;
                case  "Uaah" : return 8;    break;
                case  "Uaha" : return 9;    break;
                case  "Zzzz" : return 10;   break;
                case  "Bauu" : return 11;   break;
                case  "Djav" : return 12;   break;
                case  "Myau" : return 13;   break;
                case  "Gruh" : return 14;   break;
                default: return 0; break;
            }       
        }
    }
}
/*
Rawr
Rrrr
Hsst
Ssst
Grrr
Rarr
Mrrr
Psst
Uaah
Uaha
Zzzz
Bauu
Djav
Myau
Gruh
*/