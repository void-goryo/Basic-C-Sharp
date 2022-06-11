using System;

namespace constructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string hi = "hello?";     //will never change

            var num = 10;                   //a number that implicitly knows that it's an int

            Constructor constructor = new Constructor(num);
            Console.WriteLine("name:" + constructor.name + " value:" + constructor.value);      //passes the number to the constuctor only looking for a number

            Constructor constructor2 = new Constructor();
            Console.WriteLine("name:" + constructor2.name + " value:" + constructor2.value);    //passes nothing

            Constructor constructor3 = new Constructor(hi);
            Console.WriteLine("name:" + constructor3.name + " value:" + constructor3.value);    //passes string to the constructor only looking for a string
        }
    }
}
