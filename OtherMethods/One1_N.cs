using Dapper;
using BaltaDataAcess.Models;
using Microsoft.Data.SqlClient;

namespace BaltaDataAcess;

public static class One1_N
{
    public static void OneToMany(SqlConnection connection)
    {
        var sql = @"SELECT 
        [Career].[Id],
        [Career].[Title],
        [CareerItem].[CareerId],
        [CareerItem].[Title]
    FROM 
        [Career] 
    INNER JOIN 
        [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id]
    ORDER BY
        [Career].[Title]";

        var careers = new List<Career>();
        var items = connection.Query<Career, CareerItem, Career>
        (sql, (career, item) =>
        {
            var car = careers.Where(x => x.Id == career.Id).FirstOrDefault();
            if (car == null)
            {
                car = career;
                car.Items?.Add(item);
                careers.Add(car);
            }
            else
            {
                car.Items?.Add(item);
            }
            return career;
        },
        splitOn: "CareerId");

        foreach (var career in careers)
        {
            Console.WriteLine($"{career.Title}");
            foreach (var item in career.Items)
            {
                Console.WriteLine($" - {item.Title}");
            }
        }
    }
}
