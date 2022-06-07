using System;
using System.Collections.Generic;
using System.Text;

namespace overloadAssignment
{
    public class Employee
    {
        public int Id { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }

    }
}
