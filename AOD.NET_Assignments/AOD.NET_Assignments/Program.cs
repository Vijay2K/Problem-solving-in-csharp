using System;
using System.Threading;

namespace ADO.NET_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            choice:
            char choice;
            Console.Write("Enter the choice : ");
            choice = char.Parse(Console.ReadLine());
            
            switch(choice)
            {
                case '1':
                    Console.Clear();
                    Q76_InsertStudentData.InsertStudentData();
                    break;
                case '2':
                    break;
                case '3':
                    break;
                default:
                    Console.WriteLine("Invalid Input...");
                    Console.WriteLine("Pls try again...");
                    Thread.Sleep(500);
                    Console.Clear();
                    goto choice;
            }
        
        }
    }
}
