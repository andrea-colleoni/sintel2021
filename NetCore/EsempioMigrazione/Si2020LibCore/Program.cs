using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Si2020LibCore
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            var env = Environment.GetEnvironmentVariable("SINTEL_ENV") ?? "dev";

            return Host.CreateDefaultBuilder(args)
                .ConfigureHostConfiguration(config =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile("appsettings.json");
                })
                .ConfigureServices(services =>
                {
                    services.RegisterDataServices();
                });
        }
    }
}
