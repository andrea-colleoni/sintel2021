using Microsoft.EntityFrameworkCore;
using NetStdCL.Model;

namespace NetCoreCL
{
    public class CorsoContext : DbContext
    {
        public CorsoContext(DbContextOptions<CorsoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Persone { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasKey(p => p.CodiceFiscale);
        }
    }
}
