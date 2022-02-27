//Q27. Write a program in C# to read n number of values in an array and display it in reverse order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Q27_ReverseArray
    {
        public static void ReverseArray()
        {
            Reverse:
            int n;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ27. Write a program in C# to read n number of values in an array and display it in reverse order.");
            Console.Write("\nEnter the size : ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Stack<int> st = new Stack<int>();
            
            Console.WriteLine("Enter the elements in an array : ");
            for(int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] : ", i);
                arr[i] = int.Parse(Console.ReadLine());
                st.Push(arr[i]);
            }

            Console.Write("Array in reverse : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < n; i++)
            {
                int val = st.Pop();
                Console.Write("{0}  ", val);
            }

            choices:
            char ch;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nDo you want to rety (y / n) : ");
            ch = char.Parse(Console.ReadLine());
            
            switch(ch)
            {
                case 'y':
                case 'Y':
                    Console.Clear();
                    goto Reverse;
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
