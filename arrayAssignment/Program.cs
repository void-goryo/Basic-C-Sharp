using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //select a string
        string[] stringArray = { "Gabe", "Tyler", "Celia", "Kaylee", "Emily" };
        Console.WriteLine("Please enter in a number between 0 - 4 to display a name.");
        int name = Convert.ToInt32(Console.ReadLine());
        bool loop = false;

        while (!loop)
        {
            if(name < 5)
            {
                Console.WriteLine(stringArray[name]);
                loop = true;
                break;
            }
            else
            {
                Console.WriteLine("There is no name in that spot. please try again.");
                name = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.ReadLine();

        //select a number
        loop = false;
        int[] intArray = { 2, 5, 4, 6, 8, 10 };
        Console.WriteLine("Please enter a number between 0 - 5 to reveal a new number.");
        int number = Convert.ToInt32(Console.ReadLine());

        while (!loop)
        {
            if(number < 6)
            {
                Console.WriteLine(intArray[number]);
                loop = true;
                break;
            }
            else
            {
                Console.WriteLine("There is no number in that spot. Please try again.");
                number = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.ReadLine();

        //select a game list
        List<string> stringList = new List<string>();
        stringList.Add("Destiny 2");
        stringList.Add("Borderlands 2");
        stringList.Add("Final Fantasy");

        loop = false;
        Console.WriteLine("Please enter a number between 0 - 2 to reveal a game title.");
        int game = Convert.ToInt32(Console.ReadLine());
        while (!loop)
        {
            if (game < 3)
            {
                Console.WriteLine(stringList[game]);
                loop = true;
                break;
            }
            else
            {
                Console.WriteLine("There is no game title in that spot. Please try again.");
                game = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.ReadLine();
    }
}