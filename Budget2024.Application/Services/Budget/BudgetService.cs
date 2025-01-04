using AutoMapper;
using Budget2024.Application.DTOs.Budget;
using Budget2024.Application.Services.Budget;
using Budget2024.Core.Abstract;

namespace Budget2024.Application.Services;

public class BudgetService: IBudgetService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public BudgetService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<BudgetDTO>> GetAllAsync()
    {
        var entities = await _unitOfWork.Repository<Infrastructure.Data.Budget>().GetAllAsync();
        return _mapper.Map<IEnumerable<BudgetDTO>>(entities);

        //return await _unitOfWork.Repository<Core.DomainEntities.Budget>()
        //                        .Query()
        //                        .Select(s => new BudgetDTO
        //                        {
        //                            BudgetId = s.BudgetId,
        //                            Code = s.Code,
        //                            Budget1 = s.Budget1
        //                        })
        //                        .ToListAsync();
    }


    public async Task<BudgetDTO?> GetByIdAsync(int id)
    {
        var entite = await _unitOfWork.Repository<Infrastructure.Data.Budget>().GetByIdAsync(id);
        return entite == null ? null : _mapper.Map<BudgetDTO>(entite);
    }
    public async Task<BudgetDTO> AddAsync(BudgetDTO dto)
    {
        var entite = _mapper.Map<Infrastructure.Data.Budget>(dto);
        await _unitOfWork.Repository<Infrastructure.Data.Budget>().AddAsync(entite);
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<BudgetDTO>(dto);
    }
    public async Task UpdateAsync(int id, BudgetDTO dto)
    {
        var entite = _mapper.Map<Infrastructure.Data.Budget>(dto);
        //var x=_unitOfWork.Repository<Core.DomainEntities.Budget>().GetByIdAsync<int>(id);
        await _unitOfWork.Repository<Infrastructure.Data.Budget>().UpdateAsync(entite);
        await _unitOfWork.SaveChangesAsync();

    }

    public async Task DeleteAsync(int id)
    {
        var entite = await _unitOfWork.Repository<Infrastructure.Data.Budget>().GetByIdAsync(id);
        if (entite != null)
        {
            await _unitOfWork.Repository<Infrastructure.Data.Budget>().DeleteAsync(entite);
            await _unitOfWork.SaveChangesAsync();
        }
    }
     

    public async Task<bool> ExistsAsync(int id)
    {
        var entite = await _unitOfWork.Repository<Infrastructure.Data.Budget>().GetByIdAsync(id);
        if (entite != null) return true;
        return false;
    }

    public async Task<IEnumerable<BudgetDTO>> GetAllFilteredAsync(
        Dictionary<string, string>? filters = null,
        Dictionary<string, string>? sortOrder = null,
        int pageNumber = 1,
        int pageSize = 10)
    {
        var entities = await _unitOfWork.Repository<Infrastructure.Data.Budget>().GetAllFilteredAsync(filters, sortOrder, pageNumber, pageSize);
        return _mapper.Map<IEnumerable<BudgetDTO>>(entities);
    }
}
//public class BudgetService : GenericService<BudgetDTO, Core.DomainEntities.Budget>, IGenericService<BudgetDTO, Core.DomainEntities.Budget>
//{
//    /* Cette classe permet de gèrer l'orchestration et la logique d'affaire, 
//     *   assurant l'interaction correcte entre les différentes couches de l'application.
//     * Ses méthodes Get ne retournent que des DTOs  
//     * Ici le mappage se fera:
//     *    1. des DTOs vers les entités du domaine pour la logique d'affaire interne
//     *    2. des entités du domaine vers les DTOs avant de retourner les données au controlleurs ou à la couche API.
//     * IBudgetRepository: Cette interface gère la logique d'accès aux données.
//     * IMapper: gère le mappage entre les DTOs et les entités du domaine.
//     * 
//     */
//    private readonly IBudgetRepository _repository;
//    private readonly IMapper _mapper;
//    public BudgetService(IGenericRepository<Core.DomainEntities.Budget> repository, IMapper mapper) : base(repository, mapper)
//    {
//        _repository = repository;
//        _mapper = mapper;
//    }
//    public async Task<BudgetDTO> AddAsync(BudgetDTO dto)
//    {
//        var domainEntity = _mapper.Map<Core.DomainEntities.Budget>(dto);

