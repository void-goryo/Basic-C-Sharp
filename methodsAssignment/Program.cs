using System;

namespace methodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to preform math oppreations on?");
            Math userNum = new Math();
            userNum.number = Convert.ToInt32(Console.ReadLine());
        }
    }
}
