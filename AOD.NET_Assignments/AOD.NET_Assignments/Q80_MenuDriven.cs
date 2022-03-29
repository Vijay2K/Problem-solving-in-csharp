//Q80. Write a Menu driven program for  insert, update, delete ,and show the information from table using ADO.NET

using System;
using System.Collections;
using System.Data.SqlClient;
using System.Threading;

namespace ADO.NET_Assignments
{
    internal class Q80_MenuDriven
    {
        public static void MenuDriven()
        {
            Console.WriteLine("\nQ80. Write a Menu driven program for  insert, update, delete ,and show the information from table using ADO.NET");
            string connectionString = "Server=LAPTOP-5KUUT9S4;Database=students;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                Console.WriteLine("Sucessfully connected to the database...");
            }

            Choices(connectionString);
        }

        private static void Choices(string connectionString)
        {
            char choice;
            Console.WriteLine("Enter the choice : ");
            choice = char.Parse(Console.ReadLine());
            switch (choice)
            {
                case '1':
                    InsertData(connectionString);
                    break;
                case '2':
                    UpdateData(connectionString);
                    break;
                case '3':
                    break;
                default:
                    break;
            }
        }

        private static void InsertData(string connectionString)
        {
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                retry:
                Console.Write("Enter the table name : ");
                string tableName = Console.ReadLine();

                int size;
                string name;
                int id;
                string departement;
                int salary;

                ArrayList nameList = new ArrayList();
                ArrayList idList = new ArrayList();
                ArrayList departmentList = new ArrayList();
                ArrayList salaryList = new ArrayList();
                
                Console.Write("Enter the no of employee : ");
                size = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the employee details");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("\nEmployee " + i + 1);
                    Console.Write("Enter the name : ");
                    name = Console.ReadLine();
                    nameList.Add(name);

                    Console.Write("Enter the ID : ");
                    id = int.Parse(Console.ReadLine());
                    idList.Add(id);

                    Console.Write("Enter the department : ");
                    departement = Console.ReadLine();
                    departmentList.Add(departement);

                    Console.Write("Enter the salary : ");
                    salary = int.Parse(Console.ReadLine());
                    salaryList.Add(salary);
                }

                if(TableExists(tableName, connectionString))
                {
                    int i = 0;
                    while(i < size)
                    {
                        string command = $"INSERT INTO {tableName} VALUES (@0, @1, @2, @3)";
                        SqlCommand insertCommand = new SqlCommand(command, conn);

                        insertCommand.Parameters.Add(new SqlParameter("0", nameList[i]));
                        insertCommand.Parameters.Add(new SqlParameter("1", idList[i]));
                        insertCommand.Parameters.Add(new SqlParameter("2", departmentList[i]));
                        insertCommand.Parameters.Add(new SqlParameter("3", salaryList[i]));

                        insertCommand.ExecuteNonQuery();
                        i++;
                    }

                    Console.WriteLine("Successfully inserted...");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    Choices(connectionString);
                }
                else
                {
                    Console.WriteLine("Table Doesn't exists....");
                    Console.WriteLine("Pls try again....");
                    Console.WriteLine("Press any key....");
                    Console.ReadLine();
                    goto retry;
                }

            }
        }

        private static void UpdateData(string connectionString)
        {
            
        }

        private static bool TableExists(string tableName, string connectionString)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string command = string.Format($"IF OBJECT_ID('{tableName}', 'U') IS NOT NULL SELECT 'true' ELSE SELECT 'false'");
                SqlCommand checkCommand = new SqlCommand(command, conn);
                checkCommand.CommandType = System.Data.CommandType.Text;
                conn.Open();

                return Convert.ToBoolean(checkCommand.ExecuteScalar());
            }
        }
    }
}
