﻿using Budget2024.Application.DTOs.Budget;
using Budget2024.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.Services.Chapitre
{
    public interface IChapitreService:IGenericService<ChapitreDTO, Core.DomainEntities.Chapitre>
    {
        Task<IEnumerable<ChapitreDTO>> GetAllChapitreByBudgetAsync(int budgetId);
    }
}
