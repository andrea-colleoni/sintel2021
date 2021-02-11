using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Si2020Lib.Context;

namespace Si2020LibCore
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataServices(
           this IServiceCollection services
           )
        {
            var provider = services.BuildServiceProvider();

            var Configuration = provider.GetRequiredService<IConfiguration>();
            var loggerProvider = provider.GetRequiredService<ILoggerProvider>();
            var logger = loggerProvider.CreateLogger("EFCoreLib");

            if (Configuration.GetSection("appSettings")["env"] == "test")
            {
                services.AddDbContext<SiDb>(o =>
                {
                    o.UseInMemoryDatabase("InMemory");
                });
            }
            else
            {
                services.AddDbContext<SiDb>(o =>
                {
                    o.UseSqlServer(Configuration.GetConnectionString("SiDb"));
                });
            }

            logger.LogInformation("data service configured");
            return services;
        }
    }
}
