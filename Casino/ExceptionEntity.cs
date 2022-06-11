using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class ExceptionEntity       //entity is an object that maps to a database
    {
        public int Id { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
