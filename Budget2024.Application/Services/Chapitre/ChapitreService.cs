using AutoMapper;
using Budget2024.Application.DTOs.Budget;
using Budget2024.Application.Services.Budget;
using Budget2024.Application.Services.Chapitre;
using Budget2024.Core.Abstract;

namespace Budget2024.Application.Services;

public class ChapitreService : IChapitreService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public ChapitreService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ChapitreDTO>> GetAllAsync()
    {
        var entities = await _unitOfWork.Repository<Infrastructure.Data.Chapitre>().GetAllAsync();
        return _mapper.Map<IEnumerable<ChapitreDTO>>(entities);

        //return await _unitOfWork.Repository<Core.DomainEntities.Chapitre>()
        //                        .Query()
        //                        .Select(s => new ChapitreDTO
        //                        {
        //                            ChapitreId = s.ChapitreId,
        //                            Code = s.Code,
        //                            Chapitre1 = s.Chapitre1
        //                        })
        //                        .ToListAsync();
    }


    public async Task<ChapitreDTO?> GetByIdAsync(int id)
    {
        var entite = await _unitOfWork.Repository<Infrastructure.Data.Chapitre>().GetByIdAsync(id);
        return entite == null ? null : _mapper.Map<ChapitreDTO>(entite);
    }
    public async Task<ChapitreDTO> AddAsync(ChapitreDTO dto)
    {
        var entite = _mapper.Map<Infrastructure.Data.Chapitre>(dto);
        await _unitOfWork.Repository<Infrastructure.Data.Chapitre>().AddAsync(entite);
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<ChapitreDTO>(dto);
    }
    public async Task UpdateAsync(int id, ChapitreDTO dto)
    {
        var entite = _mapper.Map<Infrastructure.Data.Chapitre>(dto);
        //var x=_unitOfWork.Repository<Core.DomainEntities.Chapitre>().GetByIdAsync<int>(id);
        await _unitOfWork.Repository<Infrastructure.Data.Chapitre>().UpdateAsync(entite);
        await _unitOfWork.SaveChangesAsync();

    }

    public async Task DeleteAsync(int id)
    {
        var entite = await _unitOfWork.Repository<Infrastructure.Data.Chapitre>().GetByIdAsync(id);
        if (entite != null)
        {
            await _unitOfWork.Repository<Infrastructure.Data.Chapitre>().DeleteAsync(entite);
            await _unitOfWork.SaveChangesAsync();
        }
    }


    public async Task<bool> ExistsAsync(int id)
    {
        var entite = await _unitOfWork.Repository<Infrastructure.Data.Chapitre>().GetByIdAsync(id);
        if (entite != null) return true;
        return false;
    }

    public async Task<IEnumerable<ChapitreDTO>> GetAllFilteredAsync(
        Dictionary<string, string>? filters = null,
        Dictionary<string, string>? sortOrder = null,
        int pageNumber = 1,
        int pageSize = 10)
    {
        var entities = await _unitOfWork.Repository<Infrastructure.Data.Chapitre>().GetAllFilteredAsync(filters, sortOrder, pageNumber, pageSize);
        return _mapper.Map<IEnumerable<ChapitreDTO>>(entities);
    }
}
//public class ChapitreService : GenericService<ChapitreDTO, Core.DomainEntities.Chapitre>, IGenericService<ChapitreDTO, Core.DomainEntities.Chapitre>
//{
//    /* Cette classe permet de gèrer l'orchestration et la logique d'affaire, 
//     *   assurant l'interaction correcte entre les différentes couches de l'application.
//     * Ses méthodes Get ne retournent que des DTOs  
//     * Ici le mappage se fera:
//     *    1. des DTOs vers les entités du domaine pour la logique d'affaire interne
//     *    2. des entités du domaine vers les DTOs avant de retourner les données au controlleurs ou à la couche API.
//     * IChapitreRepository: Cette interface gère la logique d'accès aux données.
//     * IMapper: gère le mappage entre les DTOs et les entités du domaine.
//     * 
//     */
//    private readonly IChapitreRepository _repository;
//    private readonly IMapper _mapper;
//    public ChapitreService(IGenericRepository<Core.DomainEntities.Chapitre> repository, IMapper mapper) : base(repository, mapper)
//    {
//        _repository = repository;
//        _mapper = mapper;
//    }
//    public async Task<ChapitreDTO> AddAsync(ChapitreDTO dto)
//    {
//        var domainEntity = _mapper.Map<Core.DomainEntities.Chapitre>(dto);

