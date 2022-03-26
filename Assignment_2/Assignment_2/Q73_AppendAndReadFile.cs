//Q73. Write some text to the file in append mode and read the data from the same file.

using System;
using System.IO;

namespace Assignment_2
{
    internal class Q73_AppendAndReadFile
    {
        public static void AppendAndReadFile()
        {
            ans:
            Console.WriteLine("\nQ73. Write some text to the file in append mode and read the data from the same file.");
            string sourceDestination = "D:\\Personal Projects\\CSharp Projects\\Assignments\\Text Files\\person_details.txt";

            string appendStr;
            string data;
            Console.Write("Enter the string to append : ");
            appendStr = Console.ReadLine();

            if(File.Exists(sourceDestination))
            {
                File.AppendAllText(sourceDestination, "\n" + appendStr);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSuccessfully appended the text");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nSource File doesn't exists");
            }

            data = File.ReadAllText(sourceDestination);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nData inside the file\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(data);
            
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
