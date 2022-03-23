//Q58. Write a program to add Max_num() to Int32 existing structure through extension method.

using System;

namespace Assignment_2
{
    internal class Q58_ExtendInt32
    {
        public static void ExtendInt32()
        {
            ans:
            Console.WriteLine("Q58. Write a program to add Max_num() to Int32 existing structure through extension method.");
            int a, b;
            int result = 0;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nEnter the values for finding the max value");
            Console.Write("\nEnter the value A : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the value B : ");
            b = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nMax number is : " + result.Max_Num(a, b));

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
