using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BaltaDataAcess;

public static class Procedure
{
    public static void ExecuteProcedure(SqlConnection connection)
    {
        var procedure = "[spDeleteStudent]";
        var pars = new { StudentId = "cf32c35e-6a25-451b-bf75-c0745964006b" };
        var affectedRows = connection.Execute(procedure, pars, commandType: CommandType.StoredProcedure);

        Console.WriteLine($"{affectedRows} linhas afetadas");
    }
}
