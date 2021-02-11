using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreCL;
using System;
using System.IO;

namespace ConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {

            CreateHostBuilder(args).Build().Run();

            //var db = startup.Provider.GetRequiredService<CorsoContext>();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var env = Environment.GetEnvironmentVariable("SINTEL_ENV") ?? "dev";

            return Host.CreateDefaultBuilder(args)
                .ConfigureHostConfiguration(config =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile("appsettings.json");
                    config.AddJsonFile($"appsettings.{env}.json");
                })
                .ConfigureServices(services =>
                {
                    services.RegisterDataServices();
                });
        }
    }
}
