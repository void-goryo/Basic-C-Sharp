using System;
using System.Collections.Generic;
using System.Text;

namespace trycatchAssignment
{
    public class Age
    {
        public int wasBorn(int age)
        {
            DateTime date = new DateTime();     //starts a new GetTime
            date = DateTime.Now;                //gets current time
            int year = date.Year;               //grabs year from current time and stores it in a new int

            if(age <= 0)        //exception if user puts in anything under 0
            {
                throw new Exception();
            }

            return year - age;  //does math and returns the answer

        }
    }
}
