using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace NetCoreCL
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
            var logger = loggerProvider.CreateLogger("NetCoreCL");

            services.AddDbContext<CorsoContext>(o =>
            {
                o.UseSqlServer(Configuration.GetConnectionString("CorsoDb"), b => {
                    b.MigrationsAssembly("AspnetCoreAPI");
                });
                
            });
            logger.LogInformation("data service configured");
            return services;
        }
    }
}
