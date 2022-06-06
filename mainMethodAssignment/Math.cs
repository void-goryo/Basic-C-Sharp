using System;
using System.Collections.Generic;
using System.Text;

namespace mainMethodAssignment
{
    class Math
    {
        public int Integer(int user)
        {
            int answer = user + 5;
            return answer;
        }
        public double Decimal(double user)
        {
            double answer = user + 5.7;
            return (int)answer;
        }

        public int Stringing(string user)
        {
            int answer = Convert.ToInt32(user) + 15;
            return answer;
        }

    }
}
