using System;

namespace loopsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number 5");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isCorrect = number == 5;

            do      //does this line of code before it checks the while condition
            {
                switch (number)     //starts the comparison
                {
                    case 5:     //specify what number we are looking for
                        Console.WriteLine("Very good! You typed the number 5.");
                        break;  //ends comparison
                    default:    //if none of the cases are true, this is what is executed
                        Console.WriteLine("You did not type the number 5. Please try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isCorrect);      //at the end of the loop to check if "isCorrect" is true, after the program has already run.

            Console.ReadLine();

        }
    }
}
