using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class Indemnite
{
    public int IndemniteId { get; set; }

    public int ArticleId { get; set; }

    public string Sig { get; set; } = null!;

    public string Ind { get; set; } = null!;

    public string? Typ { get; set; }

    public short Mvt { get; set; }

    public string Cal { get; set; } = null!;

    public string Coim { get; set; } = null!;

    public int? Ordre { get; set; }

    public decimal Taux { get; set; }

    public string Beneficiaire { get; set; } = null!;

    public decimal Mt { get; set; }

    public bool SoumisAbs { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual ICollection<LigneCorpsInd> LigneCorpsInds { get; set; } = new List<LigneCorpsInd>();

    public virtual ICollection<LigneIndFil> LigneIndFils { get; set; } = new List<LigneIndFil>();

    public virtual ICollection<LigneIndGrade> LigneIndGrades { get; set; } = new List<LigneIndGrade>();

    public virtual ICollection<LigneIndSb> LigneIndSbs { get; set; } = new List<LigneIndSb>();

    public virtual ICollection<LigneMatCorpsInd> LigneMatCorpsInds { get; set; } = new List<LigneMatCorpsInd>();

    public virtual ICollection<LigneMatIndPeriode> LigneMatIndPeriodes { get; set; } = new List<LigneMatIndPeriode>();

    public virtual ICollection<LigneMatInd> LigneMatInds { get; set; } = new List<LigneMatInd>();
}
