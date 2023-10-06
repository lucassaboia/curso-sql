using Microsoft.Data.SqlClient;
using Dapper;
using BaltaDataAcess.Models;
using System.Data;
using System.Collections.Generic;
namespace BaltaDataAcess;

class Program
{
    static void Main(string[] args)
    {
        const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1XfM4NeszwtckTP1bl4z!";
        using (var connection = new SqlConnection(connectionString))
        {
            //CRUD
            // Update.UpdateCategory(connection);
            // CreateCategories.CreateCategory(connection);
            // Delete.DeleteCategories(connection);
            Read.ListCategories(connection);

            //EXECUTE - 
            // Procedure.ExecuteProcedure(connection);
            // ReadProcedure.ExecuteReadProcedure(connection);

            //CreateManyCategory(connection);
            // Scalar.ExecuteScalar(connection);
            // View.ReadView(connection);
            // One1_1.OneToOne(connection);
            // One1_N.OneToMany(connection);
            // MultipleQuery.QueryMultiple(connection);
            // InSelect.SelectIn(connection);
            // Like.SelectLike(connection, "API");
            // TransactionClass.Transaction(connection);
        }
    }
}