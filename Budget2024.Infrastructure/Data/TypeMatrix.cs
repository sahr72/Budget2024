using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class TypeMatrix
{
    public int TypeMatriceId { get; set; }

    public string CodeMat { get; set; } = null!;

    public string Matrice { get; set; } = null!;

    public int Beneficiaire { get; set; }

    public string? CodChapSal { get; set; }

    public string? CodChapInd { get; set; }

    public string? CodChapAf { get; set; }

    public string? Budget { get; set; }

    public bool SoumisTitrePer { get; set; }

    public string CalcAbsBrutNetTitre { get; set; } = null!;

    public float? NbJourHeureMois { get; set; }

    public string CotImp { get; set; } = null!;

    public string GroupePayePar { get; set; } = null!;

    public string? ExeAct { get; set; }

    public short? OrdreAct { get; set; }

    public virtual ICollection<LigneMatChap> LigneMatChaps { get; set; } = new List<LigneMatChap>();

    public virtual ICollection<LigneMatCorpsInd> LigneMatCorpsInds { get; set; } = new List<LigneMatCorpsInd>();

    public virtual ICollection<LigneMatIndPeriode> LigneMatIndPeriodes { get; set; } = new List<LigneMatIndPeriode>();

    public virtual ICollection<LigneMatInd> LigneMatInds { get; set; } = new List<LigneMatInd>();

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
