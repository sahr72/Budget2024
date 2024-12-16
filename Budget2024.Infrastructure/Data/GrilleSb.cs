using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class GrilleSb
{
    public string Codegrad { get; set; } = null!;

    public string Cat { get; set; } = null!;

    public string Sec { get; set; } = null!;

    public int Indice { get; set; }

    public decimal Sb { get; set; }

    public decimal Icr { get; set; }

    public virtual ICollection<FoncSup> FoncSups { get; set; } = new List<FoncSup>();

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual ICollection<GrilleIep> GrilleIeps { get; set; } = new List<GrilleIep>();
}
