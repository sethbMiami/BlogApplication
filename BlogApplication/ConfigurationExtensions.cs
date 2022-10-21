
namespace BlogApplication
{
    public static class ConfigurationExtensions
    {
        public static string GetGoogleClientId(this IConfiguration configuration)
        {
            return configuration.GetValue<string>("Authentication:Google:ClientId");
        }

        public static string GetGoogleClientSecret(this IConfiguration configuration)
        {
            return configuration.GetValue<string>("Authentication:Google:ClientSecret");
        }
    }
}
