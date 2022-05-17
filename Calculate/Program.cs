using System;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {

            //get user input
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            //calculations
            int num1 = num * 50;
            Console.WriteLine(num.ToString() + " * 50 = " + num1.ToString());

            int num2 = num + 25;
            Console.WriteLine(num.ToString() + " + 25 = " + num2.ToString());

            double num3 = Convert.ToDouble(num) / 12.5;
            Console.WriteLine(num.ToString() + " / 12.5 = " + num3.ToString());

            bool greaterThan = num > 50;
            Console.WriteLine("Is " + num.ToString() + " greater than 50?     " + greaterThan);

            int num4 = num % 7;
            Console.WriteLine("The remainder of " + num.ToString() + " / 7 is " + num4.ToString());
            Console.ReadLine();

        }
    }
}
