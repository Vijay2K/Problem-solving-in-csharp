//Q23. Write a C# program to convert decimal number to binary.

using System;

namespace Assignment_2
{
    internal class Q23_DecimalToBinary
    {
        public static void DecimalToBinary()
        {
        binary:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ23. Write a C# program to convert decimal number to binary.");
            int n;
            Console.Write("\nEnter the value : ");
            n = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(n, 8);
            Console.Write("\nBinary of value {0} : ", n);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(binary);

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
                    goto binary;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionsPartOne();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }
    }
}
