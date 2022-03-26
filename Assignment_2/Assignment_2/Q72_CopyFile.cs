//Q72. Write a program to copy one file to another.

using System;
using System.IO;

namespace Assignment_2
{
    internal class Q72_CopyFile
    {
        public static void CopyFile()
        {
            ans:
            Console.WriteLine("\nQ72. Write a program to copy one file to another.");
            string sourcePath = "D:\\Personal Projects\\CSharp Projects\\Assignments\\Text Files\\person_details.txt";
            //"D:\\Personal Projects\\CSharp Projects\\Assignments\\Text Files\\copy_details.txt"
            string destinationPath;

            Console.Write("Enter the destination path : ");
            destinationPath = Console.ReadLine();

            if(File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destinationPath, true);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nSuccessfully copy the destination path : {destinationPath}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Source file is missing can't copy");
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
