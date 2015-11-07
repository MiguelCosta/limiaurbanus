using LimiaUrbanus.WebSite.Models;

namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LimiaUrbanus.WebSite.Models.LimiaUrbanusDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LimiaUrbanus.WebSite.Models.LimiaUrbanusDbContext";
        }

        protected override void Seed(LimiaUrbanus.WebSite.Models.LimiaUrbanusDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Tipos.AddOrUpdate(
                t => t.Nome,
                new Tipo { TipoId = 1, Nome = "Andar Moradia" },
                new Tipo { TipoId = 2, Nome = "Apartamento" }
            );


            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
