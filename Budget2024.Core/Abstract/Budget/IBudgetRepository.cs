using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Core.Abstract.Budget
{
    public interface IBudgetRepository:IGenericRepository<DomainEntities.Budget>
    {
        /* Cette interface gère la logique d'accès aux données.
         * Ne doit contenir que les methodes spécifiques aux entités du modèle du domaine.
         * Elle permet de gérer des opérations spécifiques pour l'entité Budget
         */
        //On peut rajouter d'autres méthodes qui ne sont pas génériques mais plutot spécifiques à cette entité du modèle
        Task<int> GetTotalBudgetRowsAsync();
    }
}
