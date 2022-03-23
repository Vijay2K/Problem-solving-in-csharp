//Q59. Write a program to add one extended method to ArrayList class.

using System;
using System.Collections;

namespace Assignment_2
{
    internal class Q59_ExtendArrayList
    {
        public static void ExtendArrayList()
        {
            ans:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Q59. Write a program to add one extended method to ArrayList class.");
            int n;
            Console.Write("\nEnter the size of an array : ");
            n = int.Parse(Console.ReadLine());
            
            ArrayList list = new ArrayList();
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter the element[{0}] : ", i);
                string data = Console.ReadLine();
                list.Add(data);
            }

            list.Shuffle();
            Console.WriteLine("\nAfter shuffling the array list");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for(int i = 0; i < n; i++)
            {
                Console.Write(list[i] + "  ");
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
