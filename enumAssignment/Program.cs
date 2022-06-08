using System;
using System.Collections.Generic;
using System.Globalization;

namespace enumAssignment
{
    class Program
    {
        public enum Week
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week: ");
            string day = Console.ReadLine().ToLower();

            while(true){
                try
                {
                    Week weekday = (Week)Enum.Parse(typeof(Week), day);     //comparison. weekday is the name of the comparison, and Week is what is being iterated through. then it compares to day
                    Console.WriteLine(weekday);
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                    day = Console.ReadLine().ToLower();
                }
            }
            
            

        }
    }
}
