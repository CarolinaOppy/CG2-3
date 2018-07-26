using System;

namespace CG2_3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Carolina Costansa Oppy.");

            Console.Write("What is your first name? ");
            String firstName = Console.ReadLine();

            Console.Write("What is your middle name? ");
            String middleName = Console.ReadLine();

            Console.Write("What is your last name? ");
            String lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + middleName + " " + lastName + "!");
            Console.ReadLine();
        }
    }
}
