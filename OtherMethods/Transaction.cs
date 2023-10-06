using Dapper;
using BaltaDataAcess.Models;
using Microsoft.Data.SqlClient;

namespace BaltaDataAcess;

public static class TransactionClass
{
    public static void Transaction(SqlConnection connection)
    {
        connection.Open();
        var category = new Category();
        category.Id = Guid.NewGuid();
        category.Title = "Categoria que não quero";
        category.Url = "";
        category.Description = "Categoria destinada a serviços do AWS";
        category.Order = 8;
        category.Summary = "AWS Cloud";
        category.Featured = false;
        var insertSql = @"INSERT INTO
        [Category]
        VALUES
            ( @Id, @Title, @Url, @Summary, @Order, @Description ,@Featured )";
        using (var transaction = connection.BeginTransaction())
        {
            var rows = connection.Execute(insertSql, new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featured
            }, transaction);
            transaction.Commit();
            transaction.Rollback();
            Console.WriteLine($"{rows} Linhas inseridas");
        }
    }
}
