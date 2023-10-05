﻿using Microsoft.Data.SqlClient;

namespace BaltaDataAcess;

class Program
{
    static void Main(string[] args)
    {
        const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1XfM4NeszwtckTP1bl4z!";

        using (var connection = new SqlConnection(connectionString))
        {
            Console.WriteLine("Conectado");
            connection.Open();

            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT [Id], [Title] From [Category]";

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                }
            }
        }


        Console.WriteLine("Hello, World!");
    }
}
