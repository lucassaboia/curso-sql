using Dapper;
using BaltaDataAcess.Models;
using Microsoft.Data.SqlClient;

namespace BaltaDataAcess;

public static class CreateCategories
{
    public static void CreateCategory(SqlConnection connection)
    {
        var category = new Category();
        category.Id = Guid.NewGuid();
        category.Title = "Amazon AWS";
        category.Url = "";
        category.Description = "Categoria destinada a serviços do AWS";
        category.Order = 8;
        category.Summary = "AWS Cloud";
        category.Featured = false;
        var insertSql = @"INSERT INTO
        [Category]
        VALUES
            ( @Id, @Title, @Url, @Summary, @Order, @Description ,@Featured )";

        var rows = connection.Execute(insertSql, new { category.Id, category.Title, category.Url, category.Summary, category.Order, category.Description, category.Featured });
        Console.WriteLine($"{rows} Linhas inseridas");
    }
}
