using System;
using System.Collections.Generic;
using System.Linq;
using static CsharpProgramming.Employee_Inheritance;

namespace CsharpProgramming
{
    class Program
    {    
        //Linq
        //public static List<Employee> employees = new List<Employee>();
        //public static List<Project> projects = new List<Project>();
        static void Main(string[] args)
        {
            // Console.WriteLine("CsharpProgramming");
            //// BinaryOperator.Operators();
            //// Console.WriteLine("\n************************");
            // ConditionalOperator.Conditional();
            // Console.WriteLine("\n************************");

            // //Creating an object
            // Dog dog = new Dog("Roger","GermanShepeared","BlakishBrown",3);
            // Console.WriteLine(dog.Tostring());
            // Console.WriteLine("\n************************");

            /********************************/
            // //Creating Obj
            // ParamterizedConstructor cons = new ParamterizedConstructor("Shubh", 2, 45000);
            // Console.WriteLine("EmployeeName= " + cons.name + "EmployeeId= " + cons.id + "EmployeeSalary= " + cons.salary);
            // Console.WriteLine("\n************************");

            /**************************************/
            // Encapsulation obj = new Encapsulation();
            // obj.Name = "Aakansha";//call set accessor of the property Name and pass the value
            // obj.Age = 19;
            // Console.WriteLine("Name: " + obj.Name + "," + "Age: " + obj.Age);
            // Console.WriteLine("\n************************");

            /************************************/
            //Abstraction //Creating reference of Shape Class 
            // //Which refers to Sq class instance
            // Shape sh = new Square(4);
            // double result = sh.area();
            // //calling the method
            // double result1 = sh.area();
            // Console.Write("{0}", result1);
            // Console.WriteLine("\n************************");

            /***************************************/
            //Employee_Inheritance
            //FullTimeEmployee FTE = new FullTimeEmployee();
            //FTE.FirstName = "Shubham";
            //FTE.LastName = "Raj";
            //FTE.YearlySalary = 500000;
            //FTE.PrintFullName();
            //Console.WriteLine("FirstName:"+ FTE.FirstName+","+"LastName:"+ FTE.LastName+","+"Salary: " + FTE.YearlySalary);

            //PartTimeEmployee PTE = new PartTimeEmployee();
            //PTE.FirstName = "Adyasha";
            //PTE.LastName = "Priyadarshini";
            //PTE.HourlyRate = 400;
            //PTE.PrintFullName();
            //Console.WriteLine("FirstName:" + PTE.FirstName +","+"LastName:" + PTE.LastName + "," + "SalaryPerHour: " + PTE.HourlyRate);
            //Console.WriteLine("\n************************");

            /****************************************/
            //Array
            //int[] evennumber = new int[3];
            //evennumber[0] = 2;
            //evennumber[1] = 4;
            //evennumber[2] = 6;
            //Console.WriteLine(evennumber[2]);
            //Console.WriteLine("\n************************");

            /***************************************/
            //Console.WriteLine("-----Welcome to Regular Expression Demo------");
            ////RegularExpression patterns = new RegularExpression();
            ////if (patterns.validateString("11aaa1"))
            ////{
            ////    Console.WriteLine("Valid ");
            ////}
            ////else
            ////    Console.WriteLine("Invalid ");
            ////Console.ReadKey();

            //RegularExpression.ValidatePinCode();
            //RegularExpression.ValidateMobileNumber();
            //RegularExpression.ValidateSpecialCharPassword();

            /***********************************/
            //LINQ

            //IntializeEmployees();
            //InitializeProjects();
            /********************************/
            //WHERE
            //var querySyntax1 = from employee in employees
            //                   where employee.EmployeeName.StartsWith("R")
            //                   select employee.EmployeeName;

            //Console.WriteLine("Where in querySyntax------");
            //foreach (var item in querySyntax1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine('\n');

            //var methodSyntax1 = employees.Where(e => e.EmployeeName.StartsWith("R"));
            //Console.WriteLine("Where in methodSyntax----");
            //foreach (var item in methodSyntax1)
            //{
            //    Console.WriteLine(item.EmployeeName);
            //}
            /*********************************************/
            ////JOIN
            //var querySyntax = from employee in employees
            //                  join project in projects on employee.ProjectId equals project.ProjectId
            //                  select new { employee.EmployeeName, project.ProjectName };
            //Console.WriteLine("Join in querySyntax-----");
            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item.EmployeeName + "." + item.ProjectName);
            //}

