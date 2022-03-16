//Q57. Write a program to implement the concept of extended method.

using System;

namespace Assignment_2
{
    static class ExtensionClass
    {
        public static void Swap(this int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("A : {0}", a);
            Console.WriteLine("B : {0}", b);
        }
    }

    internal class Q57_ExtensionMethod
    {
        public static void ImplementExtensionMethod()
        {
            swap:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ57. Write a program to implement the concept of extended method.");
            int a, b;

            Console.WriteLine("\nEnter the values for swapping\n");
            Console.Write("Enter the value of A : ");

            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of B : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBefore swapping : ");
            Console.WriteLine("A : {0}", a);
            Console.WriteLine("B : {0}", b);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nAfter swapping : ");
            a.Swap(b);

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
                    goto swap;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionPartFour();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }
    }
}
