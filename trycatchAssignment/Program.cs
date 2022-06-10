using System;

namespace trycatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Age year = new Age();
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(year.wasBorn(age));

        }
    }
}
