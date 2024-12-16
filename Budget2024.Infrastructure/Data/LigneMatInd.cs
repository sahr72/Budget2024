using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class LigneMatInd
{
    public int IndemniteId { get; set; }

    public int TypeMatriceId { get; set; }

    public int? OrdInd { get; set; }

    public int? Page { get; set; }

    public string? Ind { get; set; }

    public string? Mat { get; set; }

    public string? CodeChap { get; set; }

    public string? CodArt { get; set; }

    public decimal? Taux { get; set; }

    public decimal? Mt { get; set; }

    public short? Mvt { get; set; }

    public string? Coim { get; set; }

    public string? Cal { get; set; }

    public string? Beneficiaire { get; set; }

    public bool SoumisAbs { get; set; }

    public int? CleArt { get; set; }

    public int? CleChap { get; set; }

    public float? CleBudget { get; set; }

    public virtual Indemnite Indemnite { get; set; } = null!;

    public virtual TypeMatrix TypeMatrice { get; set; } = null!;
}
