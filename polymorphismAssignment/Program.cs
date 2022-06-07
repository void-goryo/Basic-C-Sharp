using System;

namespace polymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee user = new Employee();
            IQuittable user1 = new Employee();
            Console.WriteLine("What is your first name?");
            user.firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            user.lastName = Console.ReadLine();

            user.SayName();
            user1.Quit();
        }
    }
}
