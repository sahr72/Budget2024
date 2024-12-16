using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class Corps1
{
    public int Corps1Id { get; set; }

    public string Corps { get; set; } = null!;

    public int FiliereId { get; set; }

    public virtual Filiere Filiere { get; set; } = null!;

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual ICollection<LigneCorpsInd> LigneCorpsInds { get; set; } = new List<LigneCorpsInd>();
}
