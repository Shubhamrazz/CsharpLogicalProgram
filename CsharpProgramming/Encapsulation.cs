using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProgramming
{
    public class Encapsulation
    {
        //private variables declared and can be accessed by the public method of class.
        private string studentName;
        private int studentAge;

        //Using Accessors to get and set value of variable
        public string Name
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName=value;
            }
        }
        public int Age
        {
            get
            {
                return studentAge;
            }
            set
            {
                studentAge = value;
            }
        }
    }
}
