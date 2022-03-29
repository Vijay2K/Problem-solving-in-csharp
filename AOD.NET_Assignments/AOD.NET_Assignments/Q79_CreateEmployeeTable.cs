//Q78. Write a program using ADO.NET to create the employee table with some fields.

using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET_Assignments
{
    internal class Q79_CreateEmployeeTable
    {
        public static void CreateEmployeeTable()
        {
            Console.WriteLine("Q78. Write a program using ADO.NET to create the employee table with some fields.");
            string tableName;

            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=LAPTOP-5KUUT9S4;Database=students;Trusted_Connection=True;";
                conn.Open();
                Console.WriteLine("Successfully connected to the database....");

                Console.Write("Enter the table name : ");
                tableName = Console.ReadLine();

                if(!TableExists(tableName, conn.ConnectionString))
                {
                    string command = $"CREATE TABLE {tableName} (" +
                   "Name varchar(20), " +
                   "Id int, " +
                   "Department varchar(30), " +
                   "Salary int)";

                    SqlCommand createTableCommand = new SqlCommand(command, conn);
                    createTableCommand.ExecuteNonQuery();
                }
                else
                {
                    Console.WriteLine("Table Already exists...");
                }

               
            }
        }

        private static bool TableExists(string tableName, string connectionString)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkTable = string.Format($"IF OBJECT_ID('{tableName}', 'U') IS NOT NULL SELECT 'true' ELSE SELECT 'false'");

                SqlCommand command = new SqlCommand(checkTable, conn);
                command.CommandType = CommandType.Text;
                conn.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }
    }
}
