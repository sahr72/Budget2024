using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class LigneMatCorpsInd
{
    public int CleMat { get; set; }

    public int CleCorps { get; set; }

    public int CleInd { get; set; }

    public virtual Indemnite CleIndNavigation { get; set; } = null!;

    public virtual TypeMatrix CleMatNavigation { get; set; } = null!;
}
