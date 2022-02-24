//Q22. Find the greater between given 3 numbers using ternary operator.

using System;

namespace Assignment_2
{
    internal class Q22_GreaterNumberTernary
    {
        public static void GreaterNumber()
        {
        Greater:
            int a, b, c, result;
            Console.WriteLine("\nQ22. Find the greater between given 3 numbers using ternary operator.");
            Console.Write("\nEnter the num1 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the num2 : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter the num3 : ");
            c = int.Parse(Console.ReadLine());

            result = (a > b && a > c) ? a : (b > a && b > c) ? b : c;
            Console.WriteLine("Greater number amoung {0}, {1} and {2} : {3}", a, b, c, result);

            Choices:
            char ch;
            Console.Write("Do you want to retry (y / n): ");
            ch = char.Parse(Console.ReadLine());

            switch(ch)
            {
                case 'y':
                case 'Y':
                    Console.Clear();
                    goto Greater;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionsPartOne();
                    break;
                default:
                    Console.WriteLine("Invalid input...");
                    goto Choices;
            }
        }
    }
}
