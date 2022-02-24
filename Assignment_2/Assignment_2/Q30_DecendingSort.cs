//Q30. Write a program in C# to sort the given array in descending order.

using System;

namespace Assignment_2
{
    internal class Q30_DecendingSort
    {
        public static void SortingInDecending()
        {
            Sort:
            int n;
            Console.WriteLine("\nQ30. Write a program in C# to sort the given array in descending order.");
            Console.Write("\nEnter the size of an array : ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of an array");
            for(int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] : ", i);
                arr[i] = int.Parse(Console.ReadLine());                
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write("Sorting in decending order : ");
            for(int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

        choices:
            char ch;
            Console.Write("\nDo you want to rety (y / n) : ");
            ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'y':
                case 'Y':
                    Console.Clear();
                    goto Sort;
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
