using LimiaUrbanus.WebSite.Models;

namespace LimiaUrbanus.WebSite.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LimiaUrbanusDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LimiaUrbanus.WebSite.Models.LimiaUrbanusDbContext";
        }

        protected override void Seed(LimiaUrbanusDbContext context)
        {
            context.Tipos.AddOrUpdate(
                t => t.Nome,
                new Tipo { TipoId = 1, Nome = "Andar Moradia" },
                new Tipo { TipoId = 2, Nome = "Apartamento" },
                new Tipo { TipoId = 3, Nome = "Armazém" },
                new Tipo { TipoId = 4, Nome = "Escritório" },
                new Tipo { TipoId = 5, Nome = "Loja" },
                new Tipo { TipoId = 6, Nome = "Moradia" },
                new Tipo { TipoId = 7, Nome = "Prédio" },
                new Tipo { TipoId = 8, Nome = "Quinta" },
                new Tipo { TipoId = 9, Nome = "Quintinha" },
                new Tipo { TipoId = 10, Nome = "Terreno" }
            );

            context.Estados.AddOrUpdate(
                e => e.Nome,
                new Estado { EstadoId = 1, Nome = "Construção" },
                new Estado { EstadoId = 2, Nome = "Novo" },
                new Estado { EstadoId = 3, Nome = "Planta" },
                new Estado { EstadoId = 4, Nome = "Usado" }
            );

            context.Objetivos.AddOrUpdate(
                o => o.Nome,
                new Objetivo { ObjetivoId = 1, Nome = "Arrenda-se" },
                new Objetivo { ObjetivoId = 2, Nome = "Time-Sharing" },
                new Objetivo { ObjetivoId = 3, Nome = "Trespassa-se" },
                new Objetivo { ObjetivoId = 4, Nome = "Vende-se" }
            );

        }
    }
}
