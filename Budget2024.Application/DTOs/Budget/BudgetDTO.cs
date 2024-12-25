using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.DTOs.Budget
{
    public class BudgetDTO
    {
        public int BudgetId { get; set; }

        public string Code { get; set; } = null!;

        public string Budget1 { get; set; } = null!;

        public string? Obs { get; set; }

       // public virtual ICollection<Chapitre> Chapitres { get; set; } = new List<Chapitre>();
    }
}
