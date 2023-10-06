using Microsoft.Data.SqlClient;
using Dapper;
using BaltaDataAcess.Models;

namespace BaltaDataAcess
{
    public static class Delete
    {
        public static void DeleteCategories(SqlConnection connection)
        {
            var updateQuery = "DELETE FROM [Category] WHERE [Id]=@Id";
            var rows = connection.Execute(updateQuery, new
            {
                id = new Guid("41548445-8de1-4496-8414-6a33989b0acd"),
            });
            Console.WriteLine($"{rows} registros atualizados");
        }
    }
}