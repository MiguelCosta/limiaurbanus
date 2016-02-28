using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LimiaUrbanus.WebSite.Models
{
    /// <summary>
    /// http://www.mikesdotnetting.com/article/259/asp-net-mvc-5-with-ef-6-working-with-files
    /// </summary>
    public class FilePath
    {
        public int FilePathId { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        public FileType FileTye { get; set; }

        public int ImovelId { get; set; }

        public bool IsPrincipal { get; set; }

        public bool IsCapa { get; set; }

        public virtual Imovel Imovel { get; set; }

    }
}
