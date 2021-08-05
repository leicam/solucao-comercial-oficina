using Microsoft.Extensions.Configuration;

namespace Oficina.Utilidades.nsExtensions
{
    public static class ConfigurationExtensions
    {
        public static string GetDefaultConnectionString(this IConfiguration configuration)
            => configuration.GetConnectionString("DefaultConnection");
    }
}