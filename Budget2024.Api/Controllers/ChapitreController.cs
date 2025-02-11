using Budget2024.Application.DTOs.Budget;
using Budget2024.Application.Services.Budget;
using Budget2024.Application.Services.Chapitre;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Budget2024.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapitreController : GenericController<ChapitreDTO, Core.DomainEntities.Chapitre>
    {   
        private readonly IChapitreService _chapitreService;
        public ChapitreController(IChapitreService ChapitreService)
            : base(ChapitreService)
        {
           _chapitreService= ChapitreService;
        }

       
        [HttpGet("by-budget/{budgetId}")]
        public async Task<IActionResult> GetAllChapitreByBudget(int budgetId)
        {
            var chapitres = await _chapitreService.GetAllChapitreByBudgetAsync(budgetId);
            return Ok(chapitres);
        }
    }
}
