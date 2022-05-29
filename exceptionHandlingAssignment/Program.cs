using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> divide = new List<int>() { 20, 30, 40, 50, 60 };

        try
        {
            //user input
            Console.WriteLine("Please input a number");
            int number = Convert.ToInt32(Console.ReadLine());

            //logic
            for (int i = 0; i < divide.Count; i++)
            {
                Console.WriteLine(number + " / " + divide[i] + " = " + divide[i] / number);
            }
        }
        //catches 0's
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        //catches strings
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        //runs no mater what
        finally
        {
            Console.ReadLine();
        }
    }
}