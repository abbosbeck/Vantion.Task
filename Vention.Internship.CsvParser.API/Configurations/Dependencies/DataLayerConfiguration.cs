using Microsoft.EntityFrameworkCore;
using Vention.Internship.CsvParser.Data.DbContexts;
using Vention.Internship.CsvParser.Data.Repositories;

namespace Vention.Internship.CsvParser.API.Configurations.Dependencies
{
    public static class DataLayerConfiguration
    {
        public static void AddDataLayer(this WebApplicationBuilder builder)
        {
            string connectionString = builder.Configuration.GetConnectionString("CSVParserDb");
            builder.Services.AddDbContext<CsvParserDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            builder.Services.AddTransient<IUserRepository, UserRepositories>();
        }
    }
}
