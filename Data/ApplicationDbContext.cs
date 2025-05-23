using atv1.Models;
using Microsoft.EntityFrameworkCore;

namespace atv1.Data
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relacionamento Estado -> Cidades
            modelBuilder.Entity<Estado>()
                .HasMany(e => e.Cidades)
                .WithOne(c => c.Estado)
                .HasForeignKey(c => c.EstadoId);
        }
    }


}

