using Budget2024.Core.Abstract.Budget;
using Budget2024.Infrastructure.ModelEntity;
using Microsoft.EntityFrameworkCore;

namespace Budget2024.Infrastructure.Concret.Budget
{
    public class BudgetRepository : GenericRepository<Core.DomainEntities.Budget>, IBudgetRepository
    {
        //private readonly AppDbContext _context;
        //private readonly DbSet<Data.Budget> _budgetDbSet;

        public BudgetRepository(AppDbContext context):base(context) {
            //_context = context;
            //_budgetDbSet = context.Set<Data.Budget>();
        }

        public async Task<int> GetTotalBudgetRowsAsync()
        {
            return await Query().CountAsync();
        }

        //public Task  AddAsync(Core.DomainEntities.Budget entity)
        //{
        //   // Appliquer des validations sur les attributs non null
        //        //     if (entity == null) throw new ArgumentNullException(nameof(Core.DomainEntities.Budget), "Budget object cannot be null.");

        //   // if (string.IsNullOrWhiteSpace(entity.Budget1)) throw new ArgumentException("Budget description cannot be null or empty.", nameof(Core.DomainEntities.Budget));

        //    var obj = new Data.Budget
        //    {
        //        BudgetId = entity.BudgetId,
        //        Code = entity.Code,
        //        Budget1 = entity.Budget1,
        //        Obs = entity.Obs
        //    };

        //    await _context.Budgets.AddAsync(obj);
        //    await _context.SaveChangesAsync();
        //}

        
    }
        //public class BudgetRepository : IGenericRepository<Data.Budget> , IBudgetRepository
        //{
        //    private readonly AppDbContext _context;
        //    private readonly DbSet<Data.Budget> _dbSet;

        //    public BudgetRepository(AppDbContext context) {       
        //        _context = context;
        //        _dbSet = context.Set<Data.Budget>();
        //    }

        //    /*
        //     * Cette classe hérite des méthodes génériques de la classe GenericRepository<Data.Budget> 
        //     * pour implémenter les opérations CRUD génériques.
        //     * Elle implémente aussi l'interface IBudgetRepository pour gérer les opérations spécifiques au domaine
        //     * Elle assure le mappage des entités du domaine vers les entités du modele pour éffectuer les opérations de base de données.
        //     * N'a aucune affire avec les DTOs. Le repository ne doit jamais retourné un DTO directement. Il doit retourner une entité du domaine
        //     * On peut appliquer des validations sur les attributs non null
        //     */

        //    //Méthode spécifique de IBudgetRepository et non générique
        //    public async Task<int> GetTotalBudgetRowsAsync()
        //    {
        //        return await _context.Budgets.CountAsync();
        //    }

        //    //Ensemble de méthodes génériques
        //    public async Task<IEnumerable<Data.Budget>> GetAllAsync()
        //    {
        //        return await _dbSet.ToListAsync();
        //    }

        //    public async Task<Data.Budget?> GetByIdAsync(int id)
        //    {
        //        return await _dbSet.FindAsync(id);
        //    }

        //    public async Task AddAsync(Data.Budget entity)
        //    {
        //        await _dbSet.AddAsync(entity);
        //        await _context.SaveChangesAsync();
        //    }

        //    public async Task UpdateAsync(Data.Budget entity)
        //    {
        //        _dbSet.Update(entity);
        //        await _context.SaveChangesAsync();
        //    }

        //    public async Task DeleteAsync(Data.Budget entity)
        //    {
        //        _dbSet.Remove(entity);
        //        await _context.SaveChangesAsync();
        //    }

        //    public  IQueryable<Data.Budget> Query()
        //    {
        //        return _dbSet.AsQueryable();
        //    }





        //    IQueryable<Core.DomainEntities.Budget> IGenericRepository<Core.DomainEntities.Budget>.Query()
        //    {
        //        throw new NotImplementedException();
        //    }


        //    /********/


        //    // Opération d'ajout pour le modèle du domaine Core.DomainEntities.Budget
        //    /* public async Task AddObjAsync(Core.DomainEntities.Budget obj)
        //     {
        //         // Appliquer des validations sur les attributs non null
        //         if (obj == null) throw new ArgumentNullException(nameof(Core.DomainEntities.Budget), "Budget object cannot be null.");

