using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Core.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllFilteredAsync(
                Dictionary<string, string>? filters = null,
                Dictionary<string, string>? sortOrder = null,
                int pageNumber = 1,
                int pageSize = 10);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        IQueryable<T> Query(); /* This allows LINQ queries et n'est pas asynchrone car elle est désignée pour retourner 
                                * un IQuerable<TEntity> qui représente une requete qui ne sera pas executée dans la base de données.
                                * Non asynchrone donc execution différée de IEqueryable dont l'execution n'aura lieu que lorsque la requete est énuméréeen appelant 
                                * par exemple ToList(), FirstOrDefault(), ...
                                * Grace au type de retour IQueryable, les clients peuvent composer des requetes additionelles (comme les filtres, joins, tris) avant 
                                * l'execution de la requete.
                                * Exp: var filteredData = await repository.Query()
                                                                          .Where(b => b.Amount > 1000)
                                                                          .ToListAsync();
                                */

        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    }
}
