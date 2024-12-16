using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class LigneIndSb
{
    public int IndemniteId { get; set; }

    public string CodeGrad { get; set; } = null!;

    public string NatJurRelTrav { get; set; } = null!;

    public virtual Indemnite Indemnite { get; set; } = null!;
}
