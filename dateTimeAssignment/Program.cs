using System;

namespace dateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);    //gets current time

            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(num + " hours from now will be: " + DateTime.Now.AddHours(num));      //adds hours to current time based on user number
        }
    }
}
