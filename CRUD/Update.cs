using Microsoft.Data.SqlClient;
using Dapper;
using BaltaDataAcess.Models;

namespace BaltaDataAcess
{
    public static class Update
    {
        public static void UpdateCategory(SqlConnection connection)
        {
            var updateQuery = "UPDATE [Category] SET [Title]=@title WHERE [Id]=@Id";
            var rows = connection.Execute(updateQuery, new
            {
                id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
                title = "Frontend"
            });
            Console.WriteLine($"{rows} registros atualizados");
        }
    }
}