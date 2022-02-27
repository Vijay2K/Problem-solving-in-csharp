//Q28. Write a program in C# to find the sum and average of all elements of the array.

using System;

namespace Assignment_2
{
    internal class Q28_ArraySumAverage
    {
        public static void ArraySumAverage()
        {
            Sum:
            int n, sum = 0, average;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ28. Write a program in C# to find the sum and average of all elements of the array.");
            Console.Write("\nEnter the size : ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements in an array");
            for(int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] : ", i);
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            average = sum / n;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSum of all elements in an array : {0}", sum);
            Console.WriteLine("Average of all elements in an array : {0}", average);

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
                    goto Sum;
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
