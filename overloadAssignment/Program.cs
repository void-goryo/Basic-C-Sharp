using System;

namespace overloadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee user1 = new Employee() { Id = 1234 };
            Employee user2 = new Employee() { Id = 1234 };

            Console.WriteLine(user1 == user2);
            Console.ReadLine();
        }
    }
}
