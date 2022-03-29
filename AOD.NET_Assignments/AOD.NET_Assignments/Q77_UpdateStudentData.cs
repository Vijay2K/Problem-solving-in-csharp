//Q77. Write a program using ADO.NET to update the student’s age data into the table.

using System;
using System.Data.SqlClient;

namespace ADO.NET_Assignments
{
    internal class Q77_UpdateStudentData
    {
        public static void UpdateStudentData()
        {
           Console.WriteLine("\nQ77. Write a program using ADO.NET to update the student’s age data into the table.");
           
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=LAPTOP-5KUUT9S4;Database=students;Trusted_Connection=True;";
                conn.Open();
                Console.WriteLine("\nConnected to database...");

                string name;
                Console.Write("\nEnter the name to whom you want to change the name : ");
                name = Console.ReadLine();
                int age;
                Console.Write("Enter the new age : ");
                age = int.Parse(Console.ReadLine());

                string checkCommand = $"SELECT Name FROM Students_Data WHERE Name='{name}'"; ;

                SqlCommand commandToCheck = new SqlCommand(checkCommand, conn);

                string db_name = (string)commandToCheck.ExecuteScalar();

                if (db_name == null)
                {
                    Console.WriteLine("Name doesn't exists");
                }
                else
                {
                    string command = $"UPDATE Students_Data SET Age='{age}' WHERE Name='{name}'";
                    SqlCommand updateCommand = new SqlCommand(command, conn);
                    updateCommand.ExecuteNonQuery();
                    Console.WriteLine("Successfully updated...");
                }
            }
        }
    }
}
