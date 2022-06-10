using System;
using System.Collections.Generic;
using System.Text;

namespace trycatchAssignment
{
    public class Age
    {
        public int wasBorn(int age)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            int year = date.Year;

            return year - age;

        }
    }
}