        //         if (string.IsNullOrWhiteSpace(obj.Budget1)) throw new ArgumentException("Budget description cannot be null or empty.", nameof(Core.DomainEntities.Budget));

        //         var entity = new Data.Budget
        //         {
        //             BudgetId = obj.BudgetId,
        //             Code = obj.Code,
        //             Budget1 = obj.Budget1,
        //             Obs = obj.Obs
        //         };

        //         await _context.Budgets.AddAsync(entity);
        //         await _context.SaveChangesAsync();
        //     }



        //     public async Task DeleteObjAsync(int id)
        //     {
        //         var entity = await _context.Budgets.FindAsync(id);
        //         if (entity != null)
        //         {
        //             _context.Budgets.Remove(entity);
        //             await _context.SaveChangesAsync();
        //         }
        //     }

        //     public async Task<Core.DomainEntities.Budget> GetObjByIdAsync(int id)
        //     {
        //         var entity = await _context.Budgets.FindAsync(id);
        //         return entity != null
        //             ? new Core.DomainEntities.Budget
        //             {
        //                 BudgetId = entity.BudgetId,
        //                 Code = entity.Code,
        //                 Budget1 = entity.Budget1,
        //                 Obs = entity.Obs
        //             }
        //             : null!;
        //     }



        //     public async Task UpdateObjAsync(Core.DomainEntities.Budget obj)
        //     {
        //         var existing = await _context.Budgets.FindAsync(obj.BudgetId);
        //         if (existing != null)
        //         {
        //             existing.Code = obj.Code;
        //             existing.Budget1 = obj.Budget1;
        //             existing.Obs = obj.Obs;

        //             _context.Budgets.Update(existing);
        //             await _context.SaveChangesAsync();
        //         }
        //     }


        //     public async Task<IEnumerable<Core.DomainEntities.Budget>> GetAllObjAsync()
        //     {
        //         var entities = await _context.Budgets.ToListAsync();
        //         return entities.Select(e => new Core.DomainEntities.Budget
        //         {
        //             BudgetId = e.BudgetId,
        //             Code = e.Code,
        //             Budget1 = e.Budget1,
        //             Obs = e.Obs
        //         });
        //     }

        //    */


        //    //public class BudgetRepository : GenericRepository<Data.Budget>, IBudgetRepository
        //    //{
        //    //    private readonly AppDbContext _context;
        //    //    public BudgetRepository(AppDbContext context) : base(context)
        //    //    {
        //    //        _context = context;
        //    //    }

        //    //    /*
        //    //     * Cette classe hérite des méthodes génériques de la classe GenericRepository<Data.Budget> 
        //    //     * pour implémenter les opérations CRUD génériques.
        //    //     * Elle implémente aussi l'interface IBudgetRepository pour gérer les opérations spécifiques au domaine
        //    //     * Elle assure le mappage des entités du domaine vers les entités du modele pour éffectuer les opérations de base de données.
        //    //     * N'a aucune affire avec les DTOs. Le repository ne doit jamais retourné un DTO directement. Il doit retourner une entité du domaine
        //    //     * On peut appliquer des validations sur les attributs non null
        //    //     */


        //    //    // Opération d'ajout pour le modèle du domaine Core.DomainEntities.Budget
        //    //    public async Task AddObjAsync(Core.DomainEntities.Budget obj)
        //    //    {
        //    //        /* Appliquer des validations sur les attributs non null*/
        //    //        if (obj == null) throw new ArgumentNullException(nameof(Core.DomainEntities.Budget), "Budget object cannot be null.");

        //    //        if (string.IsNullOrWhiteSpace(obj.Budget1)) throw new ArgumentException("Budget description cannot be null or empty.", nameof(Core.DomainEntities.Budget));

        //    //        var entity = new Data.Budget
        //    //        {
        //    //            BudgetId = obj.BudgetId,
        //    //            Code = obj.Code,
        //    //            Budget1 = obj.Budget1,
        //    //            Obs = obj.Obs
        //    //        };

        //    //        await _context.Budgets.AddAsync(entity);
        //    //        await _context.SaveChangesAsync();
        //    //    }



        //    //    public async Task DeleteObjAsync(int id)
        //    //    {
        //    //        var entity = await _context.Budgets.FindAsync(id);
        //    //        if (entity != null)
        //    //        {
        //    //            _context.Budgets.Remove(entity);
        //    //            await _context.SaveChangesAsync();
        //    //        }
        //    //    }

