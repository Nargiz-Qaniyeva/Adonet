using System;
using System.Data.SqlClient;

namespace Ado.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetEmployeeById();
            //AddEmployee();
            //DeleteEmployee();
            // GetAllEmployees();
            FilterByName("n");
        }
        private static string connectionString = "Data Source=.;Initial Catalog=ADONET;"
        + "Integrated Security=true;";

        public static void GetEmployeeById()
        {
            using (SqlConnection connection= new SqlConnection(connectionString))
            {
                connection.Open();
                string command = "SELECT Fullname FROM Employee WHERE Id=1";
                using (SqlCommand cmd = new SqlCommand(command,connection))
                {
                    string name=cmd.ExecuteScalar().ToString();
                    Console.WriteLine(name);

                }
            }
        }
        public static void AddEmployee()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string command = "INSERT INTO Employee VALUES ('Ilkin Ibrahimov')";
                using (SqlCommand cmd = new SqlCommand(command, connection))
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result>0)
                    {
                        Console.WriteLine("Employee Fullname Added");
                    }
                    else
                    {
                        Console.WriteLine("Employee Exception...");
                    }

                }
            }
        }
        public static void DeleteEmployee()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string command = "DELETE FROM Employee WHERE Id=2;";
                using (SqlCommand cmd = new SqlCommand(command, connection))
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Deleted 2 id data");
                    }
                    else
                    {
                        Console.WriteLine("Not deleted...");
                    }

                }
            }
        }
        public static void GetAllEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string command = "SELECT * FROM Employee";
                using (SqlCommand sqlcommand = new SqlCommand(command, connection))
                {
                    SqlDataReader reader=sqlcommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Fullname:{reader["Fullname"]}");
                        }
                    }
                }
            }
        }
        public static void FilterByName(string search)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string command = $"SELECT Fullname FROM Employee WHERE Fullname LIKE '%{search}%'";
                using (SqlCommand sqlcommand = new SqlCommand(command, connection))
                {
                    SqlDataReader reader = sqlcommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Fullname:{reader["Fullname"]}");
                        }
                    }
                }
            }
        }

    }
}
