using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LimiaUrbanus.WebSite.Models
{
    public class LimiaUrbanusDbContext : DbContext
    {
        public LimiaUrbanusDbContext()
            : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Tipo> Tipos { get; set; }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<Objetivo> Objetivos { get; set; }

        public DbSet<Tipologia> Tipologias { get; set; }

        public DbSet<ClasseEnergetica> ClassesEnergeticas { get; set; }
    }
}
