using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class LigneIndGrade
{
    public int IndemniteId { get; set; }

    public int GradeId { get; set; }

    public string NatJurRelTrav { get; set; } = null!;

    public virtual Indemnite Indemnite { get; set; } = null!;
}
