/* Exercise 3: A company has name, address, phone number, fax number, web site and manager.
 * The manager has first name, last name, age and a phone number.
 * Write a program that reads the information about a company and its manager and prints them on the console. */

using System;

namespace CompanyInfo
{
    class Task3
    {
        static void Main()
        {
            Console.WriteLine("Please, fill in the comapny information: ");
            Console.Write("\nName: ");
            string firmName = Console.ReadLine();

            Console.Write("Adress: ");
            string firmAdress = Console.ReadLine();

            Console.Write("Phone number: ");
            string firmPhone = Console.ReadLine();

            Console.Write("Fax: ");
            string firmFax = Console.ReadLine();

            Console.Write("Website: ");
            string firmSite = Console.ReadLine();

            Console.Write("Manager: ");
            string firmManager = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("\nManager information: ");
            Console.Write("\nFirst name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Age: ");
            string age = Console.ReadLine();

            Console.Write("Phone number: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("\n{0} is a company located in {1}.", firmName, firmAdress);
            Console.WriteLine("To contact {0}:\nPhone number: {1}\nFax: {2}\nWeb site: {3}", firstName, firmPhone, firmFax, firmSite);
            Console.WriteLine("\nThe company's current manager is {0}.", firmManager);
            Console.WriteLine();
            Console.WriteLine("\nThe company's manager is {0} {1}, a {2} year old genius,\nwho is trusted to bring the company back to her glorius days.", firstName, lastName, age);
            Console.WriteLine("\nTo contact our manager:\nPhone number: {0}", managerPhone);
        }
    }
}
