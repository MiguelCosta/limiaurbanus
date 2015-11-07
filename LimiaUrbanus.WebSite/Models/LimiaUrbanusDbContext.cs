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

    }
}
