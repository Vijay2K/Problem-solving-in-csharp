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
                    Console.Clear();
                    Q77_UpdateStudentData.UpdateStudentData();
                    break;
                case '3':
                    Console.Clear();
                    Q78_ShowSpecificData.ShowSpecificData();
                    break;
                case '4':
                    Console.Clear();
                    Q79_CreateEmployeeTable.CreateEmployeeTable();
                    break;
                case '5':
                    Console.Clear();
                    Q82_ReadAndStore.ReadAndStore();
                    break;
                case '6':
                    Console.Clear();
                    Q80_MenuDriven.MenuDriven();
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
