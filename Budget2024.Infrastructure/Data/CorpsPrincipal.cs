using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class CorpsPrincipal
{
    public int CorpsPrincipalId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Filiere> Filieres { get; set; } = new List<Filiere>();
}
