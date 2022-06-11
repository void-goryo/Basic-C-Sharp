using System;
using System.Collections.Generic;
using System.Text;

namespace constructorAssignment
{
    class Constructor
    {
        public string name;
        public int value;


        public Constructor(string name, int value)
        {
            this.name = name;
            this.value = value;
        }

        public Constructor(int value) : this("Gabe", value)
        {

        }

        public Constructor(string name) : this(name, 0)
        {

        }

        public Constructor() : this("", 0) { }

    }
}
