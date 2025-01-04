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
        public ChapitreController(IChapitreService ChapitreService)
            : base(ChapitreService)
        {
           
        }

    }
}
