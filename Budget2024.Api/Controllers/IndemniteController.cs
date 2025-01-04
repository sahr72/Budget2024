using Budget2024.Application.DTOs.Budget;
using Budget2024.Application.Services.Article;
using Budget2024.Application.Services.Indemnite;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Budget2024.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndemniteController : GenericController<IndemniteDTO, Core.DomainEntities.Indemnite>
    {
        private readonly IIndemniteService _indemniteService;
        public IndemniteController(IIndemniteService IndemniteService)
            : base(IndemniteService)
        {
            _indemniteService = IndemniteService;
        }

        // New action to call GetAllWithRelatedEntitiesAsync
        [HttpGet("all-with-related")]
        public async Task<ActionResult<IEnumerable<IndemniteDTO>>> GetAllWithRelatedEntitiesAsync()
        {
            var entities = await _indemniteService.GetAllWithRelatedEntitiesAsync();
            return Ok(entities);
        }
    }
}
