using System;

namespace branchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //package weight
            Console.WriteLine("Please enter the weight in pounds of the package: ");
            int lb = Convert.ToInt32(Console.ReadLine());


            //weight check
            if (lb >= 50)
            {
                Console.WriteLine("This package is too heavy to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
                System.Environment.Exit(1);
            }

            //package demensions
            Console.WriteLine("Please enter the length in inches of the package: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the width in inches of the package: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the width in inches of the package: ");
            int height = Convert.ToInt32(Console.ReadLine());

            //dimensions check
            if (length >= 50 || width >= 50 || height >= 50)
            {
                Console.WriteLine("This package is too big to be shipped via Package Express. Have a good Day!");
                Console.ReadLine();
                System.Environment.Exit(1);
            }

            //price
            int finalPrice = ((height * length * width) * lb) / 100;

            Console.WriteLine("Your estmated total for shipping this package is: $" + finalPrice + "\nThank you!");

        }
    }
}
