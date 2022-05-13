using System;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is how you comment
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Your name is " + name);
            //Console.ReadLine();
            //Console.WriteLine("What is your favorite number?");
            //string number = Console.ReadLine();
            //int favnumber = Convert.ToInt32(number);
            //int total = favnumber + 5;
            //Console.WriteLine("Your favorite number plus 5 equals " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            //char randomLetter = "A";
            //char questionMark = "/u2103";
            
            decimal money = 100.5m;

            double heightInCentimeters = 211.1239087541;

            float secondsLeft = 2.62f;

            short tempOnMars = -341;

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();
            
        }
    }
}
