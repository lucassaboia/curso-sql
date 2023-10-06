using Microsoft.Data.SqlClient;
using Dapper;
using BaltaDataAcess.Models;

namespace BaltaDataAcess
{
    public static class Read
    {
        public static void ListCategories(SqlConnection connection)
        {
            var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
            foreach (var item in categories)
            {
                Console.WriteLine($"{item.Id} - {item.Title}");
            }
        }
    }
}