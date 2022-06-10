using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    //in this case, we are making our own exception so we can narrow down what went wrong and why the exception was thrown.
    public class FraudException : Exception
    {
        public FraudException() : base() { }        //inherits from the base exception (Exception)
        public FraudException(string message) : base(message) { }

    }
}
