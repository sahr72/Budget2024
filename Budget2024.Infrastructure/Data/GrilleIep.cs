using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class GrilleIep
{
    public string Codegrad { get; set; } = null!;

    public string Echelon { get; set; } = null!;

    public decimal Iep { get; set; }

    public int? Note { get; set; }

    public decimal? Iepp { get; set; }

    public virtual GrilleSb CodegradNavigation { get; set; } = null!;
}