//        // Call repository to save the Domain Entity
//        await _repository.AddObjAsync(domainEntity);
//        return _mapper.Map<ChapitreDTO>(domainEntity);
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
//        // Call the repository to check if the Chapitre exists by ID
//        var Chapitre = await _repository.GetObjByIdAsync(id);

//        // Return true if the Chapitre exists, otherwise false
//        return Chapitre != null;
//    }

//    public async Task<IEnumerable<ChapitreDTO>> GetAllAsync()
//    {
//        var entities = await _repository.GetAllObjAsync();
//        return _mapper.Map<IEnumerable<ChapitreDTO>>(entities);
//    }

//    public async Task<ChapitreDTO?> GetByIdAsync(int id)
//    {
//        var entity = await _repository.GetObjByIdAsync(id);
//        return entity != null ? _mapper.Map<ChapitreDTO>(entity) : null;
//    }

//    public async Task UpdateAsync(int id, ChapitreDTO dto)
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
//public class ChapitreService : IChapitreService
//{   /* Cette classe permet de gèrer l'orchestration et la logique d'affaire, 
//     *   assurant l'interaction correcte entre les différentes couches de l'application.
//     * Ses méthodes Get ne retournent que des DTOs  
//     * Ici le mappage se fera:
//     *    1. des DTOs vers les entités du domaine pour la logique d'affaire interne
//     *    2. des entités du domaine vers les DTOs avant de retourner les données au controlleurs ou à la couche API.
//     * IChapitreRepository: Cette interface gère la logique d'accès aux données.
//     * IMapper: gère le mappage entre les DTOs et les entités du domaine.
//     * 
//     */
//    private readonly IChapitreRepository _ChapitreRepository;
//    private readonly IMapper _mapper;
//    public ChapitreService(IChapitreRepository ChapitreRepository, IMapper mapper)
//    {
//        _ChapitreRepository = ChapitreRepository;
//        _mapper = mapper;
//    }

//    public async Task AddAsync(ChapitreDTO entity)
//    {
//        var domainChapitre = _mapper.Map<Core.DomainEntities.Chapitre>(entity);

//        // Call repository to save the Domain Entity
//        await _ChapitreRepository.AddObjAsync(domainChapitre);
//    }

//    public async Task DeleteAsync(int id)
//    {
//        await _ChapitreRepository.DeleteObjAsync(id);
//    }



//    public async Task<IEnumerable<ChapitreDTO>> GetAllAsync()
//    {
//        var domainChapitres = await _ChapitreRepository.GetAllObjAsync();

//        // Map Domain Entities to DTOs
//        return _mapper.Map<IEnumerable<ChapitreDTO>>(domainChapitres);
//    }

//    public async Task<ChapitreDTO?> GetByIdAsync(int id)
//    {
//        // Fetch Domain Entity by ID
//        var domainChapitre = await _ChapitreRepository.GetObjByIdAsync(id);

//        // Map Domain Entity to DTO
//        return domainChapitre != null
//            ? _mapper.Map<ChapitreDTO>(domainChapitre)
//            : null;
//    }

//    public async Task UpdateAsync(ChapitreDTO entity)
//    {
//        // Map DTO to Domain Entity
//        var domainChapitre = _mapper.Map<Core.DomainEntities.Chapitre>(entity);

//        // Call repository to update the Domain Entity
//        await _ChapitreRepository.UpdateObjAsync(domainChapitre);
//    }



//}
