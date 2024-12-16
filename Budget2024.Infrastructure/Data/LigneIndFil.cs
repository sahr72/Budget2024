using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class LigneIndFil
{
    public int IndemniteId { get; set; }

    public int FiliereId { get; set; }

    public string NatJurRelTrav { get; set; } = null!;

    public virtual Filiere Filiere { get; set; } = null!;

    public virtual Indemnite Indemnite { get; set; } = null!;
}
