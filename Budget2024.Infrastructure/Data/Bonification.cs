using System;
using System.Collections.Generic;

namespace Budget2024.Infrastructure.Data;

public partial class Bonification
{
    public int BonificationId { get; set; }

    public int Indice { get; set; }

    public decimal Bon { get; set; }
}
