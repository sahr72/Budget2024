using Budget2024.Core.Abstract.Budget;
using Budget2024.Infrastructure.ModelEntity;

namespace Budget2024.Infrastructure.Concret.Budget
{
    public class ArticleRepository : GenericRepository<Core.DomainEntities.Article>, IArticleRepository
    {
        public ArticleRepository(AppDbContext context) : base(context)
        {

        }

        //public async Task<int> GetTotalBudgetRowsAsync()
        //{
        //    return await Query().CountAsync();
        //}
    }
}
