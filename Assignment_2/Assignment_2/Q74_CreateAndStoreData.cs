//Q74. Write a program to input file name from command line, create .txt file with the same name and store some data into it.

using System;
using System.IO;
using System.Text;

namespace Assignment_2
{
    internal class Q74_CreateAndStoreData
    {
        public static void CreateAndStore()
        {
            ans:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ74. Write a program to input file name from command line, create .txt file with the same name and store some data into it.");
            string fileName;
            Console.Write("Enter the file name : ");
            fileName = Console.ReadLine();
            string str;

            string path = $"D:\\Personal Projects\\CSharp Projects\\Assignments\\Text Files\\{fileName}.txt";


            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File successfully created...\n");

                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Enter some txt or data : ");
                str = Console.ReadLine();

                using (TextWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(str);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data successfully stored...\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File already exists\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter some txt or data : ");
                str = Console.ReadLine();

                using (TextWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(str);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Data successfully stored...\n");
                }
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
