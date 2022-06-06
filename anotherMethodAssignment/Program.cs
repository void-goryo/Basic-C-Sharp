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
            int? num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(num4);
            user.CompAdd(num3, num5);

         }
     }
}
