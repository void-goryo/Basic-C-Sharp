using System;
using System.Collections.Generic;
using System.Text;

namespace abstractClassAssignment
{
    public class Employee : Person      //inherits values and methods
    {
        public override void SayName()      //overriding method. if there was code there, it would add all the code in one line using base.SayName()
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName);
        }
    }
}
