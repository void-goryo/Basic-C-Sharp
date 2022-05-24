using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math Operators
            int total = 5 + 10;
            Console.WriteLine("5 + 10 = " + total.ToString());
            Console.ReadLine();
            int othertotal = 12 + 22;
            int combined = total + othertotal;
            Console.WriteLine(combined);
            Console.ReadLine();
            int difference = 10 - 5;
            Console.WriteLine("10 - 5 = " + difference.ToString());
            Console.ReadLine();
            int product = 10 * 5;
            Console.WriteLine("10 * 5 = " + product.ToString());
            Console.ReadLine();
            double quotient = 100.0 / 17.0;
            Console.WriteLine("100 / 17 = " + quotient.ToString());
            Console.ReadLine();
            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            //Comparison Operators

            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            int roomtemp = 70;
            int currenttemp = 70;
            //bool isWarm = currenttemp >= roomtemp;
            //bool isWarm = currenttemp == roomtemp;
            bool isWarm = currenttemp != roomtemp;
            Console.WriteLine(isWarm);
            Console.ReadLine();

            int num1 = 5;
            int num2 = 10;

            string result = num1 < num2 ? "num2 is greater then num1" : "num1 is not greater then num2";
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
