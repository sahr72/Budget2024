using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.DTOs.Budget
{
    public class ChapitreDTO
    {
        public int ChapitreId { get; set; }
        
        [Required(ErrorMessage = "Code obligatoire.")]
        public string CodeChap { get; set; } = null!;
        
        [Required(ErrorMessage = "Description obligataoire.")]
        public string Chapitre1 { get; set; } = null!;

        public int BudgetId { get; set; }
        public string? BudgetDescription { get; set; } 
    }
}
