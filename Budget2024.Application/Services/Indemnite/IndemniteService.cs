using AutoMapper;
using Budget2024.Application.DTOs.Budget;
using Budget2024.Core.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.Services.Indemnite
{
    public class IndemniteService:IIndemniteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public IndemniteService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<IndemniteDTO>> GetAllAsync()
        {
            var entities = await _unitOfWork.Repository<Infrastructure.Data.Indemnite>().GetAllAsync();

            return _mapper.Map<IEnumerable<IndemniteDTO>>(entities);

            //return await _unitOfWork.Repository<Core.DomainEntities.Indemnite>()
            //                        .Query()
            //                        .Select(s => new IndemniteDTO
            //                        {
            //                            IndemniteId = s.IndemniteId,
            //                            Code = s.Code,
            //                            Indemnite1 = s.Indemnite1
            //                        })
            //                        .ToListAsync();
        }


        public async Task<IndemniteDTO?> GetByIdAsync(int id)
        {
            var entite = await _unitOfWork.Repository<Infrastructure.Data.Indemnite>().GetByIdAsync(id);
            return entite == null ? null : _mapper.Map<IndemniteDTO>(entite);
        }
        public async Task<IndemniteDTO> AddAsync(IndemniteDTO dto)
        {
            var entite = _mapper.Map<Infrastructure.Data.Indemnite>(dto);
            await _unitOfWork.Repository<Infrastructure.Data.Indemnite>().AddAsync(entite);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<IndemniteDTO>(dto);
        }
        //public async Task UpdateAsync(int id, IndemniteDTO dto)
        //{
        //    var entite = _mapper.Map<Infrastructure.Data.Indemnite>(dto);
        //    //var x=_unitOfWork.Repository<Core.DomainEntities.Indemnite>().GetByIdAsync<int>(id);
        //    await _unitOfWork.Repository<Infrastructure.Data.Indemnite>().UpdateAsync(entite);
        //    await _unitOfWork.SaveChangesAsync();

        //}
        public async Task<IndemniteDTO> UpdateAsync(int id, IndemniteDTO dto)
        {
            var entity = await _unitOfWork.Repository<Infrastructure.Data.Indemnite>().GetByIdAsync(id);

            if (entity == null)
                throw new KeyNotFoundException("Entity not found.");

            _mapper.Map(dto, entity); // Update entity with values from dto

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<IndemniteDTO>(entity);
        }
        public async Task DeleteAsync(int id)
        {
            var entite = await _unitOfWork.Repository<Infrastructure.Data.Indemnite>().GetByIdAsync(id);
            if (entite != null)
            {
                await _unitOfWork.Repository<Infrastructure.Data.Indemnite>().DeleteAsync(entite);
                await _unitOfWork.SaveChangesAsync();
            }
        }


        public async Task<bool> ExistsAsync(int id)
        {
            var entite = await _unitOfWork.Repository<Infrastructure.Data.Indemnite>().GetByIdAsync(id);
            if (entite != null) return true;
            return false;
        }

        public async Task<IEnumerable<IndemniteDTO>> GetAllFilteredAsync(
            Dictionary<string, string>? filters = null,
            Dictionary<string, string>? sortOrder = null,
            int pageNumber = 1,
            int pageSize = 10)
        {
            var entities = await _unitOfWork.Repository<Infrastructure.Data.Indemnite>().GetAllFilteredAsync(filters, sortOrder, pageNumber, pageSize);
            return _mapper.Map<IEnumerable<IndemniteDTO>>(entities);
        }

        public async Task<IEnumerable<IndemniteDTO>> GetAllWithRelatedEntitiesAsync()
        {
            var entities = await _unitOfWork.Repository<Infrastructure.Data.Indemnite>()
            .Query()
            .Include(i => i.Article)
            .ThenInclude(a => a.Chapitre)
            .ToListAsync();

            return _mapper.Map<IEnumerable<IndemniteDTO>>(entities);
        }
    }
    //public class IndemniteService : GenericService<IndemniteDTO, Core.DomainEntities.Indemnite>, IGenericService<IndemniteDTO, Core.DomainEntities.Indemnite>
    //{
    //    /* Cette classe permet de gèrer l'orchestration et la logique d'affaire, 
    //     *   assurant l'interaction correcte entre les différentes couches de l'application.
    //     * Ses méthodes Get ne retournent que des DTOs  
    //     * Ici le mappage se fera:
    //     *    1. des DTOs vers les entités du domaine pour la logique d'affaire interne
    //     *    2. des entités du domaine vers les DTOs avant de retourner les données au controlleurs ou à la couche API.
    //     * IIndemniteRepository: Cette interface gère la logique d'accès aux données.
    //     * IMapper: gère le mappage entre les DTOs et les entités du domaine.
    //     * 
    //     */
    //    private readonly IIndemniteRepository _repository;
    //    private readonly IMapper _mapper;
    //    public IndemniteService(IGenericRepository<Core.DomainEntities.Indemnite> repository, IMapper mapper) : base(repository, mapper)
    //    {
    //        _repository = repository;
    //        _mapper = mapper;
    //    }
    //    public async Task<IndemniteDTO> AddAsync(IndemniteDTO dto)
    //    {
    //        var domainEntity = _mapper.Map<Core.DomainEntities.Indemnite>(dto);

    //        // Call repository to save the Domain Entity
    //        await _repository.AddObjAsync(domainEntity);
    //        return _mapper.Map<IndemniteDTO>(domainEntity);
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
    //        // Call the repository to check if the Indemnite exists by ID
    //        var Indemnite = await _repository.GetObjByIdAsync(id);

    //        // Return true if the Indemnite exists, otherwise false
    //        return Indemnite != null;
    //    }

    //    public async Task<IEnumerable<IndemniteDTO>> GetAllAsync()
    //    {
    //        var entities = await _repository.GetAllObjAsync();
    //        return _mapper.Map<IEnumerable<IndemniteDTO>>(entities);
    //    }

    //    public async Task<IndemniteDTO?> GetByIdAsync(int id)
    //    {
    //        var entity = await _repository.GetObjByIdAsync(id);
    //        return entity != null ? _mapper.Map<IndemniteDTO>(entity) : null;
    //    }

    //    public async Task UpdateAsync(int id, IndemniteDTO dto)
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
    //public class IndemniteService : IIndemniteService
    //{   /* Cette classe permet de gèrer l'orchestration et la logique d'affaire, 
    //     *   assurant l'interaction correcte entre les différentes couches de l'application.
    //     * Ses méthodes Get ne retournent que des DTOs  
    //     * Ici le mappage se fera:
    //     *    1. des DTOs vers les entités du domaine pour la logique d'affaire interne
    //     *    2. des entités du domaine vers les DTOs avant de retourner les données au controlleurs ou à la couche API.
    //     * IIndemniteRepository: Cette interface gère la logique d'accès aux données.
    //     * IMapper: gère le mappage entre les DTOs et les entités du domaine.
    //     * 
    //     */
    //    private readonly IIndemniteRepository _IndemniteRepository;
    //    private readonly IMapper _mapper;
    //    public IndemniteService(IIndemniteRepository IndemniteRepository, IMapper mapper)
    //    {
    //        _IndemniteRepository = IndemniteRepository;
    //        _mapper = mapper;
    //    }

    //    public async Task AddAsync(IndemniteDTO entity)
    //    {
    //        var domainIndemnite = _mapper.Map<Core.DomainEntities.Indemnite>(entity);

    //        // Call repository to save the Domain Entity
    //        await _IndemniteRepository.AddObjAsync(domainIndemnite);
    //    }

    //    public async Task DeleteAsync(int id)
    //    {
    //        await _IndemniteRepository.DeleteObjAsync(id);
    //    }



    //    public async Task<IEnumerable<IndemniteDTO>> GetAllAsync()
    //    {
    //        var domainIndemnites = await _IndemniteRepository.GetAllObjAsync();

    //        // Map Domain Entities to DTOs
    //        return _mapper.Map<IEnumerable<IndemniteDTO>>(domainIndemnites);
    //    }

    //    public async Task<IndemniteDTO?> GetByIdAsync(int id)
    //    {
    //        // Fetch Domain Entity by ID
    //        var domainIndemnite = await _IndemniteRepository.GetObjByIdAsync(id);

    //        // Map Domain Entity to DTO
    //        return domainIndemnite != null
    //            ? _mapper.Map<IndemniteDTO>(domainIndemnite)
    //            : null;
    //    }

    //    public async Task UpdateAsync(IndemniteDTO entity)
    //    {
    //        // Map DTO to Domain Entity
    //        var domainIndemnite = _mapper.Map<Core.DomainEntities.Indemnite>(entity);

    //        // Call repository to update the Domain Entity
    //        await _IndemniteRepository.UpdateObjAsync(domainIndemnite);
    //    }



    //}

}


    

