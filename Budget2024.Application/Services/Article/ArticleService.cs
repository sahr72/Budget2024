using AutoMapper;
using Budget2024.Application.DTOs.Budget;
using Budget2024.Application.Services.Article;
using Budget2024.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.Services.Article
{
    public class ArticleService:IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ArticleDTO>> GetAllAsync()
        {
            var entities = await _unitOfWork.Repository<Infrastructure.Data.Article>().GetAllAsync();
            return _mapper.Map<IEnumerable<ArticleDTO>>(entities);

            //return await _unitOfWork.Repository<Core.DomainEntities.Article>()
            //                        .Query()
            //                        .Select(s => new ArticleDTO
            //                        {
            //                            ArticleId = s.ArticleId,
            //                            Code = s.Code,
            //                            Article1 = s.Article1
            //                        })
            //                        .ToListAsync();
        }


        public async Task<ArticleDTO?> GetByIdAsync(int id)
        {
            var entite = await _unitOfWork.Repository<Infrastructure.Data.Article>().GetByIdAsync(id);
            return entite == null ? null : _mapper.Map<ArticleDTO>(entite);
        }
        public async Task<ArticleDTO> AddAsync(ArticleDTO dto)
        {
            var entite = _mapper.Map<Infrastructure.Data.Article>(dto);
            await _unitOfWork.Repository<Infrastructure.Data.Article>().AddAsync(entite);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ArticleDTO>(dto);
        }
        //public async Task UpdateAsync(int id, ArticleDTO dto)
        //{
        //    var entite = _mapper.Map<Infrastructure.Data.Article>(dto);
        //    //var x=_unitOfWork.Repository<Core.DomainEntities.Article>().GetByIdAsync<int>(id);
        //    await _unitOfWork.Repository<Infrastructure.Data.Article>().UpdateAsync(entite);
        //    await _unitOfWork.SaveChangesAsync();

        //}
        public async Task<ArticleDTO> UpdateAsync(int id, ArticleDTO dto)
        {
            var entity = await _unitOfWork.Repository<Infrastructure.Data.Article>().GetByIdAsync(id);

            if (entity == null)
                throw new KeyNotFoundException("Entity not found.");

            _mapper.Map(dto, entity); // Update entity with values from dto

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ArticleDTO>(entity);

        }
        public async Task DeleteAsync(int id)
        {
            var entite = await _unitOfWork.Repository<Infrastructure.Data.Article>().GetByIdAsync(id);
            if (entite != null)
            {
                await _unitOfWork.Repository<Infrastructure.Data.Article>().DeleteAsync(entite);
                await _unitOfWork.SaveChangesAsync();
            }
        }


        public async Task<bool> ExistsAsync(int id)
        {
            var entite = await _unitOfWork.Repository<Infrastructure.Data.Article>().GetByIdAsync(id);
            if (entite != null) return true;
            return false;
        }

        public async Task<IEnumerable<ArticleDTO>> GetAllFilteredAsync(
            Dictionary<string, string>? filters = null,
            Dictionary<string, string>? sortOrder = null,
            int pageNumber = 1,
            int pageSize = 10)
        {
            var entities = await _unitOfWork.Repository<Infrastructure.Data.Article>().GetAllFilteredAsync(filters, sortOrder, pageNumber, pageSize);
            return _mapper.Map<IEnumerable<ArticleDTO>>(entities);
        }

        public async Task<IEnumerable<ArticleDTO>> GetAllArticleByChapitreAsync(int chapitreId)
        {
            var entities = await _unitOfWork.Repository<Infrastructure.Data.Article>().FindAsync(c => c.ChapitreId == chapitreId);
            return _mapper.Map<IEnumerable<ArticleDTO>>(entities);
        }
    }
    //public class ArticleService : GenericService<ArticleDTO, Core.DomainEntities.Article>, IGenericService<ArticleDTO, Core.DomainEntities.Article>
    //{
    //    /* Cette classe permet de gèrer l'orchestration et la logique d'affaire, 
    //     *   assurant l'interaction correcte entre les différentes couches de l'application.
    //     * Ses méthodes Get ne retournent que des DTOs  
    //     * Ici le mappage se fera:
    //     *    1. des DTOs vers les entités du domaine pour la logique d'affaire interne
    //     *    2. des entités du domaine vers les DTOs avant de retourner les données au controlleurs ou à la couche API.
    //     * IArticleRepository: Cette interface gère la logique d'accès aux données.
    //     * IMapper: gère le mappage entre les DTOs et les entités du domaine.
    //     * 
    //     */
    //    private readonly IArticleRepository _repository;
    //    private readonly IMapper _mapper;
    //    public ArticleService(IGenericRepository<Core.DomainEntities.Article> repository, IMapper mapper) : base(repository, mapper)
    //    {
    //        _repository = repository;
    //        _mapper = mapper;
    //    }
    //    public async Task<ArticleDTO> AddAsync(ArticleDTO dto)
    //    {
    //        var domainEntity = _mapper.Map<Core.DomainEntities.Article>(dto);

    //        // Call repository to save the Domain Entity
    //        await _repository.AddObjAsync(domainEntity);
    //        return _mapper.Map<ArticleDTO>(domainEntity);
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
    //        // Call the repository to check if the Article exists by ID
    //        var Article = await _repository.GetObjByIdAsync(id);

    //        // Return true if the Article exists, otherwise false
    //        return Article != null;
    //    }

    //    public async Task<IEnumerable<ArticleDTO>> GetAllAsync()
    //    {
    //        var entities = await _repository.GetAllObjAsync();
    //        return _mapper.Map<IEnumerable<ArticleDTO>>(entities);
    //    }

    //    public async Task<ArticleDTO?> GetByIdAsync(int id)
    //    {
    //        var entity = await _repository.GetObjByIdAsync(id);
    //        return entity != null ? _mapper.Map<ArticleDTO>(entity) : null;
    //    }

    //    public async Task UpdateAsync(int id, ArticleDTO dto)
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
    //public class ArticleService : IArticleService
    //{   /* Cette classe permet de gèrer l'orchestration et la logique d'affaire, 
    //     *   assurant l'interaction correcte entre les différentes couches de l'application.
    //     * Ses méthodes Get ne retournent que des DTOs  
    //     * Ici le mappage se fera:
    //     *    1. des DTOs vers les entités du domaine pour la logique d'affaire interne
    //     *    2. des entités du domaine vers les DTOs avant de retourner les données au controlleurs ou à la couche API.
    //     * IArticleRepository: Cette interface gère la logique d'accès aux données.
    //     * IMapper: gère le mappage entre les DTOs et les entités du domaine.
    //     * 
    //     */
    //    private readonly IArticleRepository _ArticleRepository;
    //    private readonly IMapper _mapper;
    //    public ArticleService(IArticleRepository ArticleRepository, IMapper mapper)
    //    {
    //        _ArticleRepository = ArticleRepository;
    //        _mapper = mapper;
    //    }

    //    public async Task AddAsync(ArticleDTO entity)
    //    {
    //        var domainArticle = _mapper.Map<Core.DomainEntities.Article>(entity);

    //        // Call repository to save the Domain Entity
    //        await _ArticleRepository.AddObjAsync(domainArticle);
    //    }

    //    public async Task DeleteAsync(int id)
    //    {
    //        await _ArticleRepository.DeleteObjAsync(id);
    //    }



    //    public async Task<IEnumerable<ArticleDTO>> GetAllAsync()
    //    {
    //        var domainArticles = await _ArticleRepository.GetAllObjAsync();

    //        // Map Domain Entities to DTOs
    //        return _mapper.Map<IEnumerable<ArticleDTO>>(domainArticles);
    //    }

    //    public async Task<ArticleDTO?> GetByIdAsync(int id)
    //    {
    //        // Fetch Domain Entity by ID
    //        var domainArticle = await _ArticleRepository.GetObjByIdAsync(id);

    //        // Map Domain Entity to DTO
    //        return domainArticle != null
    //            ? _mapper.Map<ArticleDTO>(domainArticle)
    //            : null;
    //    }

    //    public async Task UpdateAsync(ArticleDTO entity)
    //    {
    //        // Map DTO to Domain Entity
    //        var domainArticle = _mapper.Map<Core.DomainEntities.Article>(entity);

    //        // Call repository to update the Domain Entity
    //        await _ArticleRepository.UpdateObjAsync(domainArticle);
    //    }



    //}

}

