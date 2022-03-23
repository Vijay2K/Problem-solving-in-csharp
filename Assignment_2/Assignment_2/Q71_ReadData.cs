//Q71. Write a program to read the text from .txt file, using file handling.

using System;
using System.IO;

namespace Assignment_2
{
    internal class Q71_ReadData
    {
        public static void ReadData()
        {
            Console.WriteLine("\nQ71. Write a program to read the text from .txt file, using file handling.");
            string path = "D:\\Personal Projects\\CSharp Projects\\Assignments\\Text Files\\person.txt";
            StreamReader s_reader = new StreamReader(path);

            s_reader.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = s_reader.ReadLine();

            while(str != null)
            {
                Console.WriteLine(str);
                str = s_reader.ReadLine();
            }

            s_reader.Close();
        }
    }
}
