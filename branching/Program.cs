using System;

namespace branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int currenttemp = 70;
            int roomtemp = 70;

            if (currenttemp == roomtemp)
            {
                Console.WriteLine("It is exactly room temperature.");
            }

            else if (currenttemp > roomtemp)
            {
                Console.WriteLine("The current temperature is above the room temperature.");
            }
            else if (currenttemp < roomtemp)
            {
                Console.WriteLine("The current temperature is below room temperature.");
            }
            Console.ReadLine();


            //acts like a if, else statement
            string comparisonResults = currenttemp == roomtemp ? "It is room temp." : "It is not room temp.";
            Console.WriteLine(comparisonResults);
            Console.ReadLine();

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + "! What is the temperature where you are?");
            int currenttemperature = Convert.ToInt32(Console.ReadLine());

            if (currenttemperature == roomtemp)
            {
                Console.WriteLine("It is exactly room temperature");
            }
            else if (currenttemperature > roomtemp)
            {
                Console.WriteLine("It is warmer then room temperature");
            }
            else if (currenttemperature < roomtemp)
            {
                Console.WriteLine("It is coller then room temperature");
            }
            else
            {
                Console.WriteLine("Something went wrong. Please try again later.");
            }


            Console.WriteLine("What is your favorite number?");
            int favnum = Convert.ToInt32(Console.ReadLine());

            string result = favnum == 12 ? "You have a great favorite number!!" : "Your favorite number sucks lol";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
