using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAcc
    {
        static void Main()
        {
            
            Console.WriteLine("Personal Information:");
            Console.WriteLine(); 
            string firstName = "Petar";
            string middleName = "Georgiev";
            string lastName = "Fandakov";
            object fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine();
            Console.WriteLine(new string('*', 50)); 

            Console.WriteLine("Account Information:");
            Console.WriteLine(); 
            decimal balance = 25.7M;
            string bankName = "DSK Bank";
            string IBAN = "BG 00 AAАА 1231 1012345678";
            string bicCode = "STSABGSF";
            Console.WriteLine("'{0}' has a balance of '{1} billions',\nIBAN '{2}' and BIC code '{3}'", bankName, balance, IBAN, bicCode);
            Console.WriteLine();
            Console.WriteLine(new string('*', 50)); 

            Console.WriteLine("Credit Cards:");
            Console.WriteLine(); 
            long firstCreditCard = 480670058501455;
            long secondCreditCard = 4648810002719787;
            long thirdCreditCard = 8961301757293048;
            Console.WriteLine("First credit card №: '{0}' .\nSecond credit card №: '{1}' .\nThird credit card №: '{2}' .", firstCreditCard, secondCreditCard, thirdCreditCard);
            Console.WriteLine();
        }
    }
}
