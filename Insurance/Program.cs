using System;

namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {

            //user information
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());

            //Print user information
            Console.WriteLine("\n\n\n\n\nWhat is your age?");
            Console.WriteLine(age);
            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine(dui);
            Console.WriteLine("How many speeding tickets do you have?");
            Console.WriteLine(ticket);

            //insurance check
            if(age <= 15)
            {
                bool insurance = false;
                Console.WriteLine("Qualified for insurance?");
                Console.WriteLine(insurance);
                Console.ReadLine();
            }
            else if(dui == true) {
                bool insurance = false;
                Console.WriteLine("Qualified for insurance?");
                Console.WriteLine(insurance);
                Console.ReadLine();
            }
            else if (ticket >= 3)
            {
                bool insurance = false;
                Console.WriteLine("Qualified for insurance?");
                Console.WriteLine(insurance);
                Console.ReadLine();
            }
            else
            {
                bool insurance = true;
                Console.WriteLine("Qualified for insurance?");
                Console.WriteLine(insurance);
                Console.ReadLine();
            }
        }
    }
}
