using System;

namespace anotherMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math user = new Math();
            Console.WriteLine("Please enter two numbers. Note: you do not have to enter a second number");
            Console.WriteLine("Number one:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number two:");
            string? num4 = Console.ReadLine();
            if (num4 == "")
            {
                Console.WriteLine(user.CompAdd(num3));
            }
            else
            {
                int num5 = Convert.ToInt32(num4);
                Console.WriteLine(user.CompAdd(num3, num5));
            }
            Console.ReadLine();
         }
     }
}
