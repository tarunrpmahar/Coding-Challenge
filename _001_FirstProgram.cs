using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName, lName;
            Console.WriteLine("Hello User!");
            Console.WriteLine("Write your First Name: ");
            fName = Console.ReadLine();
            Console.WriteLine("Write your Last Name: ");
            lName = Console.ReadLine();
            Console.WriteLine("Your Name is {0} {1}", fName, lName);
        }
    }
}
