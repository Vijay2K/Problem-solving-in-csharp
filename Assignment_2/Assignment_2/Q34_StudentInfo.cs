//Q34. Write a C# program to store the information of one student using structure.

using System;

namespace Assignment_2
{
    public struct Student
    {
        public string Name { get; }
        public byte Age { get; }
        public byte RollNo { get; }
        public string DOB { get; }

        public Student(string name, byte age, byte rollNo, string dob)
        {
            Name = name;
            Age = age;
            RollNo = rollNo;
            DOB = dob;
        }

    }

    internal class Q34_StudentInfo
    {
        public static void StudentDetails()
        {
            details:
            string name, dob;
            byte age, rollNo;

            Console.WriteLine("Q34. Write a C# program to store the information of one student using structure.");
            Console.WriteLine("\nEnter the student details");
            Console.Write("\nEnter the student name : ");
            name = Console.ReadLine();
            Console.Write("Enter the student rollNo : ");
            rollNo = byte.Parse(Console.ReadLine());
            Console.Write("Enter the student D.O.B (string) : ");
            dob = Console.ReadLine();
            Console.Write("Enter the student age : ");
            age = byte.Parse(Console.ReadLine());
            
            Student st = new Student(name, age, rollNo, dob);

            Console.WriteLine("\nStudent Details");
            Console.WriteLine("Name : " + st.Name);
            Console.WriteLine("Roll No : " + st.RollNo);
            Console.WriteLine("Age : " + st.Age);
            Console.WriteLine("Date of Birth (D.O.B) : " + st.DOB);

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
