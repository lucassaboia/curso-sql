using Dapper;
using BaltaDataAcess.Models;
using Microsoft.Data.SqlClient;

namespace BaltaDataAcess;

public static class InSelect
{
    public static void SelectIn(SqlConnection connection)
    {
        var query = @"SELECT TOP 10 * FROM Career WHERE [Id] IN @Id";

        var items = connection.Query<Career>(query, new
        {
            Id = new[]{
                "92d7e864-bea5-4812-80cc-c2f4e94db1af",
                "e6730d1c-6870-4df3-ae68-438624e04c72"
            }
        });
        foreach (var item in items)
        {
            Console.WriteLine(item.Title);
        }
    }
}
