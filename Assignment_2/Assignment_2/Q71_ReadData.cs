//Q71. Write a program to read the text from .txt file, using file handling.

using System;
using System.IO;

namespace Assignment_2
{
    internal class Q71_ReadData
    {
        public static void ReadData()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ71. Write a program to read the text from .txt file, using file handling.");

            ans:
            string file;
            Console.Write("\nEnter the file name : ");
            file = Console.ReadLine();

            string path = $"D:\\Personal Projects\\CSharp Projects\\Assignments\\Text Files\\{file}.txt";
            string data;

            if(File.Exists(path))
            {
                data = File.ReadAllText(path);
                Console.WriteLine("\nData inside the text file...");
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine($"File {file} doesn't exists");
                Console.WriteLine("Pls try again....");
                goto ans;
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
