using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Core.Abstract
{
    public interface IGenericService<TDto, TEntity>
        where TDto : class
        where TEntity : class
    {
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<IEnumerable<TDto>> GetAllFilteredAsync(
                    Dictionary<string, string>? filters = null,
                    Dictionary<string, string>? sortOrder = null,
                    int pageNumber = 1,
                    int pageSize = 10);
        Task<TDto?> GetByIdAsync(int id);
        Task<TDto> AddAsync(TDto dto);
        Task UpdateAsync(int id, TDto dto);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
