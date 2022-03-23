//Q70. Write a program to store some text into a file, using file handling.

using System;
using System.IO;

namespace Assignment_2
{
    internal class Q70_StoreDataInFile
    {
        public static void StoreDataInFile()
        {
            ans:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ70. Write a program to store some text into a file, using file handling.");
            string fileName;
            Console.Write("\nEnter the file Name : ");
            fileName = Console.ReadLine();

            string path = $"D:\\Personal Projects\\CSharp Projects\\Assignments\\Text Files\\{fileName}.txt";
            StreamWriter s_write = new StreamWriter(path);

            string name;
            int age;
            string email;

            Console.WriteLine("Enter the person's details");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nEnter the Name : ");
            name = Console.ReadLine();
            s_write.WriteLine("Name : " + name);

            Console.Write("Enter the Age : ");
            age = int.Parse(Console.ReadLine());
            s_write.WriteLine("Age : " + age);

            Console.Write("Enter the email : ");
            email = Console.ReadLine();
            s_write.WriteLine("Email : " + email);

            s_write.Flush();
            s_write.Close();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Stored all the data in the file {fileName}.txt");

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
