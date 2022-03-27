//Q60. Write a program for ArrayList collection and demonstrate all the methods of ArrayList Class.

using System;
using System.Collections;

namespace Assignment_2
{
    internal class Q60_MethodsOfArrayList
    {
        public static void MethodsOfArrayList()
        {
            ans:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ60. Write a program for ArrayList collection and demonstrate all the methods of ArrayList Class.");
            
            ArrayList arr1 = new ArrayList();
            ArrayList arr2 = new ArrayList();
            string items;

            int n;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nArrayList.Add() : ");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter the number of elements to be added in the list 1 : ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the elemenets to add in an array list 1 ");

            for(int i = 0; i < n; i++)
            {
                Console.Write("arr1[{0}] : ", i);
                items = Console.ReadLine();
                arr1.Add(items);
            }

            Console.Write("\nElements in Array list 1 : " );
            Console.ForegroundColor = ConsoleColor.Green;
            for(int i = 0; i < arr1.Count; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter the number of elements to be added in the list 2 : ");
            n = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nEnter the elemenets to add in an array list 2 ");

            for(int i = 0; i < n; i++)
            {
                Console.Write("arr1[{0}] : ", i);
                items = Console.ReadLine();
                arr2.Add(items);
            }

            Console.Write("\nElements in Array list 2 : ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < arr2.Count; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nArrayList.AddRanage() : ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nAdding the Arraylist 2 in Arraylist 1\n");
            arr1.AddRange(arr2);

            Console.Write("Elements in Arraylist 1 after adding Arraylist 2 : ");
            Console.ForegroundColor = ConsoleColor.Green;
            for(int i = 0; i < arr1.Count; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nArrayList.Remove() : ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nRemove the elements from the array list");
            Console.WriteLine("Array List length : {0}", arr1.Count);
                
            retry:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter the index to remove : ");
            n = int.Parse(Console.ReadLine());

            if(n < arr1.Count)
            {
                arr1.RemoveAt(n);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Index out of range, Pls try again");
                goto retry;
            }

            Console.Write("Elements in Arraylist 1 after removing the element : ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < arr1.Count; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            
            //----

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nArrayList.Insert() : ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nRemove the elements from the array list");
            Console.WriteLine("Array List length : {0}", arr1.Count);

            redo:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter the index to insert the element : ");
            n = int.Parse(Console.ReadLine());
            
            object element;
            Console.Write("Enter the element to insert : ");
            element = Console.ReadLine();

            if(n < arr1.Count)
            {
                arr1.Insert(n, element);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Index out of bound, Pls try again");
                goto redo;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Elements in Arraylist 1 after inserting an element : ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < arr1.Count; i++)
            {
                Console.Write("{0}  ", arr1[i]);
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
