//Q51. Demonstrate the difference between abstract class and interface.

using System;

namespace Assignment_2
{
    internal class Q51_AbstractClassAndInterface
    {
        abstract class Student
        {
            protected string Name { get; set; }
            protected int Age { get; set; }
            protected string Email { get; set; }

            public abstract void GetData();
        }

        interface Data
        {
            void DisplayData();
        }
        
        class Display : Student, Data
        {
            public override void GetData()
            {
                Console.WriteLine("\nEnter the student details : ");
                Console.Write("\nEnter the name : ");
                Name = Console.ReadLine();
                Console.Write("Enter the age : ");
                Age = int.Parse(Console.ReadLine());
                Console.Write("Enter the email : ");
                Email = Console.ReadLine();
            }

            public void DisplayData()
            {
                Console.WriteLine("\nStudent Details : \n");
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Age : " + Age);
                Console.WriteLine("Email : " + Email);
            }
        }

        public static void AbstractClassAndInterface()
        {
        AbsInter:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ51. Demonstrate the difference between abstract class and interface.");
            Display display = new Display();
            display.GetData();
            Console.ForegroundColor = ConsoleColor.Yellow;
            display.DisplayData();
            
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
                    goto AbsInter;
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
