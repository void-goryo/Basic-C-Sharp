using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismAssignment
{
    class Employee : Person, IQuittable
    {
        public void Quit()
        {
            throw new NotImplementedException();
        }
        public override void SayName()      
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName);
        }
    }
}
