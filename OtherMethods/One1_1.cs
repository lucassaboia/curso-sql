using Dapper;
using BaltaDataAcess.Models;
using Microsoft.Data.SqlClient;

namespace BaltaDataAcess;

public static class One1_1
{
    public static void OneToOne(SqlConnection connection)
    {
        var sql = @"SELECT TOP 10 * FROM [CareerItem] 
        INNER JOIN [Course]
        ON [CareerItem].CourseId = [Course].[Id]";

        var items = connection.Query<CareerItem, Course, CareerItem>(sql, (careerItem, course) => { careerItem.Course = course; return careerItem; }, splitOn: "Id");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Title} - Curso: {item.Course?.Title} ");
        }
    }
}
