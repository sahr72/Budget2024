using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.DTOs.Budget
{
    public class ArticleDTO
    {
        public int ArticleId { get; set; }

        public string CodeArt { get; set; } = null!;

        public string Article1 { get; set; } = null!;

        public int ChapitreId { get; set; }

        public decimal EngIni { get; set; }

        public decimal Rattachement { get; set; }

        public decimal Reste { get; set; }
        public string ChapitreDescription { get; set; } = null!;
    }
}
