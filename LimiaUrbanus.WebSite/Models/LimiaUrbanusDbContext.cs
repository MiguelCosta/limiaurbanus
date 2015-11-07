using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LimiaUrbanus.WebSite.Models
{
    public class LimiaUrbanusDbContext : DbContext
    {
        public LimiaUrbanusDbContext()
            : base("DefaultConnection")
        {
        }

        public static LimiaUrbanusDbContext Create()
        {
            return new LimiaUrbanusDbContext();
        }

        public DbSet<Tipo> Tipos { get; set; }

        public DbSet<Estado> Estados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