        //    //    public async Task<Core.DomainEntities.Budget> GetObjByIdAsync(int id)
        //    //    {
        //    //        var entity = await _context.Budgets.FindAsync(id);
        //    //        return entity != null
        //    //            ? new Core.DomainEntities.Budget
        //    //            {
        //    //                BudgetId = entity.BudgetId,
        //    //                Code = entity.Code,
        //    //                Budget1 = entity.Budget1,
        //    //                Obs = entity.Obs
        //    //            }
        //    //            : null!;
        //    //    }



        //    //    public async Task UpdateObjAsync(Core.DomainEntities.Budget obj)
        //    //    {
        //    //        var existing = await _context.Budgets.FindAsync(obj.BudgetId);
        //    //        if (existing != null)
        //    //        {
        //    //            existing.Code = obj.Code;
        //    //            existing.Budget1 = obj.Budget1;
        //    //            existing.Obs = obj.Obs;

        //    //            _context.Budgets.Update(existing);
        //    //            await _context.SaveChangesAsync();
        //    //        }
        //    //    }


        //    //    public async Task<IEnumerable<Core.DomainEntities.Budget>> GetAllObjAsync()
        //    //    {
        //    //        var entities = await _context.Budgets.ToListAsync();
        //    //        return entities.Select(e => new Core.DomainEntities.Budget
        //    //        {
        //    //            BudgetId = e.BudgetId,
        //    //            Code = e.Code,
        //    //            Budget1 = e.Budget1,
        //    //            Obs = e.Obs
        //    //        });
        //    //    }

        //    //private readonly IMapper _mapper;

        //    //public BudgetRepository(AppDbContext context, IAdHocMapper mapper): base(context,mapper)
        //    //{
        //    //    _context= context;
        //    //    _mapper= mapper;
        //    //}
        //    //public async Task AddAsync(Data.Budget entity)
        //    //{
        //    //    //Appliquer des validations sur les attributs non null
        //    //    /*
        //    //     *  if (student == null) throw new ArgumentNullException(nameof(student), "Student object cannot be null.");

        //    //        if (string.IsNullOrWhiteSpace(student.Name)) throw new ArgumentException("Student name cannot be null or empty.", nameof(student));
        //    //     */

        //    //    await _context.Budgets.AddAsync(entity);
        //    //    await _context.SaveChangesAsync();
        //    //}

        //    //public async Task Delete(Data.Budget entity)
        //    //{
        //    //    var obj = await _context.Budgets.FindAsync(id);
        //    //    if (obj != null)
        //    //    {
        //    //        _context.Budgets.Remove(obj);
        //    //        await _context.SaveChangesAsync();
        //    //    }
        //    //}

        //    //public async void Update(Data.Budget entity)
        //    //{
        //    //    _context.Budgets.Update(entity);
        //    //    await _context.SaveChangesAsync();
        //    //}

        //    //public async Task<IEnumerable<Data.Budget>> IGenericRepository<Data.Budget>.GetAllAsync()
        //    //{
        //    //    throw new NotImplementedException();
        //    //}

        //    //Task<Data.Budget?> IGenericRepository<Data.Budget>.GetByIdAsync(int id)
        //    //{
        //    //    throw new NotImplementedException();
        //    //}

        //    //Task<Core.DomainEntities.Budget?> IGenericRepository<Core.DomainEntities.Budget>.GetByIdAsync(int id)
        //    //{
        //    //    throw new NotImplementedException();
        //    //}

        //    //Task<IEnumerable<Core.DomainEntities.Budget>> IGenericRepository<Core.DomainEntities.Budget>.GetAllAsync()
        //    //{
        //    //    throw new NotImplementedException();
        //    //}

        //    //public Task AddAsync(Core.DomainEntities.Budget entity)
        //    //{
        //    //    throw new NotImplementedException();
        //    //}

        //    //public void Update(Core.DomainEntities.Budget entity)
        //    //{
        //    //    throw new NotImplementedException();
        //    //}

        //    //public void Delete(Core.DomainEntities.Budget entity)
        //    //{
        //    //    var obj = await _context.Budgets.FindAsync(id);
        //    //    if (obj != null)
        //    //    {
        //    //        _context.Budgets.Remove(obj);
        //    //        await _context.SaveChangesAsync();
        //    //    }
        //    //}
        //}
    }
