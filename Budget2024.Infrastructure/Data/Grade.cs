using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class Grade
{
    public int GradeId { get; set; }

    public string CodeGrad { get; set; } = null!;

    public short Ordre { get; set; }

    public string Grade1 { get; set; } = null!;

    public int Corps1Id { get; set; }

    public string? Cat { get; set; }

    public string? Sec { get; set; }

    public int IndiceMin { get; set; }

    public string? Cat311207 { get; set; }

    public string? Sec311207 { get; set; }

    public string? IndiceMin311207 { get; set; }

    public virtual GrilleSb CodeGradNavigation { get; set; } = null!;

    public virtual Corps1 Corps1 { get; set; } = null!;

    public virtual ICollection<TypeMatrix> TypeMatrices { get; set; } = new List<TypeMatrix>();
}
