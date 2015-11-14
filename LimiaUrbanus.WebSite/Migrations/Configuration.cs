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

            context.Tipologias.AddOrUpdate(
                t => t.Nome,
                new Tipologia { TipologiaId = 1, Nome = "T0", Ordem = 1 },
                new Tipologia { TipologiaId = 2, Nome = "T1", Ordem = 2 },
                new Tipologia { TipologiaId = 3, Nome = "T1+1", Ordem = 3 },
                new Tipologia { TipologiaId = 4, Nome = "T2", Ordem = 4 },
                new Tipologia { TipologiaId = 5, Nome = "T2+1", Ordem = 5 },
                new Tipologia { TipologiaId = 6, Nome = "T3", Ordem = 6 },
                new Tipologia { TipologiaId = 7, Nome = "T3+1", Ordem = 7 },
                new Tipologia { TipologiaId = 8, Nome = "T4", Ordem = 8 },
                new Tipologia { TipologiaId = 9, Nome = "T4+1", Ordem = 9 },
                new Tipologia { TipologiaId = 10, Nome = ">=T5", Ordem = 10 }
            );


        }
    }
}
