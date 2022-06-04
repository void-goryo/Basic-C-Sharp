using System;

namespace mainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math answers = new Math();
            Console.WriteLine("Please type a number that you would like to preform math operations too.");
            int user = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(answers.Mathmatics(user));
        }
    }
}
