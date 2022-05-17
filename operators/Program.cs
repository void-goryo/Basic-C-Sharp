using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}
