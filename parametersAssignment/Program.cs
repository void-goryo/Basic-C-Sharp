using System;
using System.Collections.Generic;


namespace parametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> user1 = new Employee<string>();
            Employee<int> user2 = new Employee<int>();
            user1.things = new List<string>() { "Gabe", "Tyler" };
            user2.things = new List<int>() { 5, 10 };


            foreach (string i in user1.things)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            foreach (int i in user2.things)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


        }
    }
}
