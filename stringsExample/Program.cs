using System;
using System.Text;

namespace stringsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Gabe";
            string quote = "The man said \"Hello\", Gabe. \n Hello on a new line. \n\t Hello on a tab";
            string file = @"C:\users\Gabe";

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("s");
            int length = name.Length;

            name = name.ToUpper();
            name = name.ToLower();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Gabe!");


            Console.WriteLine(sb);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(quote);
            Console.WriteLine(file);
            Console.ReadLine();
        }
    }
}
