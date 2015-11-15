using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimiaUrbanus.WebSite.Models
{
    public class Concelho
    {
        public int ConcelhoId { get; set; }

        public string Nome { get; set; }

        public int DistritoId { get; set; }

        public virtual Distrito Distrito { get; set; }
    }
}
