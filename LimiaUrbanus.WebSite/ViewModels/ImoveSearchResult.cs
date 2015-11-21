using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LimiaUrbanus.WebSite.Models;

namespace LimiaUrbanus.WebSite.ViewModels
{
    public class ImoveSearchResult
    {

        public ImovelSearch Filter { get; set; }

        public List<Imovel> Results { get; set; }

    }
}
