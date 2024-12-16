using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class LigneMatIndPeriode
{
    public int IndemniteId { get; set; }

    public int TypeMatriceId { get; set; }

    public int PeriodeId { get; set; }

    public int? OrdInd { get; set; }

    public virtual Indemnite Indemnite { get; set; } = null!;

    public virtual PeriodeEngMat Periode { get; set; } = null!;

    public virtual TypeMatrix TypeMatrice { get; set; } = null!;
}
