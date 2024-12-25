using Budget2024.Core.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Budget2024.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TDto,TEntity > : ControllerBase
    where TEntity : class
    where TDto : class
    {
        private readonly IGenericService<TDto,TEntity> _genericService;

        public GenericController(IGenericService<TDto,TEntity> genericService)
        {
            _genericService = genericService;
        }

        // Get all entities and map them to DTOs
        // https://localhost:7076/api/budget/all
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<TDto>>> GetAllAsync()
        {
            var entities = await _genericService.GetAllAsync();
            return Ok(entities);
        }

        [HttpGet("filtered")]
        //https://localhost:7076/api/budget/filtered?filters[Code]=%D9%85.%D8%AA&sortOrder[Budget1]=asc&sortOrder[Code]=desc&pageNumber=1&pageSize=10
        public async Task<ActionResult<IEnumerable<TDto>>> GetAllFilteredAsync(
                [FromQuery] Dictionary<string, string>? filters = null,
                [FromQuery] Dictionary<string, string>? sortOrder = null,
                [FromQuery] int pageNumber = 1,
                [FromQuery] int pageSize = 10)
        {
            var entities = await _genericService.GetAllFilteredAsync(filters, sortOrder, pageNumber, pageSize);
            return Ok(entities);
        }


        // Get a single entity by ID and map it to a DTO
        [HttpGet("{id}")]
        public async Task<ActionResult<TDto>> GetById(int id)
        {
            var entity = await _genericService.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        //POST: api/{entity}
            [HttpPost]
        public async Task<ActionResult<TDto>> Create([FromBody] TDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdDto = await _genericService.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = createdDto }, createdDto);
        }


        // PUT: api/{entity}/{id}
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] TDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _genericService.UpdateAsync(id, dto);

            return NoContent();
        }

        // Delete an entity by ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var exists = await _genericService.ExistsAsync(id);

            if (!exists)
                return NotFound($"Entity with ID {id} not found.");

            await _genericService.DeleteAsync(id);

            return NoContent();
        }
    }

}


    //public class GenericController<TDto, TEntity, TService> : ControllerBase
    //    where TDto : class
    //    where TService : IGenericService<TDto,TEntity>
    //    where TEntity :class
    //{
    //    private readonly TService _service;

    //    public GenericController(TService service)
    //    {
    //        _service = service;
    //    }

    //    // GET: api/{entity}
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<TDto>>> GetAll()
    //    {
    //        var items = await _service.GetAllAsync();
    //        return Ok(items);
    //    }

    //    // GET: api/{entity}/{id}
    //    [HttpGet("{id:int}")]
    //    public async Task<ActionResult<TDto>> GetById(int id)
    //    {
    //        var item = await _service.GetByIdAsync(id);

    //        if (item == null)
    //            return NotFound($"Entity with ID {id} not found.");

    //        return Ok(item);
    //    }

    //    // POST: api/{entity}
    //    [HttpPost]
    //    public async Task<ActionResult<TDto>> Create([FromBody] TDto dto)
    //    {
    //        if (!ModelState.IsValid)
    //            return BadRequest(ModelState);

    //        var createdDto = await _service.AddAsync(dto);

    //        return CreatedAtAction(nameof(GetById), new { id = createdDto }, createdDto);
    //    }

    //    // PUT: api/{entity}/{id}
    //    [HttpPut("{id:int}")]
    //    public async Task<IActionResult> Update(int id, [FromBody] TDto dto)
    //    {
    //        if (!ModelState.IsValid)
    //            return BadRequest(ModelState);

    //        await _service.UpdateAsync(id, dto);

    //        return NoContent();
    //    }

    //    // DELETE: api/{entity}/{id}
    //    [HttpDelete("{id:int}")]
    //    public async Task<IActionResult> Delete(int id)
    //    {
    //        var exists = await _service.ExistsAsync(id);

    //        if (!exists)
    //            return NotFound($"Entity with ID {id} not found.");

    //        await _service.DeleteAsync(id);

    //        return NoContent();
    //    }
    //}

