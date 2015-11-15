
using System.Collections.Generic;

namespace LimiaUrbanus.WebSite.Models
{
    public class Distrito
    {
        public int DistritoId { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Concelho> Concelhos { get; set; }
    }
}
