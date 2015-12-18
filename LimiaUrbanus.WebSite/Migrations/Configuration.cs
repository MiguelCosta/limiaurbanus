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
                new Tipo { Nome = "Armaz�m" },
                new Tipo { Nome = "Escrit�rio" },
                new Tipo { Nome = "Loja" },
                new Tipo { Nome = "Moradia" },
                new Tipo { Nome = "Pr�dio" },
                new Tipo { Nome = "Quinta" },
                new Tipo { Nome = "Quintinha" },
                new Tipo { Nome = "Terreno" }
            );

            context.Estados.AddOrUpdate(
                e => e.Nome,
                new Estado { Nome = "Constru��o" },
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
                                new Freguesia {Nome="Aboim das Cho�as" },
                                new Freguesia {Nome="Agui�" },
                                new Freguesia {Nome="�lvora e Loureda" },
                                new Freguesia {Nome="Arcos de Valdevez (S�o Paio) e Giela" },
                                new Freguesia {Nome="Arcos de Valdevez (Salvador), Vila Fonche e Parada" },
                                new Freguesia {Nome="�zere" },
                                new Freguesia {Nome="Cabana Maior" },
                                new Freguesia {Nome="Cabreiro" },
                                new Freguesia {Nome="Cendufe" },
                                new Freguesia {Nome="Couto" },
                                new Freguesia {Nome="Eiras e Mei" },
                                new Freguesia {Nome="Gavieira" },
                                new Freguesia {Nome="Gondoriz" },
                                new Freguesia {Nome="Grade e Carralcova" },
                                new Freguesia {Nome="Guilhadeses e Santar" },
                                new Freguesia {Nome="Jolda (Madalena) e Rio Cabr�o" },
                                new Freguesia {Nome="Miranda" },
                                new Freguesia {Nome="Monte Redondo" },
                                new Freguesia {Nome="Oliveira" },
                                new Freguesia {Nome="Pa��" },
                                new Freguesia {Nome="Padreiro (Salvador e Santa Cristina)" },
                                new Freguesia {Nome="Padroso" },
                                new Freguesia {Nome="Portela e Extremo" },
                                new Freguesia {Nome="Prozelo" },
                                new Freguesia {Nome="Rio de Moinhos" },
                                new Freguesia {Nome="Rio Frio" },
                                new Freguesia {Nome="Sabadim" },
                                new Freguesia {Nome="S�o Jorge e Ermelo" },
                                new Freguesia {Nome="S�o Paio de Jolda" },
                                new Freguesia {Nome="Senharei" },
                                new Freguesia {Nome="Sistelo" },
                                new Freguesia {Nome="Soajo" },
                                new Freguesia {Nome="Souto e Taba��" },
                                new Freguesia {Nome="T�vora (Santa Maria e S�o Vicente)" },
                                new Freguesia {Nome="Vale" },
                                new Freguesia {Nome="Vilela, S�o Cosme e S�o Dami�o e S�" }
                            }
                        },
                        new Concelho {
                            Nome = "Caminha" },
                        new Concelho {
                            Nome = "Melga�o" },
                        new Concelho {
                            Nome = "Mon��o" },
                        new Concelho {
                            Nome = "Paredes de Coura" },
                        new Concelho{
                            Nome = "Ponte da Barca",
                            Freguesias = new List<Freguesia>
                            {
                                new Freguesia {Nome="Azias" },
                                new Freguesia {Nome="Boiv�es" },
                                new Freguesia {Nome="Brav�es" },
                                new Freguesia {Nome="Britelo" },
                                new Freguesia {Nome="Crasto, Ruivos e Grovelas" },
                                new Freguesia {Nome="Cuide de Vila Verde" },
                                new Freguesia {Nome="Entre Ambos-os-Rios, Ermida e Germil" },
                                new Freguesia {Nome="Lavradas" },
                                new Freguesia {Nome="Lindoso" },
                                new Freguesia {Nome="Nogueira" },
                                new Freguesia {Nome="Oleiros" },
                                new Freguesia {Nome="Ponte da Barca, Vila Nova de Mu�a e Pa�o Vedro de Magalh�es" },
                                new Freguesia {Nome="Sampriz" },
                                new Freguesia {Nome="Touvedo (S�o Louren�o e Salvador)" },
                                new Freguesia {Nome="S�o Pedro de Vade" },
                                new Freguesia {Nome="S�o Tom� de Vade" },
                                new Freguesia {Nome="Vila Ch� (S�o Jo�o Baptista e Santiago)" }
                            }
                        },
                        new Concelho {
                            Nome = "Ponte de Lima",
                            Freguesias = new List<Freguesia>
                            {
                                new Freguesia {Nome="Anais" },
                                new Freguesia {Nome="Arca e Ponte de Lima" },
                                new Freguesia {Nome="Arcozelo" },
                                new Freguesia {Nome="Ardeg�o, Freixo e Mato" },
                                new Freguesia {Nome="B�rrio e Cep�es" },
                                new Freguesia {Nome="Beiral do Lima" },
                                new Freguesia {Nome="Bertiandos" },
                                new Freguesia {Nome="Boalhosa" },
                                new Freguesia {Nome="Brandara" },
                                new Freguesia {Nome="Caba�os e Fojo Lobal" },
                                new Freguesia {Nome="Cabra��o e Moreira do Lima" },
                                new Freguesia {Nome="Calheiros" },
                                new Freguesia {Nome="Calvelo" },
                                new Freguesia {Nome="Correlh�" },
                                new Freguesia {Nome="Estor�os" },
                                new Freguesia {Nome="Facha" },
                                new Freguesia {Nome="Feitosa" },
                                new Freguesia {Nome="Font�o" },
                                new Freguesia {Nome="Fornelos e Queijada" },
                                new Freguesia {Nome="Friastelas" },
                                new Freguesia {Nome="Gandra" },
                                new Freguesia {Nome="Gemieira" },
                                new Freguesia {Nome="Gondufe" },
                                new Freguesia {Nome="Labruja" },
                                new Freguesia {Nome="Labruj�, Rendufe e Vilar do Monte" },
                                new Freguesia {Nome="Navi� e Vitorino dos Pi�es" },
                                new Freguesia {Nome="Poiares" },
                                new Freguesia {Nome="Refoios do Lima" },
                                new Freguesia {Nome="Ribeira" },
                                new Freguesia {Nome="S�" },
                                new Freguesia {Nome="Santa Comba" },
                                new Freguesia {Nome="Santa Cruz do Lima" },
                                new Freguesia {Nome="Santa Maria de Rebord�es" },
                                new Freguesia {Nome="S�o Pedro d'Arcos" },
                                new Freguesia {Nome="Souto de Rebord�es" },
                                new Freguesia {Nome="Seara" },
                                new Freguesia {Nome="Serdedelo" },
                                new Freguesia {Nome="Vale do Neiva" },
                                new Freguesia {Nome="Vitorino das Donas" }
                            }
                        },
                        new Concelho {
                            Nome = "Valen�a" },
                        new Concelho {Nome = "Viana do Castelo" },
                        new Concelho {Nome = "Vila Nova de Cerveira" }
                    }
                });

        }
    }
}