            //Console.WriteLine('\n');

            //var methodSyntax = employees.Join(projects,
            //                                e => e.ProjectId,
            //                                p => p.ProjectId,
            //                                (e, p) => new { e.EmployeeName, p.ProjectName });
            //Console.WriteLine("Join in methodSyntax-----");
            //foreach (var item in methodSyntax)
            //{
            //    Console.WriteLine(item.EmployeeName + "." + item.ProjectName);
            //}

            //Console.WriteLine('\n');

            /*******************************/
            //LinkedList<String> list = new LinkedList<String>();
            //list.AddLast("Soumya");
            //list.AddLast("Rahul");
            //list.AddLast("Satyam");
            //list.AddLast("Zeeshan");
            //list.AddLast("Karma");
            //foreach (string str in list)
            //{
            //    Console.WriteLine(str);
            //}

            // if (list.Contains("Karma") == true)
            // {
            //     Console.WriteLine("Element Found...!!");
            // }
            // else
            // {
            //     Console.WriteLine("Element Not found...!!");
            // }
            /***************************************************/
            //Push
            Stack<int> myStack = new Stack<int>();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);
            foreach (var item in myStack)
            {
                Console.Write(item + ",");
            }
            //Peek
            Console.WriteLine('\n');
            Console.Write("Number of elements in Stack:{0}", myStack.Count);
            Console.WriteLine('\n');
            if (myStack.Count > 0)
                Console.WriteLine(myStack.Peek());
            Console.WriteLine('\n');
            //Contain
            Console.WriteLine(myStack.Contains(35));
            Console.WriteLine(myStack.Contains(40));
            //Pop           
            Console.WriteLine('\n');
            Console.Write("Number of elements in Stack:{0}", myStack.Count);
            Console.WriteLine('\n');
            while (myStack.Count > 0)
            {
                Console.Write(myStack.Pop() + ",");
            }
            Console.WriteLine('\n');
            Console.Write("Number of elements in Stack: {0}", myStack.Count);
            Console.WriteLine('\n');
            //Queue
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(12);
            callerIds.Enqueue(14);
            callerIds.Enqueue(16);
            callerIds.Enqueue(18);
            callerIds.Enqueue(20);
            foreach(var items in callerIds)
            {
                Console.Write(items+",");
            }
            //Peek
            Console.WriteLine('\n');
            Console.WriteLine("Total elements: {0}", callerIds.Count);
            if (callerIds.Count > 0)
            {
                Console.WriteLine(callerIds.Peek());
            }
            Console.WriteLine('\n');
            //Contain
            Console.WriteLine(callerIds.Contains(18));
            Console.WriteLine(callerIds.Contains(21));
            //Deque
            Console.WriteLine('\n');
            Console.WriteLine("Total elements: {0}", callerIds.Count);
            Console.WriteLine('\n');
            while (callerIds.Count > 0)
            {
              Console.Write(callerIds.Dequeue() +",");
            }
            Console.WriteLine('\n');
            Console.WriteLine("Total elements: {0}", callerIds.Count);
            Console.WriteLine('\n');
            /*******************************************/
            Console.WriteLine("Implementation of Generic Method");
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            Generic_Sample.toPrint<int>(intArray);
            Generic_Sample.toPrint<double>(doubleArray);
            Generic_Sample.toPrint<char>(charArray);
            Console.ReadKey();


        }

        //public static void IntializeEmployees()
        //{
        //    employees.Add(new Employee
        //    {
        //         EmployeeId=1,
        //         EmployeeName="Radhe",
        //         ProjectId=100
        //    });
        //    employees.Add(new Employee
        //    {
        //        EmployeeId = 2,
        //        EmployeeName = "Rohan",
        //        ProjectId = 101
        //    });
        //    employees.Add(new Employee
        //    {
        //        EmployeeId = 3,
        //        EmployeeName = "Goyal",
        //        ProjectId = 102
        //    });
        //}
        //public static void InitializeProjects()
        //{
        //    projects.Add(new Project
        //    {
        //        ProjectId = 100,
        //        ProjectName = "ABS"
        //    });
        //    projects.Add(new Project
        //    {
        //        ProjectId = 101,
        //        ProjectName = "QRT"
        //    });
        //    projects.Add(new Project
        //    {
        //        ProjectId = 102,
        //        ProjectName = "SUO"
        //    });
        //}
    }
}
