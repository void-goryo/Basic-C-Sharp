using System;

namespace classAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to process");
            int input = Convert.ToInt32(Console.ReadLine());

            //You cannot instantiate the class due to it being a static class. This is how you would call the class and the methods inside of it.
            Math.Process(input);
            Math.Process(input, 5);
        }
    }
}
