using System;

namespace methodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee();     //calling Employee

            name.FirstName = "Sample";          //Employee inherites the variables from the Person class
            name.LastName = "Student";
            name.SayName();                     //superclass method calling from Employee, which is getting method from Person class
        }
    }
}
