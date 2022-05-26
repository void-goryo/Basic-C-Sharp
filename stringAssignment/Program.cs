using System;
using System.Text;

namespace stringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string intro = "Hello, ";
            string name = "Gabriel!";
            string sentence = " Welcome to the program!";

            Console.WriteLine(intro + name + sentence);
            Console.ReadLine();

            name = name.ToUpper();

            Console.WriteLine("Your name is now uppercase: " + name);
            Console.ReadLine();

            StringBuilder paragraph = new StringBuilder();

            paragraph.Append("This is the first sentence");
            paragraph.Append("\nThis is the second sentence");
            paragraph.Append("\nThis is the last sentence");

            Console.WriteLine("This is the StringBuilder in action!\n" + paragraph);
            Console.ReadLine();
        }
    }
}
