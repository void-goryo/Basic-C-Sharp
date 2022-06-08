using System;

namespace structAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();

            num.Amount = 3;
            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }
}
