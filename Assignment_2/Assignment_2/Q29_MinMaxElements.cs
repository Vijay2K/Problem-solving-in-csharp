//Q29. Write a program in C# to find maximum and minimum element in an array.

using System;

namespace Assignment_2
{
    internal class Q29_MinMaxElements
    {
        public static void MinMaxElements()
        {
            MinMax:
            int n;
            
            int min = int.MaxValue;
            int max = int.MinValue;

            Console.WriteLine("\nQ29. Write a program in C# to find maximum and minimum element in an array.");
            Console.Write("\nEnter the size : ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements");
            for(int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }

                if(arr[i] < min)
                {
                    min = arr[i];
                }
                
            }

            Console.WriteLine("Max element in an array : {0}", max);
            Console.WriteLine("Min element in an array : {0}", min);

            choices:
            char ch;
            Console.Write("\nDo you want to rety (y / n) : ");
            ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'y':
                case 'Y':
                    Console.Clear();
                    goto MinMax;
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
