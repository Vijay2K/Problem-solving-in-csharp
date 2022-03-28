//Q67. Write a program which will have both single cast and multicast delegates.

using System;

namespace Assignment_2
{
    internal class Q67_SingleAndMulticastDelegate
    {
        private delegate void Printdetails(string name, int age, string email);
        private delegate void Calcualte(int a, int b);

        private static void Details(string name, int age, string email)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDetails");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Email : " + email);
        }

        private static void Add(int a, int b)
        {
            Console.WriteLine("\nAdd : {0}", a + b);
        }

        public static void Substract(int a, int b)
        {
            Console.WriteLine("Subtract : {0}", a - b);
        }

        public static void SingleAndMulticastDelegate()
        {
            ans:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ67. Write a program which will have both single cast and multicast delegates.");

            string name;
            int age;
            string email;

            Console.WriteLine("\nEnter the Details (Single Delegate)");
            Console.Write("Enter the Name : ");
            name = Console.ReadLine();
            Console.Write("Enter the age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter the email : ");
            email = Console.ReadLine();

            Printdetails details = new Printdetails(Details);
            details(name, age, email);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nEnter the Values (Multicast delegate) ");
            int a, b;
            Console.Write("Enter the value for A : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the Value for B : ");
            b = int.Parse(Console.ReadLine());

            Calcualte cal = new Calcualte(Add);
            cal += Substract;

            Console.ForegroundColor = ConsoleColor.Yellow;
            cal.Invoke(a, b);
    
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
