using System;
using System.Collections.Generic;

namespace Budget2024.Core.DomainEntities
{
    public partial class Article
    {
        public int ArticleId { get; set; }

        public string CodeArt { get; set; } = null!;

        public string Article1 { get; set; } = null!;

        public int ChapitreId { get; set; }

        public decimal EngIni { get; set; }

        public decimal Rattachement { get; set; }

        public decimal Reste { get; set; }

        public virtual Chapitre Chapitre { get; set; } = null!;

        public virtual ICollection<Indemnite> Indemnites { get; set; } = new List<Indemnite>();
    }
}
