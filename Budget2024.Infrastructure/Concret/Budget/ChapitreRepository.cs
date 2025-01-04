using Budget2024.Core.Abstract.Budget;
using Budget2024.Infrastructure.ModelEntity;


namespace Budget2024.Infrastructure.Concret.Budget
{
    public class ChapitreRepository: GenericRepository<Core.DomainEntities.Chapitre>, IChapitreRepository
    {
        public ChapitreRepository(AppDbContext context) : base(context)
        {
            
        }

        //public async Task<int> GetTotalBudgetRowsAsync()
        //{
        //    return await Query().CountAsync();
        //}
    }
}
