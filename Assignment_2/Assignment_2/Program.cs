﻿using System;
using System.Threading;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Choices();
        }

        private static void Choices()
        {
            byte choice;

        CHOICE:
            Console.WriteLine("1. Question from 21 to 30");
            Console.WriteLine("2. Question from 31 to 40");
            Console.WriteLine("\nPress 0 to exit\n");

            Console.Write("Enter the Choice : ");
            choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Clear();
                    QuestionsPartOne();
                    break;
                case 2:
                    Console.WriteLine("Your choice is two...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice...");
                    Thread.Sleep(500);
                    Console.Clear();
                    goto CHOICE;
            }
        }

        public static void QuestionsPartOne()
        {
            byte choice;

            Questions:
            Console.WriteLine("1. Write a c# program to convert given number in word form. (147 : one hundred forty seven)");
            Console.WriteLine("2. Find the greater between given 3 numbers using ternary operator.");
            Console.WriteLine("3. Write a C# program to convert decimal number to binary.");
            Console.WriteLine("4. Write a C# program to check whether given number is perfect or not.(6, 28, 496, 8128 )");
            Console.WriteLine("5. Write a C# program to print all perfect numbers within given range.");
            Console.WriteLine("6. Write down a menu driven program using switch to convert various distance from one unit to other.");
            Console.WriteLine("7. Write a program in C# to read n number of values in an array and display it in reverse order.");
            Console.WriteLine("8. Write a program in C# to find the sum and average of all elements of the array.");
            Console.WriteLine("9. Write a program in C# to find maximum and minimum element in an array.");
            Console.WriteLine("10. Write a program in C# to sort the given array in descending order.");
            Console.WriteLine("\nPress 0 to Go Back");

            Console.Write("\nEnter your choice : ");
            choice = byte.Parse(Console.ReadLine());

            switch(choice)
            {
                case 0:
                    Console.Clear();
                    Choices();
                    break;
                case 1:
                    Console.WriteLine("Entering inputs");
                    break;
                case 2:
                    Console.Clear();
                    Q22_GreaterNumberTernary.GreaterNumber();
                    break;
                case 3:
                    Console.WriteLine("Entering inputs");
                    break;
                case 4:
                    Console.WriteLine("Entering inputs");
                    break;
                case 5:
                    Console.WriteLine("Entering inputs");
                    break;
                case 6:
                    Console.WriteLine("Entering inputs");
                    break;
                case 7:
                    Console.Clear();
                    Q27_ReverseArray.ReverseArray();
                    break;
                case 8:
                    Console.Clear();
                    Q28_ArraySumAverage.ArraySumAverage();
                    break;
                case 9:
                    Console.Clear();
                    Q29_MinMaxElements.MinMaxElements();
                    break;
                case 10:
                    Console.Clear();
                    Q30_DecendingSort.SortingInDecending();
                    break;
                default:
                    Console.WriteLine("Invalid Input...");
                    Thread.Sleep(500);
                    Console.Clear();
                    goto Questions;
            }
        }
    }
}
