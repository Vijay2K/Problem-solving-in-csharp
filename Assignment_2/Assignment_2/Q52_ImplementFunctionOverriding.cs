//Q52. Write a program which will demonstrate the function overriding.

using System;

namespace Assignment_2
{
    internal class Q52_ImplementFunctionOverriding
    {
        class GetDetails
        {
            protected string Name { get; set; }
            protected int Age { get; set; }
            protected string Department { get; set; }
            protected float SemesterPercent { get; set; }
            protected int Salary { get; set; }
            
            public virtual void GetData()
            {
                Console.WriteLine("Base get data");
            }

            public virtual void DisplayData()
            {
                Console.WriteLine("Base display");
            }
        }

        class Student : GetDetails
        {
            public override void GetData()
            {
                Console.WriteLine("\nEnter the Student Details\n");
                Console.Write("Enter the student Name : ");
                Name = Console.ReadLine();
                Console.Write("Enter the student Age : ");
                Age = int.Parse(Console.ReadLine());
                Console.Write("Enter the Student's department : ");
                Department = Console.ReadLine();
                Console.Write("Enter the student semester percentage : ");
                SemesterPercent = float.Parse(Console.ReadLine());
            }

            public override void DisplayData()
            {
                Console.WriteLine("\nStudent Details\n");
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Age : " + Age);
                Console.WriteLine("Department : " + Department);
                Console.WriteLine("Percentage : {0}%", SemesterPercent);
            }
        }

        class Employee : GetDetails
        {
            public override void GetData()
            {
                Console.WriteLine("\nEnter the Employee Details\n");
                Console.Write("Enter the Employee Name : ");
                Name = Console.ReadLine();
                Console.Write("Enter the Employee Age : ");
                Age = int.Parse(Console.ReadLine());
                Console.Write("Enter the Employee's department : ");
                Department = Console.ReadLine();
                Console.Write("Enter the Employee's Salary : ");
                Salary = int.Parse(Console.ReadLine());
            }

            public override void DisplayData()
            {
                Console.WriteLine("\nEmployee Details\n");
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Age : " + Age);
                Console.WriteLine("Department : " + Department);
                Console.WriteLine("Salary : {0}", Salary);
            }
        }

        public static void InplementFunctionOverloading()
        {
            data:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ52. Write a program which will demonstrate the function overriding.");
            
            Student student = new Student();
            Employee employee = new Employee();
            
            student.GetData();
            employee.GetData();

            Console.ForegroundColor = ConsoleColor.Yellow;
            student.DisplayData();
            employee.DisplayData();

            choices:
            char ch;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nDo you want to rety (y / n) : ");
            ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'y':
                case 'Y':
                    Console.Clear();
                    goto data;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionPartFour();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }
    }
}
