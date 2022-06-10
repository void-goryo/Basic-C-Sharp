using System;

namespace trycatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Age year = new Age();
            Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(year.wasBorn(age));
            }
            catch (Exception)       //this runs when an exception has been thrown
            {
                Console.WriteLine("You have not been born yet.");
            }
            Console.ReadLine();
        }
    }
}
