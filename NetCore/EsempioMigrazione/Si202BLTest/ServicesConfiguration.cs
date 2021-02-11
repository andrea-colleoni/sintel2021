using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Si2020BLCore;
using Si2020LibCore;
using System.IO;

namespace Si202BLTest
{
    public class ServicesConfiguration
    {
        public ServiceProvider Provider { get; set; }
        public ServicesConfiguration()
        {            
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IConfiguration>(config);
            serviceCollection.AddLogging(cofigure =>
            {
                cofigure.AddConsole();
            });

            serviceCollection.RegisterDataServices();
            serviceCollection.RegisterBusinessServices();

            Provider = serviceCollection.BuildServiceProvider();
            
        }
    }
}
