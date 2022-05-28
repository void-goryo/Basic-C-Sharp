using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //creating string array
        string[] stringArray = new string[] { "Tyler", "Emily", "Kaylee", "Celia" };
        Console.WriteLine("Please enter your last name.");
        string userString = Console.ReadLine();

        //itterate through string array
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = stringArray[i] + " " + userString;
        }

        foreach (string name in stringArray)
        {
            Console.WriteLine(name);
        }
        Console.ReadLine();

        //I'm honestly not sure what you're asking for on part two of the assignment, so this is my best take

        //infinite loop
        Console.WriteLine("SCP-2316");
        Console.WriteLine("Do you recognize the bodies in the water? answer yes or no.");
        string answer = Console.ReadLine().ToUpper();
        bool bodies = false;
        while (!bodies)
        {
            if(answer == "NO")
            {
                Console.WriteLine("Very Good.");
                Console.WriteLine("Do you recognize the bodies in the water? answer yes or no.");
                answer = Console.ReadLine().ToUpper();
            }
            else if (answer == "YES")
            {
                Console.Write("The Foundation told you that you don't recognize the bodies in the water. You are lost forever.");
                bodies = true;
                break;
            }
            else
            {
                Console.WriteLine("You did not answer yes or no.");
                Console.WriteLine("Do you recognize the bodies in the water? answer yes or no.");
                answer = Console.ReadLine().ToUpper();
            }
        }
        Console.ReadLine();

        //more loops

        for(int i = 0; i < 16; i++)
        {
            Console.WriteLine(i);
        }
        for(int i = 0; i <= 15; i++)
        {
            Console.WriteLine(i);
        }

        //list of strings
        List<string> fruits = new List<string>() { "Apple", "Blueberry", "Coconut", "Duran", "Eggplant", "Fuji Apple", "Grape" };
        Console.WriteLine("Please type a food that you would like to see.");
        string food = Console.ReadLine().ToLower();
        bool match = false;
        do
        {
            switch (food)
            {
                case "apple":
                    Console.WriteLine(fruits[0]);
                    match = true;
                    break;
                case "blueberry":
                    Console.WriteLine(fruits[1]);
                    match = true;
                    break;
                case "coconut":
                    Console.WriteLine(fruits[2]);
                    match = true;
                    break;
                case "Duran":
                    Console.WriteLine(fruits[3]);
                    match = true;
                    break;
                case "eggplant":
                    Console.WriteLine(fruits[4]);
                    match = true;
                    break;
                case "fuji apple":
                    Console.WriteLine(fruits[5]);
                    match = true;
                    break;
                case "grape":
                    Console.WriteLine(fruits[6]);
                    match = true;
                    break;
                default:
                    Console.Write("That food is not on the list. Please try again.\n");
                    food = Console.ReadLine().ToLower();
                    break;
            }
        }
        while (!match);
        Console.ReadLine();


        List<string> stringList = new List<string>() { "snake", "dog", "snake", "cat" };
        Console.WriteLine("Please select either a Dog, Cat, or Snake");
        string animal = Console.ReadLine().ToLower();
        match = false;

        for(int i = 0; i < stringList.Count; i++)
        {
            if(animal == stringList[i])
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadLine();

        //foreach loop
        int repeat = 0;
        foreach(string creature in stringList)
        {
            for(int i = 0; i < stringList.Count; i++)
            {
                for(int j = 0; j < stringList.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (stringList[i] == stringList[j])
                    {
                        repeat++;
                    }
                }
            }
            Console.WriteLine(creature);
        }
        if(repeat > 0)
        {
            Console.Write("An animal has appeared in the list more then once");
        }
        Console.ReadLine();
    }
}