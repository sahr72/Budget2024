using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class Filiere
{
    public int FiliereId { get; set; }

    public string Filiere1 { get; set; } = null!;

    public int CorpsPincipalId { get; set; }

    public virtual ICollection<Corps1> Corps1s { get; set; } = new List<Corps1>();

    public virtual CorpsPrincipal CorpsPincipal { get; set; } = null!;

    public virtual ICollection<LigneIndFil> LigneIndFils { get; set; } = new List<LigneIndFil>();

    public virtual ICollection<PosteSup> PosteSups { get; set; } = new List<PosteSup>();
}
