using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class PosteSup
{
    public int PosteSupId { get; set; }

    public string PosteSup1 { get; set; } = null!;

    public int FiliereId { get; set; }

    public int BonificationId { get; set; }

    public string? TypePoste { get; set; }

    public short? Ordre { get; set; }

    public virtual Filiere Filiere { get; set; } = null!;
}
