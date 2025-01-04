using Budget2024.Application.DTOs.Budget;
using Budget2024.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.Services.Indemnite
{
    public interface IIndemniteService:IGenericService<IndemniteDTO, Core.DomainEntities.Indemnite>
    {
        // On peut rajouter des méthodes qui n'existent pas dans le GenericService 
        // Dans ce cas, il faudrait que la classe BudgetService implémente la'interface IBudgetService
        // Ne pas oublier d'enregistrer dans le contenaire d'injection de dépendances

        //Task<IEnumerable<BudgetDTO>> GetAllFilteredAsync(
        //Dictionary<string, string>? filters = null,
        //Dictionary<string, string>? sortOrder = null,
        //int pageNumber = 1,
        //int pageSize = 10);
        Task<IEnumerable<IndemniteDTO>> GetAllWithRelatedEntitiesAsync();
    }
}
