//Q36. Demonstrate the use of all access specifiers with suitable example.

using System;

namespace Assignment_2
{
    class Person
    {
        private string creditCardInfo;
        private string password;

        protected string name;
        protected int age;
        
        protected internal string email;
        protected internal string phNo;

        public void GetPrivateData()
        {
            Console.WriteLine("\nEnter private details");
            Console.Write("\nEnter the credit card no : ");
            creditCardInfo = Console.ReadLine();
            Console.Write("Enter the password : ");
            password = Console.ReadLine();
        }

        public void DisplayPrivateInfo()
        {
            Console.WriteLine("Credit Card No : {0}", creditCardInfo);
            Console.WriteLine("Password : {0}", password);
        }
    }

    class Info : Person
    {
        public void GetPersonInfo()
        {
            Console.WriteLine("Enter personal data");
            Console.Write("\nEnter the name : ");
            name = Console.ReadLine();
            Console.Write("Enter the age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter the email : ");
            email = Console.ReadLine();
            Console.Write("Enter the mobile no : ");
            phNo = Console.ReadLine();
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Email : " + email);
            Console.WriteLine("Mobile No : " + phNo);
        }
    }

    internal class Q36_AccessSpecifiers
    {
        public static void AccessSpecifiers()
        {
            data:
            Console.WriteLine("\nQ36. Demonstrate the use of all access specifiers with suitable example.");

            Info info = new Info();
            info.GetPersonInfo();
            Console.Write("\n");
            info.GetPrivateData();
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Person's data\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            info.DisplayPersonInfo();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPerson's private data\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            info.DisplayPrivateInfo();

            retry:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nDo you want to edit email or mobileNo (y / n) : ");
            char cha;
            cha = char.Parse(Console.ReadLine());

            if(cha == 'Y' || cha == 'y')
            {
                Console.WriteLine("\nDo you want to edit email / Mobile no / both ?");
                Console.WriteLine("1. Edit email");
                Console.WriteLine("2. Edit Mobile No");
                Console.WriteLine("3. Edit email and mobile no");


                char c;
                Console.Write("Enter the choice : ");
                c = char.Parse(Console.ReadLine());
                switch (c)
                {
                    case '1':
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nEnter the new email : ");
                        info.email = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nSuccessfully Updated...");
                        Console.WriteLine("Updated email : {0}", info.email);
                        break;
                    case '2':
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nEnter the new mobile no : ");
                        info.phNo = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nSuccessfully Updated...");
                        Console.WriteLine("Updated mobile No : {0}", info.phNo);
                        break;
                    case '3':
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nEnter the new email : ");
                        info.email = Console.ReadLine();
                        Console.Write("\nEnter the new mobile no : ");
                        info.phNo = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nSuccessfully Updated...");
                        Console.WriteLine("Updated email : {0}", info.email);
                        Console.WriteLine("Updated mobile No : {0}", info.phNo);
                        break;
                    default:
                        Console.WriteLine("\nInvalid input... pls try again");
                        goto retry;
                }
            } else if(cha == 'N' || cha == 'n')
            {
                goto choices;
            } else
            {
                goto retry;
            }

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
                    Program.QuestionPartTwo();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }
    }
}
