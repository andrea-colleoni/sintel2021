using Microsoft.EntityFrameworkCore;
using Si2020Lib.Model;

namespace Si2020Lib.Context
{
    public partial class SiDb : DbContext
    {
        public SiDb(DbContextOptions<SiDb> options)
            : base(options)
        {
        }
        public virtual DbSet<Evento> Eventi { get; set; }
        public virtual DbSet<Garanzia> Garanzie { get; set; }
        public virtual DbSet<LDAP> LDAP { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Personale> Personale { get; set; }
        public virtual DbSet<SistemaOperativo> SistemiOperativi { get; set; }
        public virtual DbSet<StatoAnagrafe> StatiAnagrafe { get; set; }
        public virtual DbSet<StatoQualifica> StatiQualifica { get; set; }
        public virtual DbSet<TipoAnagrafe> TipiAnagrafe { get; set; }
        public virtual DbSet<Utente> Utenti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
