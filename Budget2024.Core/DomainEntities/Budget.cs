using System;
using System.Collections.Generic;

namespace Budget2024.Core.DomainEntities;

public partial class Budget
{
    public int BudgetId { get; set; }

    public string Code { get; set; } = null!;

    public string Budget1 { get; set; } = null!;

    public string? Obs { get; set; }

   // public virtual ICollection<Chapitre> Chapitres { get; set; } = new List<Chapitre>();
}
