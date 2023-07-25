using Vention.Internship.CsvParser.Service.Services;

namespace Vention.Internship.CsvParser.API.Configurations.Dependencies
{
    public static class ServiceLayerConfiguration
    {
        public static void AddServiceLayer(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUserService, UserService>();
        }
    }
}
