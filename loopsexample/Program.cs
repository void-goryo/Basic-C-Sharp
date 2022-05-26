using System;

namespace loopsexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number>");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("you guessed 62. Try again.");
                        Console.WriteLine("Guess a number>");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("Your guessed 29. Try again.");
                        Console.WriteLine("Guess a number>");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("Your guessed 55. Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed correct!!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
