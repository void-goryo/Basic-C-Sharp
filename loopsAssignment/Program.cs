using System;

namespace loopsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number 4.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            bool isCorrect1 = number1 == 4;

            while (!isCorrect1)
            {
                switch (number1)
                {
                    case 4:
                        Console.WriteLine("That is the correct number!");
                        isCorrect1 = true;
                        break;
                    default:
                        Console.WriteLine("That was not the right number.");
                        break;
                }
            }

            Console.WriteLine("Please enter the number 5.");
            int number2 = Convert.ToInt32(Console.ReadLine());
            bool isCorrect2 = number2 == 5;

            do      //does this line of code before it checks the while condition
            {
                switch (number2)     //starts the comparison
                {
                    case 5:     //specify what number we are looking for
                        Console.WriteLine("Very good! You typed the number 5.");
                        isCorrect2 = true;
                        break;  //ends comparison
                    default:    //if none of the cases are true, this is what is executed
                        Console.WriteLine("You did not type the number 5. Please try again.");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isCorrect2);      //at the end of the loop to check if "isCorrect" is true, after the program has already run.

            Console.ReadLine();

        }
    }
}
