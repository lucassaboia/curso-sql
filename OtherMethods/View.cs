using Dapper;
using Microsoft.Data.SqlClient;
using BaltaDataAcess.Models;

namespace BaltaDataAcess;

public static class View
{
    public static void ReadView(SqlConnection connection)
    {
        var sql = "SELECT * FROM [vwCourses]";
        var courses = connection.Query(sql);
        foreach (var item in courses)
        {
            Console.WriteLine($"{item.Id} - {item.Title}");
        }
    }
}
