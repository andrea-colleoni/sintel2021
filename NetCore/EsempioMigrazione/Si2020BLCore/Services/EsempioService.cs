using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Si2020Lib.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Si2020BLCore.Services
{
    public interface IEsempioService
    {
        Task MetodoServizio();
    }

    public class EsempioService : IEsempioService
    {
        private readonly IConfiguration Configuration;
        private readonly ILoggerProvider LoggerProvider;
        private readonly SiDb Db;

        public EsempioService(
            IConfiguration Configuration,
            ILoggerProvider LoggerProvider,
            SiDb Db
            )
        {
            this.Configuration = Configuration;
            this.LoggerProvider = LoggerProvider;
            this.Db = Db;
        }
        public async Task MetodoServizio()
        {
            // do things
            var logger = LoggerProvider.CreateLogger("Service");
            logger.LogInformation((await this.Db.Utenti.CountAsync()).ToString());
        }
    }
}
