using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using BaltaDataAcess.Models;

namespace BaltaDataAcess;

public static class ReadProcedure
{
    public static void ExecuteReadProcedure(SqlConnection connection)
    {
        var procedure = "[spGetCoursesByCategory]";
        var pars = new { CategoryId = "25d510c8-3108-44c2-86c5-924d9832aa8c" };
        var courses = connection.Query<Category>(procedure, pars, commandType: CommandType.StoredProcedure);
        foreach (var item in courses)
        {
            Console.WriteLine(item.Title);
        }

    }
}
