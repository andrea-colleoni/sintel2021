using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreCL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleCore
{
    public class Startup
    {
        public static IServiceProvider Provider { get; }

        public Startup()
        {
            var env = Environment.GetEnvironmentVariable("SINTEL_ENV")??"dev";

            //Configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .AddJsonFile($"appsettings.{env}.json")
            //    .Build();

            //var services = new ServiceCollection();

            //// add my services

            ////services.RegisterDataServices(Configuration);

            //Provider = services.BuildServiceProvider();

        }
    }
}
