using System;

namespace MarketingFirm
{
    class Program
    {
        static void Main()
        {
            string firstName = "Haralampii";
            string familyName = "Stamatov";
            int age = 47;
            string gender = "Male";
            int idNumber = 3309212;
            int employeeNumber = 4003479;

            Console.WriteLine("Employee by name {0} {1} is {2} years old and its gender is {3}.{6}His ID number is {4} and unique employee number is {5}", firstName, familyName, age, gender, idNumber, employeeNumber, Environment.NewLine);
        }
    }
}
