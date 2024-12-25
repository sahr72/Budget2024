using AutoMapper;
using Budget2024.Core.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.Services
{
    public class GenericService<TDto, TEntity> : IGenericService<TDto,TEntity>
    where TDto : class
    where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // Add a new entity
        public async Task<TDto> AddAsync(TDto dto)
        {
            // Map DTO to domain entity
            var entity = _mapper.Map<TEntity>(dto);

            // Call repository to save the domain entity
            await _repository.AddAsync(entity);

            // Return mapped DTO after saving
            return _mapper.Map<TDto>(entity);
        }

        // Delete an entity by ID
        public async Task DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
            {
                // Handle entity not found case (throw exception or return a result)
                throw new KeyNotFoundException($"Entity with ID {id} not found.");
            }

            await _repository.DeleteAsync(entity);
        }

        // Check if an entity exists by ID
        public async Task<bool> ExistsAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity != null;
        }

        // Get all entities
        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<IEnumerable<TDto>> GetAllFilteredAsync(
        Dictionary<string, string>? filters = null,
        Dictionary<string, string>? sortOrder = null,
        int pageNumber = 1,
        int pageSize = 10)
        {
            // Fetch data from repository with optional filtering, sorting, and pagination
            var entities = await _repository.GetAllFilteredAsync(filters, sortOrder, pageNumber, pageSize);

            // Map entities to DTOs
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }


       





        // Get an entity by ID
        public async Task<TDto?> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity != null ? _mapper.Map<TDto>(entity) : null;
        }

        // Update an existing entity
        public async Task UpdateAsync(int id, TDto dto)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
            {
                // Handle entity not found case (throw exception or return a result)
                throw new KeyNotFoundException($"Entity with ID {id} not found.");
            }

            // Map updated data from DTO to the entity
            _mapper.Map(dto, entity);

            // Call repository to update the entity
            await _repository.UpdateAsync(entity);
        }
    }
}
//    public class GenericService<TDto, TEntity> :IGenericService<TDto>

//        where TDto : class
//    where TEntity : class
//    {
//            private readonly IGenericRepository<TEntity> _repository;
//            private readonly IMapper _mapper;

//            public GenericService(IGenericRepository<TEntity> repository, IMapper mapper)
//            {
//                _repository = repository;
//                _mapper = mapper;
//            }

//        // public async Task<TDto> AddAsync(TDto dto)

//        Task<TDto> IGenericService<TDto>.AddAsync(TDto dto)
//        {
//            throw new NotImplementedException();
//        }
//        //public async Task AddAsync(TDto dto)
//        //    {
//        //    var entity = _mapper.Map<TEntity>(dto);
//        //    //var savedEntity = await _repository.AddAsync(entity);
//        //    //return _mapper.Map<TDto>(savedEntity);
//        //    var domainEntity = _mapper.Map<Core.DomainEntities.Budget>(entity);

//        //    // Call repository to save the Domain Entity
//        //    await _repository.AddObjAsync(domainEntity);
//        //}

//        public Task DeleteAsync(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<bool> ExistsAsync(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<IEnumerable<TDto>> GetAllAsync()
//            {
//                var entities = await _repository.GetAllAsync();
//                return _mapper.Map<IEnumerable<TDto>>(entities);
//            }

//        public Task<TDto?> GetByIdAsync(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public Task UpdateAsync(int id, TDto dto)
//        {
//            throw new NotImplementedException();
//        }



//        // Other CRUD operations...

//    }

