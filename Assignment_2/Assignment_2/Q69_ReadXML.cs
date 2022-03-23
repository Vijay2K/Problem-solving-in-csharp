//Q69. Write a program to read XML file which is already created.

using System;
using System.Collections.Generic;
using System.Xml;

namespace Assignment_2
{
    internal class Q69_ReadXML
    {
        public static void ReadXML()
        {
            ans:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ69. Write a program to read XML file which is already created.");
            string path = "D:\\Personal Projects\\CSharp Projects\\Assignments\\XML Files\\employee.xml";
            XmlTextReader xmlReader = new XmlTextReader(path);

            List<string> ids = new List<string>();
            List<string> names = new List<string>();
            List<string> salaries = new List<string>();

            while(xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Id")
                {
                    string s1 = xmlReader.ReadElementString();
                    ids.Add(s1);
                }
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "name")
                {
                    string s1 = xmlReader.ReadElementString();
                    names.Add(s1);
                }
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Salary")
                {
                    string s1 = xmlReader.ReadElementString();
                    salaries.Add(s1);
                }
            }

            xmlReader.Close();
            Console.WriteLine("\n");
            Console.Write("\t\tID  \tName  \tSalary\n\n");
            for(int i = 0; i < names.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t\t{0} \t{1} \t{2}", ids[i], names[i], salaries[i]);
                Console.Write("\n");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tSuccessfully read the xml file");
            
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
