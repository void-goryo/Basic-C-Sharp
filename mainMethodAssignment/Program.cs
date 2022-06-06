using System;

namespace mainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //int opperations
            Math answers = new Math();
            Console.WriteLine("Please type a whole that you would like to preform math operations too.");
            int user1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(answers.Integer(user1));

            //double opperations
            Console.WriteLine("Please type another number that you would like to preform math opperations too. This can be a decimal.");
            double user2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(answers.Decimal(user2));

            //string
            Console.WriteLine("Please type a whole that you would like to preform math operations too.");
            string user3 = Console.ReadLine();

            Console.WriteLine(answers.Stringing(user3));

        }
    }
}
