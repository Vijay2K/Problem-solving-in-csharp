//Q61. Write a program to implement all non-generic collections.(stack,queue,arraylist,hash_table)

using System;
using System.Collections;

namespace Assignment_2
{
    internal class Q61_NonGenericCollection
    {
        public static void NonGenericCollection()
        {
            ans:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ61. Write a program to implement all non-generic collections.(stack,queue,arraylist,hash_table)");
            
            char choice;
            Console.WriteLine("1. Stack");
            Console.WriteLine("2. Queue");
            Console.WriteLine("3. ArrayList");
            Console.WriteLine("4. HashTables");
            Console.Write("\nEnter the choice : ");

            choice = char.Parse(Console.ReadLine());
            switch(choice)
            {
                case '1':
                    UsingStack();
                    break;
                case '2':
                    UsingQueue();
                    break;
                case '3':
                    UsingArrayList();
                    break;
                case '4':
                    UsingHashTable();
                    break;
                default:
                    Console.WriteLine("\nInvalid choice...");
                    Console.WriteLine("\nPress any key and try again...");
                    Console.ReadLine();
                    Console.Clear();
                    goto ans;
            }
        }

        private static void UsingStack()
        {
            Stack myStatck = new Stack();
            object element;

            char choice;
            Console.WriteLine("1. push");
            Console.WriteLine("2. pop");

            Console.WriteLine("\nPress 0 to cancel");

            redo:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\nEnter your choice (push / pop): ");
            choice = char.Parse(Console.ReadLine());
            
            switch(choice)
            {
                case '1':
                    Console.Write("Enter the element to push : ");
                    element = Console.ReadLine();
                    myStatck.Push(element);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nElements in a stack : ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    foreach (object stack in myStatck)
                    {
                        Console.Write("{0}  ", stack);
                    }
                    goto redo;
                case '2':
                    if(myStatck.Count != 0)
                    {
                        myStatck.Pop();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nElements in a stack : ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (object stack in myStatck)
                        {
                            Console.Write("{0}  ", stack);
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nNo elements in a stack");
                    }
                    goto redo;
                case '0':
                    break;
                default:
                    Console.WriteLine("\nInvalid choice...");
                    Console.WriteLine("\nPress any key and try again...");
                    Console.ReadLine();
                    goto redo;
            }
        }

        private static void UsingQueue()
        {

        }

        private static void UsingArrayList()
        {

        }

        private static void UsingHashTable()
        {

        }
    }
}
