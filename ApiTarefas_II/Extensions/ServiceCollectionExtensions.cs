using System.Data.SqlClient;
using static ApiTarefas_II.Data.TarefaContext;

namespace TarefasApi.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddScoped<GetConnection>(sp =>
            async () =>
            {
                var connection = new SqlConnection(connectionString);//criando uma nova conecção
                await connection.OpenAsync();
                return connection;
            });
            return builder;
        }
    }
}
//Pode-se então usar o método de extesão na classe program;