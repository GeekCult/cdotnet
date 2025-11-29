using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace sqltest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "127.0.0.1,1433",
                UserID = "sa",
                Password = "Root@2579",
                InitialCatalog = "profeus",
                TrustServerCertificate = true,
            };

            var connectionString = builder.ConnectionString;

            try
            {
                await using var connection = new SqlConnection(connectionString);
                Console.WriteLine("\nQuery data example:");
                Console.WriteLine("=========================================\n");

                await connection.OpenAsync();

                var sql = "SELECT firstName, lastName FROM userData";
                await using var command = new SqlCommand(sql, connection);
                await using var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                }
            }
            catch (SqlException e) when (e.Number != 0)
            {
                Console.WriteLine($"SQL Error: {e.Number}");
                Console.WriteLine($"SQL Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();
        }
    }
}