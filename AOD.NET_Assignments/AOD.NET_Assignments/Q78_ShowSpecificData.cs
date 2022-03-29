//Q78. Write a program using ADO.NET to show the students whose age is below 30.

using System;
using System.Data.SqlClient;

namespace ADO.NET_Assignments
{
    internal class Q78_ShowSpecificData
    {
        public static void ShowSpecificData()
        {
            Console.WriteLine("Q78. Write a program using ADO.NET to show the students whose age is below 30.");

            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=LAPTOP-5KUUT9S4;Database=students;Trusted_Connection=True;";
                conn.Open();
                Console.WriteLine("\nConnected...");

                string COMMAND = "SELECT * FROM Students_Data WHERE Age < 30";
                SqlCommand sqlCommand = new SqlCommand(COMMAND, conn);

                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    Console.WriteLine("Name  RollNo  Age  Percentage");
                    while(reader.Read())
                    {
                        Console.WriteLine("{0}{1}  {2}  {3}", reader[0], reader[1], reader[2], reader[3]);
                    }

                }
            }
        }
    }
}
