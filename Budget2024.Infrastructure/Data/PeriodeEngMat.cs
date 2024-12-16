using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class PeriodeEngMat
{
    public int PeriodeId { get; set; }

    public string? Aaaa { get; set; }

    public DateTime? Du { get; set; }

    public DateTime? Au { get; set; }

    public int? NbrMois { get; set; }

    public string? Obs { get; set; }

    public virtual ICollection<LigneMatIndPeriode> LigneMatIndPeriodes { get; set; } = new List<LigneMatIndPeriode>();
}
