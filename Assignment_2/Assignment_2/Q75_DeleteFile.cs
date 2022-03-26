//Q75. Write a program to delete the file.

using System;
using System.IO;

namespace Assignment_2
{
    internal class Q75_DeleteFile
    {
        public static void DeleteFile()
        {
            ans:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ75. Write a program to delete the file.");
            string fileName;

            Console.Write("Enter the file name : ");
            fileName = Console.ReadLine();

            string path = $"D:\\Personal Projects\\CSharp Projects\\Assignments\\Text Files\\{fileName}.txt";
            
            if(File.Exists(path))
            {
                File.Delete(path);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File successfully deleted...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("File don't exists....");
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
