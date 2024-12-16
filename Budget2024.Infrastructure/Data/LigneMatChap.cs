using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class LigneMatChap
{
    public int TypeMatriceId { get; set; }

    public int ChapitreId { get; set; }

    public int? OrdChap { get; set; }

    public string? TypeChap { get; set; }

    public decimal? MtEngag { get; set; }

    public virtual Chapitre Chapitre { get; set; } = null!;

    public virtual TypeMatrix TypeMatrice { get; set; } = null!;
}
