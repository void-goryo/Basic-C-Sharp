using System;
using System.Collections.Generic;
using System.Text;

namespace classAssignment
{
    //This is how you would make it so you cannot instantiate the class
    static class Math
    {
        public static void Process(int user)
        {
            int answer = user * 8;
            Console.WriteLine(answer);
        }

        public static void Process(int user, int number)
        {
            int answer = user / number;
            Console.WriteLine(answer);
        }
    }
}
