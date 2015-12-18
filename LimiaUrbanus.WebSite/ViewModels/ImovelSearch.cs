using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LimiaUrbanus.WebSite.Models;
using LimiaUrbanus.WebSite.ViewModels;

namespace LimiaUrbanus.WebSite.ViewModels
{
    public class ImovelSearch
    {

        public int? ObjetivoId { get; set; }

        public int? TipoId { get; set; }

        public int? EstadoId { get; set; }

        public int? TipologiaMin { get; set; }

        public int? TipologiaMax { get; set; }

        public double? PrecoMin { get; set; }

        public double? PrecoMax { get; set; }

        public int? DistritoId { get; set; }

        public int? ConcelhoId { get; set; }

        public int? FreguesiaId { get; set; }

        public bool IsEmpty => ObjetivoId.HasValue == false
                               && TipoId.HasValue == false
                               && EstadoId.HasValue == false
                               && TipologiaMin.HasValue == false
                               && TipologiaMax.HasValue == false
                               && PrecoMin.HasValue == false
                               && PrecoMax.HasValue == false
                               && DistritoId.HasValue == false
                               && ConcelhoId.HasValue == false
                               && FreguesiaId.HasValue == false;

        public IEnumerable<Imovel> Query(LimiaUrbanusDbContext db)
        {
            try
            {


                var q = db.Imoveis
                    .Include(i => i.FilePaths)
                    .Where(i => i.IsAtivo);
                if(IsEmpty)
                {
                    q = q.Where(i => i.IsOportunidade);
                }
                else
                {
                    if(ObjetivoId.HasValue) q = q.Where(i => i.ObjetivoId == ObjetivoId.Value);
                    if(TipoId.HasValue) q = q.Where(i => i.TipoId == TipoId.Value);
                    if(EstadoId.HasValue) q = q.Where(i => i.EstadoId == EstadoId.Value);
                    if(TipologiaMin.HasValue)
                    {
                        var t = db.Tipologias.Find(TipologiaMin.Value);
                        q = q.Where(i => i.Tipologia.Ordem >= t.Ordem);
                    }
                    if(TipologiaMax.HasValue)
                    {
                        var t = db.Tipologias.Find(TipologiaMax.Value);
                        q = q.Where(i => i.Tipologia.Ordem <= t.Ordem);
                    }
                    if(PrecoMin.HasValue) q = q.Where(i => i.Preco >= PrecoMin.Value);
                    if(PrecoMax.HasValue) q = q.Where(i => i.Preco <= PrecoMax.Value);
                    if(DistritoId.HasValue) q = q.Where(i => i.Freguesia.Concelho.DistritoId == DistritoId.Value);
                    if(ConcelhoId.HasValue) q = q.Where(i => i.Freguesia.ConcelhoId == ConcelhoId.Value);
                    if(FreguesiaId.HasValue) q = q.Where(i => i.FreguesiaId == FreguesiaId.Value);
                }
                return q;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
