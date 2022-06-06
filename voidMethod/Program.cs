using System;

namespace voidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Math user = new Math();
            Console.WriteLine("Please enter two numbers.");
            Console.WriteLine("First number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number");
            int num4 = Convert.ToInt32(Console.ReadLine());
            user.addition(num3, num4);
        }
    }
}
