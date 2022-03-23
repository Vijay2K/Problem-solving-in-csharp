//Q68. Write a program through which you will create a XML file to store Employee Data.

using System;
using System.Xml;

namespace Assignment_2
{
    internal class Q68_EmployeeData
    {
        public static void EmployeeData()
        {
            ans:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ68. Write a program through which you will create a XML file to store Employee Data.");
            string fileName;
            int m, n;
            Console.Write("\nEnter the file name : ");
            fileName = Console.ReadLine();

            string path = $"D:\\Personal Projects\\CSharp Projects\\Assignments\\XML Files\\{fileName}.xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(path, System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("Employees");
            xmlWriter.WriteStartElement("Management");

            Console.WriteLine("\nEnter the Employee's Detail");
            Console.Write("\nEnter the no. of employees in management team : ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEmployee Details of a management team");

            for(int i = 1; i <= m; i++)
            {
                xmlWriter.WriteStartElement("Employee_" + i);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nEmployee " + i);
                Console.Write("\nEnter the employee's name : ");
                string name = Console.ReadLine();
                xmlWriter.WriteElementString("name", name);

                Console.Write("Enter the emplyee's ID : ");
                string id = Console.ReadLine();
                xmlWriter.WriteElementString("Id", id);

                Console.Write("Enter the employee's salary : ");
                string salary = Console.ReadLine();
                xmlWriter.WriteElementString("Salary", salary);

                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();

            Console.ForegroundColor = ConsoleColor.White;
            xmlWriter.WriteStartElement("Developer");

            Console.Write("\nEnter the no. of employees in developer team : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEmployee Details of a developer team");

            for(int i = 1; i <= n; i++)
            {
                xmlWriter.WriteStartElement("Employee_" + i);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nEmployee " + i);
                Console.Write("\nEnter the employee's name : ");
                string name = Console.ReadLine();
                xmlWriter.WriteElementString("name", name);

                Console.Write("Enter the emplyee's ID : ");
                string id = Console.ReadLine();
                xmlWriter.WriteElementString("Id", id);

                Console.Write("Enter the employee's salary : ");
                string salary = Console.ReadLine();
                xmlWriter.WriteElementString("Salary", salary);

                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nXML file created successfully");
            xmlWriter.Close();

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
                    goto ans;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionPartFive();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }
    }
}
