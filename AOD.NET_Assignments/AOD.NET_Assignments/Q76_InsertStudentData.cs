//Q76. Write a program using ADO.NET to insert the student data into the table.

using System;
using System.Collections;
using System.Data.SqlClient;

namespace ADO.NET_Assignments
{
    internal class Q76_InsertStudentData
    {
        public static void InsertStudentData()
        {
            string name;
            int rollNo;
            int age;
            float percentage;
            int size;

            ArrayList nameList = new ArrayList();
            ArrayList rollNoList = new ArrayList();
            ArrayList ageList = new ArrayList();
            ArrayList percentageList = new ArrayList();

            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=LAPTOP-5KUUT9S4;Database=students;Trusted_Connection=True;";
                conn.Open();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nConnected to database successfully");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nEnter the student details to insert into the database");

                Console.Write("\nEnter the number of students : ");
                size = int.Parse(Console.ReadLine());

                for(int i = 0; i < size; i++)
                {
                    Console.WriteLine("\nStudent {0} details : ", i + 1);
                    Console.Write("Enter the name : ");
                    name = Console.ReadLine();
                    nameList.Add(name);

                    Console.Write("Enter the roll no : ");
                    rollNo = int.Parse(Console.ReadLine());
                    rollNoList.Add(rollNo);

                    Console.Write("Enter the age : ");
                    age = int.Parse(Console.ReadLine());
                    ageList.Add(age);

                    Console.Write("Enter the percentage : ");
                    percentage = float.Parse(Console.ReadLine());
                    percentageList.Add(percentage);
                }


                int n = 0;
                while(n < size)
                {
                    string command = "INSERT INTO Students_Data VALUES(@0, @1, @2, @3)";
                    SqlCommand insertCommand = new SqlCommand(command, conn);

                    insertCommand.Parameters.Add(new SqlParameter("0", nameList[n]));
                    insertCommand.Parameters.Add(new SqlParameter("1", rollNoList[n]));
                    insertCommand.Parameters.Add(new SqlParameter("2", ageList[n]));
                    insertCommand.Parameters.Add(new SqlParameter("3", percentageList[n]));

                    insertCommand.ExecuteNonQuery();

                    n++;
                }

                Console.WriteLine("Successfully Inserted all the data in the table");
            }
        }
    }
}
