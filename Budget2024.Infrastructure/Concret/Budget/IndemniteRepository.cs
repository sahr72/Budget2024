using Budget2024.Core.Abstract.Budget;
using Budget2024.Infrastructure.ModelEntity;

namespace Budget2024.Infrastructure.Concret.Budget
{
    public class IndemniteRepository:GenericRepository<Core.DomainEntities.Indemnite>, IIndemniteRepository
    {
        public IndemniteRepository(AppDbContext context) : base(context)
    {

    }

}
}
