using Microsoft.Extensions.DependencyInjection;
using Si2020BLCore.Services;
using Si2020Lib.Context;
using System.Linq;
using Xunit;

namespace Si202BLTest.BLTests
{
    public class EsempioBLTest
    {
        private ServiceProvider serviceProvider;
        public EsempioBLTest()
        {
            var sc = new ServicesConfiguration();
            serviceProvider = sc.Provider;
        }

        [Fact]
        public void TestMetodo()
        {
            var es = serviceProvider.GetService<IEsempioService>();
            es.MetodoServizio();
            Assert.True(true);
        }

        [Fact]
        public void TestDb()
        {
            var db = serviceProvider.GetService<SiDb>();
            Assert.True(db.Utenti.Count() == 1);
        }
    }
}