//        // Call repository to save the Domain Entity
//        await _repository.AddObjAsync(domainEntity);
//        return _mapper.Map<BudgetDTO>(domainEntity);
//    }

//    public async Task DeleteAsync(int id)
//    {
//        var domainEntity = await _repository.GetObjByIdAsync(id);
//        if (domainEntity == null)
//        {
//            // Handle entity not found case (throw exception or return a result)
//            throw new KeyNotFoundException($"Entity with ID {id} not found.");
//        }

//        await _repository.DeleteObjAsync(id);
//    }

//    public async Task<bool> ExistsAsync(int id)
//    {
//        // Call the repository to check if the Budget exists by ID
//        var budget = await _repository.GetObjByIdAsync(id);

//        // Return true if the budget exists, otherwise false
//        return budget != null;
//    }

//    public async Task<IEnumerable<BudgetDTO>> GetAllAsync()
//    {
//        var entities = await _repository.GetAllObjAsync();
//        return _mapper.Map<IEnumerable<BudgetDTO>>(entities);
//    }

//    public async Task<BudgetDTO?> GetByIdAsync(int id)
//    {
//        var entity = await _repository.GetObjByIdAsync(id);
//        return entity != null ? _mapper.Map<BudgetDTO>(entity) : null;
//    }

//    public async Task UpdateAsync(int id, BudgetDTO dto)
//    {
//        var entity = await _repository.GetObjByIdAsync(id);
//        if (entity == null)
//        {
//            // Handle entity not found case (throw exception or return a result)
//            throw new KeyNotFoundException($"Entity with ID {id} not found.");
//        }

//        // Map updated data from DTO to the entity
//        _mapper.Map(dto, entity);

//        // Call repository to update the entity
//        await _repository.UpdateObjAsync(entity);
//    }
//}
//public class BudgetService : IBudgetService
//{   /* Cette classe permet de gèrer l'orchestration et la logique d'affaire, 
//     *   assurant l'interaction correcte entre les différentes couches de l'application.
//     * Ses méthodes Get ne retournent que des DTOs  
//     * Ici le mappage se fera:
//     *    1. des DTOs vers les entités du domaine pour la logique d'affaire interne
//     *    2. des entités du domaine vers les DTOs avant de retourner les données au controlleurs ou à la couche API.
//     * IBudgetRepository: Cette interface gère la logique d'accès aux données.
//     * IMapper: gère le mappage entre les DTOs et les entités du domaine.
//     * 
//     */
//    private readonly IBudgetRepository _budgetRepository;
//    private readonly IMapper _mapper;
//    public BudgetService(IBudgetRepository budgetRepository, IMapper mapper)
//    {
//        _budgetRepository = budgetRepository;
//        _mapper = mapper;
//    }

//    public async Task AddAsync(BudgetDTO entity)
//    {
//        var domainBudget = _mapper.Map<Core.DomainEntities.Budget>(entity);

//        // Call repository to save the Domain Entity
//        await _budgetRepository.AddObjAsync(domainBudget);
//    }

//    public async Task DeleteAsync(int id)
//    {
//        await _budgetRepository.DeleteObjAsync(id);
//    }



//    public async Task<IEnumerable<BudgetDTO>> GetAllAsync()
//    {
//        var domainBudgets = await _budgetRepository.GetAllObjAsync();

//        // Map Domain Entities to DTOs
//        return _mapper.Map<IEnumerable<BudgetDTO>>(domainBudgets);
//    }

//    public async Task<BudgetDTO?> GetByIdAsync(int id)
//    {
//        // Fetch Domain Entity by ID
//        var domainBudget = await _budgetRepository.GetObjByIdAsync(id);

//        // Map Domain Entity to DTO
//        return domainBudget != null
//            ? _mapper.Map<BudgetDTO>(domainBudget)
//            : null;
//    }

//    public async Task UpdateAsync(BudgetDTO entity)
//    {
//        // Map DTO to Domain Entity
//        var domainBudget = _mapper.Map<Core.DomainEntities.Budget>(entity);

//        // Call repository to update the Domain Entity
//        await _budgetRepository.UpdateObjAsync(domainBudget);
//    }



//}
