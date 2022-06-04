using System;

namespace methodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //gathers user input
            Console.WriteLine("What number would you like to preform math oppreations on?");
            Math userNum = new Math();
            int input = Convert.ToInt32(Console.ReadLine());


            //calling and printing methods
            Console.WriteLine(userNum.Addition(input));

            Console.WriteLine(userNum.Subtraction(input));

            Console.WriteLine(userNum.multi(input));
        }
    }
}
