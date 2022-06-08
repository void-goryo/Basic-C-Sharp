using System;
using System.Collections.Generic;
using System.Linq;

namespace lambdaAssignment
{
    class Program
    {


        static void Main(string[] args)
        {
            List<Employee> people = new List<Employee>();

            people.Add(new Employee { firstName = "Joe", lastName = "Bags", employeeID = 1 });
            people.Add(new Employee { firstName = "Joe", lastName = "Hunts", employeeID = 2 });
            people.Add(new Employee { firstName = "Sally", lastName = "Yourse", employeeID = 3 });
            people.Add(new Employee { firstName = "Hayden", lastName = "Snider", employeeID = 4 });
            people.Add(new Employee { firstName = "Gabe", lastName = "Jones", employeeID = 5 });
            people.Add(new Employee { firstName = "Emily", lastName = "Met", employeeID = 6 });
            people.Add(new Employee { firstName = "Tyler", lastName = "Jones", employeeID = 7 });
            people.Add(new Employee { firstName = "Kaylee", lastName = "Met", employeeID = 8 });
            people.Add(new Employee { firstName = "Celia", lastName = "Dochylo", employeeID = 9 });
            people.Add(new Employee { firstName = "Bob", lastName = "Smith", employeeID = 10 });

            List<Employee> joe = new List<Employee>();

            foreach (Employee i in people)
            {
                if (i.firstName == "Joe")
                {
                    joe.Add(i);
                }
            }

            foreach (Employee i in joe)
            {
                Console.WriteLine(i.firstName + " " + i.lastName + " " + i.employeeID);
            }


            List<Employee> joe2 = people.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee i in joe2)
            {
                Console.WriteLine(i.firstName + " " + i.lastName + " " + i.employeeID);
            }

            List<Employee> id = people.Where(x => x.employeeID > 5).ToList();

            foreach (Employee i in id)
            {
                Console.WriteLine(i.firstName + " " + i.lastName + " " + i.employeeID);
            }

        }
    }
}
