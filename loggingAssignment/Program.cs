using System;
using System.IO;

namespace loggingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\Gabe\Desktop\Basic-C-Sharp\loggingAssignment\logs\log.txt", true))
            {
                file.WriteLine(num);
            }

        }
    }
}
