//Q70. Write a program to store some text into a file, using file handling.

using System;
using System.Collections.Generic;
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
            
            string path = $"D:\\Personal Projects\\CSharp Projects\\Assignments\\Text Files\\person_details.txt";

            string name;
            int age;
            string email;
            string profession;

            Console.WriteLine("\nEnter the Person's details");
            Console.Write("Enter the name : ");
            name = Console.ReadLine();
            Console.Write("Enter the age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter the email : ");
            email = Console.ReadLine();
            Console.Write("Enter the profession : ");
            profession = Console.ReadLine();

            if(File.Exists(path))
            {
                File.WriteAllText(path, $"Person's details\n\nName : {name}\nAge : {age}\nEmail : {email}\nProfession : {profession}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Stored all the data in the file person_details.txt");
            } 
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("File haven't found....");
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
