using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LimiaUrbanus.WebSite.Models
{
    public class Imovel
    {
        public int ImovelId { get; set; }

        public string Nome { get; set; }

        public string Referencia { get; set; }

        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Descricao { get; set; }

        public int TipoId { get; set; }

        public int EstadoId { get; set; }

        public int FreguesiaId { get; set; }

        [DataType(DataType.MultilineText)]
        public string Morada { get; set; }

        public string CoordenadasGps { get; set; }

        public int ObjetivoId { get; set; }

        public int? ClasseEnergeticaId { get; set; }

        public double Area { get; set; }

        public int? Wc { get; set; }

        public int? TipologiaId { get; set; }

        public double Preco { get; set; }

        public string ContactoResponsavel { get; set; }

        public bool IsAtivo { get; set; } = true;

        public bool IsDestaque { get; set; }

        public bool IsOportunidade { get; set; }

        public virtual Tipo Tipo { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual Freguesia Freguesia { get; set; }

        public virtual Objetivo Objetivo { get; set; }

        public virtual ClasseEnergetica ClasseEnergetica { get; set; }

        public virtual Tipologia Tipologia { get; set; }

        public virtual ICollection<FilePath> FilePaths { get; set; }

    }
}
