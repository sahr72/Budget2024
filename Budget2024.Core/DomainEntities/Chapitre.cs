using System;
using System.Collections.Generic;

namespace Budget2024.Core.DomainEntities;

public partial class Chapitre
{
    public int ChapitreId { get; set; }

    public string CodeChap { get; set; } = null!;

    public string Chapitre1 { get; set; } = null!;

    public int BudgetId { get; set; }

    //public virtual ICollection<Article> Articles { get; set; } = new List<Article>();

    //public virtual Budget Budget { get; set; } = null!;

    //public virtual ICollection<LigneMatChap> LigneMatChaps { get; set; } = new List<LigneMatChap>();
}
