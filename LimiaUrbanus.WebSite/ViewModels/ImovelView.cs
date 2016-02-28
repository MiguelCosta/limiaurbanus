using System.Linq;

namespace LimiaUrbanus.WebSite.ViewModels
{
    public class ImovelView
    {
        public ImovelView()
        {
        }

        public ImovelView(Models.Imovel i)
        {
            ImovelId = i.ImovelId;
            Nome = i.Nome;
            Preco = i.Preco;
            // ultima imagem adicionada com imovel e marcada como principal
            Imagem = i.FilePaths.OrderByDescending(x => x.IsPrincipal)
                .ThenByDescending(x => x.FilePathId)
                .FirstOrDefault()?.FileName;
            Objetivo = i.Objetivo.Nome;
            Concelho = i.Freguesia.Concelho.Nome;
            Freguesia = i.Freguesia.Nome;
            Tipo = i.Tipo.Nome;
        }

        public int ImovelId { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public string Imagem { get; set; }

        public string Objetivo { get; set; }

        public string Concelho { get; set; }

        public string Freguesia { get; set; }

        public string Tipo { get; set; }
    }
}
