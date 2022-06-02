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
        List<string> fruits = new List<string>() { "apple", "blueberry", "coconut", "duran", "eggplant", "fuji apple", "grape" };
        Console.WriteLine("Please type a food that you would like to see.");
        string food = Console.ReadLine().ToLower();

        int results = 0;
        for(int i = 0; i < fruits.Count; i++)
        {
            if(food == fruits[i])
            {
                Console.WriteLine(i);
                results++;
            }
        }

        if(results == 0)
        {
            Console.WriteLine("There is not " + food + " in this list");
        }

        Console.ReadLine();


        List<string> stringList = new List<string>() { "snake", "dog", "snake", "cat" };
        Console.WriteLine("Please select either a Dog, Cat, or Snake");
        string animal = Console.ReadLine().ToLower();

        int onList = 0;
        for(int i = 0; i < stringList.Count; i++)
        {
            if(animal == stringList[i])
            {
                Console.WriteLine(i);
                onList++;
            }
        }
        if(onList == 0)
        {
            Console.WriteLine("That was not on the list...");       
        }
        Console.ReadLine();

        //foreach loop
        List<string> compare = new List<string>();
        foreach (string creature in stringList)
        {
            if (compare.Contains(creature))
            {
                Console.WriteLine(creature + " has shown up more than once in the list");
            }
            else
            {
                Console.WriteLine(creature + " has shown up once");
                compare.Add(creature);
            }
        }
        Console.ReadLine();
    }
}