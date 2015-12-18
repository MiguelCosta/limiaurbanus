using LimiaUrbanus.WebSite.Models;
using System.Linq;

namespace LimiaUrbanus.WebSite.Migrations
{
    using System.Collections.Generic;
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
                new Tipo { Nome = "Andar Moradia" },
                new Tipo { Nome = "Apartamento" },
                new Tipo { Nome = "Armazém" },
                new Tipo { Nome = "Escritório" },
                new Tipo { Nome = "Loja" },
                new Tipo { Nome = "Moradia" },
                new Tipo { Nome = "Prédio" },
                new Tipo { Nome = "Quinta" },
                new Tipo { Nome = "Quintinha" },
                new Tipo { Nome = "Terreno" }
            );

            context.Estados.AddOrUpdate(
                e => e.Nome,
                new Estado { Nome = "Construção" },
                new Estado { Nome = "Novo" },
                new Estado { Nome = "Planta" },
                new Estado { Nome = "Usado" }
            );

            context.Objetivos.AddOrUpdate(
                o => o.Nome,
                new Objetivo { Nome = "Arrenda-se" },
                new Objetivo { Nome = "Time-Sharing" },
                new Objetivo { Nome = "Trespassa-se" },
                new Objetivo { Nome = "Vende-se" }
            );

            context.Tipologias.AddOrUpdate(
                t => t.Nome,
                new Tipologia { Nome = "", Ordem = 0 },
                new Tipologia { Nome = "T0", Ordem = 1 },
                new Tipologia { Nome = "T1", Ordem = 2 },
                new Tipologia { Nome = "T1+1", Ordem = 3 },
                new Tipologia { Nome = "T2", Ordem = 4 },
                new Tipologia { Nome = "T2+1", Ordem = 5 },
                new Tipologia { Nome = "T3", Ordem = 6 },
                new Tipologia { Nome = "T3+1", Ordem = 7 },
                new Tipologia { Nome = "T4", Ordem = 8 },
                new Tipologia { Nome = "T4+1", Ordem = 9 },
                new Tipologia { Nome = ">=T5", Ordem = 10 }
            );

            context.ClassesEnergeticas.AddOrUpdate(
                c => c.Nome,
                new ClasseEnergetica { Nome = "", Ordem = 0 },
                new ClasseEnergetica { Nome = "A", Ordem = 1 },
                new ClasseEnergetica { Nome = "A+", Ordem = 2 },
                new ClasseEnergetica { Nome = "B", Ordem = 3 },
                new ClasseEnergetica { Nome = "B-", Ordem = 4 },
                new ClasseEnergetica { Nome = "C", Ordem = 5 },
                new ClasseEnergetica { Nome = "D", Ordem = 6 },
                new ClasseEnergetica { Nome = "E", Ordem = 7 },
                new ClasseEnergetica { Nome = "F", Ordem = 8 }
            );

            context.Distritos.AddOrUpdate(
                d => d.Nome,
                new Distrito
                {
                    Nome = "Viana do Castelo",
                    Concelhos = new List<Concelho>
                    {
                        new Concelho
                        {
                            Nome = "Arcos de Valdevez",
                            Freguesias = new List<Freguesia>
                            {
                                new Freguesia {Nome="Aboim das Choças" },
                                new Freguesia {Nome="Aguiã" },
                                new Freguesia {Nome="Álvora e Loureda" },
                                new Freguesia {Nome="Arcos de Valdevez (São Paio) e Giela" },
                                new Freguesia {Nome="Arcos de Valdevez (Salvador), Vila Fonche e Parada" },
                                new Freguesia {Nome="Ázere" },
                                new Freguesia {Nome="Cabana Maior" },
                                new Freguesia {Nome="Cabreiro" },
                                new Freguesia {Nome="Cendufe" },
                                new Freguesia {Nome="Couto" },
                                new Freguesia {Nome="Eiras e Mei" },
                                new Freguesia {Nome="Gavieira" },
                                new Freguesia {Nome="Gondoriz" },
                                new Freguesia {Nome="Grade e Carralcova" },
                                new Freguesia {Nome="Guilhadeses e Santar" },
                                new Freguesia {Nome="Jolda (Madalena) e Rio Cabrão" },
                                new Freguesia {Nome="Miranda" },
                                new Freguesia {Nome="Monte Redondo" },
                                new Freguesia {Nome="Oliveira" },
                                new Freguesia {Nome="Paçô" },
                                new Freguesia {Nome="Padreiro (Salvador e Santa Cristina)" },
                                new Freguesia {Nome="Padroso" },
                                new Freguesia {Nome="Portela e Extremo" },
                                new Freguesia {Nome="Prozelo" },
                                new Freguesia {Nome="Rio de Moinhos" },
                                new Freguesia {Nome="Rio Frio" },
                                new Freguesia {Nome="Sabadim" },
                                new Freguesia {Nome="São Jorge e Ermelo" },
                                new Freguesia {Nome="São Paio de Jolda" },
                                new Freguesia {Nome="Senharei" },
                                new Freguesia {Nome="Sistelo" },
                                new Freguesia {Nome="Soajo" },
                                new Freguesia {Nome="Souto e Tabaçô" },
                                new Freguesia {Nome="Távora (Santa Maria e São Vicente)" },
                                new Freguesia {Nome="Vale" },
                                new Freguesia {Nome="Vilela, São Cosme e São Damião e Sá" }
                            }
                        },
                        new Concelho {
                            Nome = "Caminha" },
                        new Concelho {
                            Nome = "Melgaço" },
                        new Concelho {
                            Nome = "Monção" },
                        new Concelho {
                            Nome = "Paredes de Coura" },
                        new Concelho{
                            Nome = "Ponte da Barca",
                            Freguesias = new List<Freguesia>
                            {
                                new Freguesia {Nome="Azias" },
                                new Freguesia {Nome="Boivães" },
                                new Freguesia {Nome="Bravães" },
                                new Freguesia {Nome="Britelo" },
                                new Freguesia {Nome="Crasto, Ruivos e Grovelas" },
                                new Freguesia {Nome="Cuide de Vila Verde" },
                                new Freguesia {Nome="Entre Ambos-os-Rios, Ermida e Germil" },
                                new Freguesia {Nome="Lavradas" },
                                new Freguesia {Nome="Lindoso" },
                                new Freguesia {Nome="Nogueira" },
                                new Freguesia {Nome="Oleiros" },
                                new Freguesia {Nome="Ponte da Barca, Vila Nova de Muía e Paço Vedro de Magalhães" },
                                new Freguesia {Nome="Sampriz" },
                                new Freguesia {Nome="Touvedo (São Lourenço e Salvador)" },
                                new Freguesia {Nome="São Pedro de Vade" },
                                new Freguesia {Nome="São Tomé de Vade" },
                                new Freguesia {Nome="Vila Chã (São João Baptista e Santiago)" }
                            }
                        },
                        new Concelho {
                            Nome = "Ponte de Lima",
                            Freguesias = new List<Freguesia>
                            {
                                new Freguesia {Nome="Anais" },
                                new Freguesia {Nome="Arca e Ponte de Lima" },
                                new Freguesia {Nome="Arcozelo" },
                                new Freguesia {Nome="Ardegão, Freixo e Mato" },
                                new Freguesia {Nome="Bárrio e Cepões" },
                                new Freguesia {Nome="Beiral do Lima" },
                                new Freguesia {Nome="Bertiandos" },
                                new Freguesia {Nome="Boalhosa" },
                                new Freguesia {Nome="Brandara" },
                                new Freguesia {Nome="Cabaços e Fojo Lobal" },
                                new Freguesia {Nome="Cabração e Moreira do Lima" },
                                new Freguesia {Nome="Calheiros" },
                                new Freguesia {Nome="Calvelo" },
                                new Freguesia {Nome="Correlhã" },
                                new Freguesia {Nome="Estorãos" },
                                new Freguesia {Nome="Facha" },
                                new Freguesia {Nome="Feitosa" },
                                new Freguesia {Nome="Fontão" },
                                new Freguesia {Nome="Fornelos e Queijada" },
                                new Freguesia {Nome="Friastelas" },
                                new Freguesia {Nome="Gandra" },
                                new Freguesia {Nome="Gemieira" },
                                new Freguesia {Nome="Gondufe" },
                                new Freguesia {Nome="Labruja" },
                                new Freguesia {Nome="Labrujó, Rendufe e Vilar do Monte" },
                                new Freguesia {Nome="Navió e Vitorino dos Piães" },
                                new Freguesia {Nome="Poiares" },
                                new Freguesia {Nome="Refoios do Lima" },
                                new Freguesia {Nome="Ribeira" },
                                new Freguesia {Nome="Sá" },
                                new Freguesia {Nome="Santa Comba" },
                                new Freguesia {Nome="Santa Cruz do Lima" },
                                new Freguesia {Nome="Santa Maria de Rebordões" },
                                new Freguesia {Nome="São Pedro d'Arcos" },
                                new Freguesia {Nome="Souto de Rebordões" },
                                new Freguesia {Nome="Seara" },
                                new Freguesia {Nome="Serdedelo" },
                                new Freguesia {Nome="Vale do Neiva" },
                                new Freguesia {Nome="Vitorino das Donas" }
                            }
                        },
                        new Concelho {
                            Nome = "Valença" },
                        new Concelho {Nome = "Viana do Castelo" },
                        new Concelho {Nome = "Vila Nova de Cerveira" }
                    }
                });

        }
    }
}
