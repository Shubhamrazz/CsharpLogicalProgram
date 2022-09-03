using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProgramming
{
    public class ParamterizedConstructor
    {
        public string name;
        public int id;
        public int salary;

        public ParamterizedConstructor(string name, int id, int salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
       
    }
}
