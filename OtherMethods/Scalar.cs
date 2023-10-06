using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using BaltaDataAcess.Models;

namespace BaltaDataAcess;

public static class Scalar
{
    public static void ExecuteScalar(SqlConnection connection)
    {
        var category = new Category();
        category.Title = "Amazon AWS";
        category.Url = "";
        category.Description = "Categoria destinada a serviços do AWS";
        category.Order = 9;
        category.Summary = "AWS Cloud";
        category.Featured = false;
        var insertSql = @"INSERT INTO
        [Category] OUTPUT inserted.[Id]
        VALUES
            ( NEWID(), @Title, @Url, @Summary, @Order, @Description ,@Featured )";

        var id = connection.ExecuteScalar<Guid>(insertSql, new { category.Title, category.Url, category.Summary, category.Order, category.Description, category.Featured });
        Console.WriteLine($"A categoria inserida foi: {id} ");
    }
}
