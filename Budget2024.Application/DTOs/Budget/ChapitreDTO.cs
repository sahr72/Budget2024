using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.DTOs.Budget
{
    public class ChapitreDTO
    {
        public int ChapitreId { get; set; }

        public string CodeChap { get; set; } = null!;

        public string Chapitre1 { get; set; } = null!;

        public int BudgetId { get; set; }
        public string BudgetDescription { get; set; } = null!;
    }
}
