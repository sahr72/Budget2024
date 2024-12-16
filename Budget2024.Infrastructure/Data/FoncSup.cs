using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class FoncSup
{
    public int FoncSupId { get; set; }

    public string FoncSup1 { get; set; } = null!;

    public string CodeGrad { get; set; } = null!;

    public short? Ordre { get; set; }

    public virtual GrilleSb CodeGradNavigation { get; set; } = null!;
}
