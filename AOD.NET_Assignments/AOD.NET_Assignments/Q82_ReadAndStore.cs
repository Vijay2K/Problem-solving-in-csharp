//Q82. Write a program to read data from XML file and store it into the table.

using System;
using System.Collections;
using System.Xml;
using System.Data.SqlClient;

namespace ADO.NET_Assignments
{
    internal class Q82_ReadAndStore
    {
        public static void ReadAndStore()
        {
            start:
            Console.WriteLine("\nQ82. Write a program to read data from XML file and store it into the table.");
            string fileName;
            string tableName;

            ArrayList nameList = new ArrayList();
            ArrayList idList = new ArrayList();
            ArrayList salaryList = new ArrayList();

            Console.Write("Enter the file name : ");
            fileName = Console.ReadLine();

            try
            {
                string path = $"D:\\Personal Projects\\CSharp Projects\\Assignments\\XML Files\\{fileName}.xml";
                string connectionString = "Server=LAPTOP-5KUUT9S4;Database=students;Trusted_Connection=True;";

                XmlTextReader xmlReader = new XmlTextReader(path);

                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Name")
                    {
                        string name = xmlReader.ReadElementString();
                        nameList.Add(name);
                    }
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Id")
                    {
                        int id = xmlReader.ReadElementContentAsInt();
                        idList.Add(id);
                    }
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Salary")
                    {
                        int salary = xmlReader.ReadElementContentAsInt();
                        salaryList.Add(salary);
                    }
                }

                Console.WriteLine("Read all the xml file successfully....");

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    Console.WriteLine("Connected to the database successfully...");

                    retry:
                    Console.Write("Enter the table name : ");
                    tableName = Console.ReadLine();

                    if (!TableExists(tableName, connectionString))
                    {
                        string COMMAND = $"CREATE TABLE {tableName} (" +
                            "Name varchar(20), " +
                            "ID int, " +
                            "Salary int)";

                        SqlCommand createTableCommand = new SqlCommand(COMMAND, conn);
                        createTableCommand.ExecuteNonQuery();
                        Console.WriteLine("\nSuccessfully created a table...");

                        int i = 0;
                        while (i < nameList.Count)
                        {
                            SqlCommand insertCommand = new SqlCommand($"INSERT INTO {tableName} VALUES (@0, @1, @2)", conn);
                            insertCommand.Parameters.Add(new SqlParameter("0", nameList[i]));
                            insertCommand.Parameters.Add(new SqlParameter("1", idList[i]));
                            insertCommand.Parameters.Add(new SqlParameter("2", salaryList[i]));
                            insertCommand.ExecuteNonQuery();
                            i++;
                        }

                        Console.WriteLine("Inserted");

                    }
                    else
                    {
                        Console.WriteLine("Table name already exists....");
                        Console.WriteLine("Pls try again...");
                        Console.WriteLine("Press any key to continue....");
                        Console.ReadLine();
                        goto retry;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Pls try again...");
                Console.WriteLine("Press any key...");
                Console.ReadLine();
                Console.Clear();
                goto start;
            }
            
        }

        private static bool TableExists(string tableName, string connectionString)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkTableCommand = string.Format($"IF OBJECT_ID('{tableName}', 'U') IS NOT NULL SELECT 'true' ELSE SELECT 'false'"); ;
                SqlCommand command = new SqlCommand(checkTableCommand, conn);
                command.CommandType = System.Data.CommandType.Text;
                conn.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }
    }
}
