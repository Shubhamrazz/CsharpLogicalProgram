using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProgramming
{
    public class Employee_Inheritance
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);

        }
    }
        public class FullTimeEmployee : Employee_Inheritance
        {
            public float YearlySalary;//field
        }
        public class PartTimeEmployee : Employee_Inheritance
        {
            public float HourlyRate;//field
        }

    
}
