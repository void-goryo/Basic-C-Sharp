using System;

namespace AICP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1 input

            //hourly wage
            Console.WriteLine("What is the hourly wage of person 1?");
            double wage1 = Convert.ToDouble(Console.ReadLine());

            //hours works
            Console.WriteLine("How many hours do you work per week?");
            double hours1 = Convert.ToDouble(Console.ReadLine());



            //Person 2 input

            //hourly wage
            Console.WriteLine("What is the hourly wage of person 2?");
            double wage2 = Convert.ToDouble(Console.ReadLine());

            //hours works
            Console.WriteLine("How many hours do you work per week?");
            double hours2 = Convert.ToDouble(Console.ReadLine());


            //calculation

            //person 1 annual
            double person1 = wage1 * hours1 * 52;
            Console.WriteLine("Annual Salary of Person 1: " + person1.ToString());

            double person2 = wage2 * hours2 * 52;
            Console.WriteLine("Annual Salary of Person 2: " + person2.ToString());

        }
    }
}
