//Q35. Write a C# program to store the information of 5 employees using structure and array.

using System;

namespace Assignment_2
{
    internal class Q35_EmployeeInfo
    {
        struct Employee
        {
            public string Name { get;  set; }
            public string Email { get; set; }
            public int Age { get; set; }
            public string Department { get; set; }
            public int salary { get; set; }

            public void GetData()
            {
                Console.Write("Enter the employee's name : ");
                Name = Console.ReadLine();
                Console.Write("Enter the employee's Email : ");
                Email = Console.ReadLine();
                Console.Write("Enter the employee's age : ");
                Age = int.Parse(Console.ReadLine());
                Console.Write("Enter the employee's department : ");
                Department = Console.ReadLine();
                Console.Write("Enter the employee's salary : ");
                salary = int.Parse(Console.ReadLine());
            }

            public void DisplayData()
            {
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Email : " + Email);
                Console.WriteLine("Age : " + Age);
                Console.WriteLine("Department : " + Department);
                Console.WriteLine("Salary : " + salary);
            }
        }

        public static void EmployeeInfo()
        {
            details:
            Console.WriteLine("\nQ35. Write a C# program to store the information of 5 employees using structure and array.");
            int n;
            Console.Write("\nEnter the no. of employees : ");
            n = int.Parse(Console.ReadLine());
            Employee[] emp = new Employee[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter the details of employee {0}\n", i + 1);
                emp[i].GetData();
            }

            Console.WriteLine("\nEmployee details");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEmployee {0} details\n", i + 1);
                emp[i].DisplayData();
                Console.Write("\n");
            }

            choices:
            char ch;
            Console.Write("\nDo you want to rety (y / n) : ");
            ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'y':
                case 'Y':
                    Console.Clear();
                    goto details;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionPartTwo();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }

        }

    }
}
