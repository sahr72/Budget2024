using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class LigneCorpsInd
{
    public int IndemniteId { get; set; }

    public int Corps1Id { get; set; }

    public string NatJurRelTrav { get; set; } = null!;

    public virtual Corps1 Corps1 { get; set; } = null!;

    public virtual Indemnite Indemnite { get; set; } = null!;
}
