using Dapper;
using BaltaDataAcess.Models;
using Microsoft.Data.SqlClient;

namespace BaltaDataAcess;

public static class Like
{
    public static void SelectLike(SqlConnection connection, string term)
    {
        var query = @"SELECT * FROM [Course] WHERE [Title] LIKE @exp";
        var items = connection.Query<Course>(query, new
        {
            exp = $"%{term}%"
        });
        foreach (var item in items)
        {
            Console.WriteLine(item.Title);
        }
        if (!items.Any())
        {
            Console.WriteLine("Nenhum item encontrado!");
        }
    }
}
