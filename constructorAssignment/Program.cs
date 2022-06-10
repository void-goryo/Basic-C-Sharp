using System;

namespace constructorAssignment
{
    class Program
    {
        public Program(string name) : this(name, 100) { }       //default
        public Program(string name, int value = 0) : base()      //constructer that would run after the "default values"
        {
            //pretend this is code. I did this it 1:30am and don't really know what to put in here rn for this assignment lol
        }


        static void Main(string[] args)
        {
            const string hi = "hello?";     //will never change

            var num = 10;                   //a number that implicitly knows that it's an int

        }
    }
}
