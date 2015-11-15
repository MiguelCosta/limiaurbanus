using System.Collections.Generic;

namespace LimiaUrbanus.WebSite.Models
{
    public class Concelho
    {
        public int ConcelhoId { get; set; }

        public string Nome { get; set; }

        public int DistritoId { get; set; }

        public virtual Distrito Distrito { get; set; }

        public virtual ICollection<Freguesia> Freguesias { get; set; }
    }
}
