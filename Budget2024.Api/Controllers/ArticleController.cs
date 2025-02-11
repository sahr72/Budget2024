using Budget2024.Application.DTOs.Budget;
using Budget2024.Application.Services.Article;
using Budget2024.Application.Services.Chapitre;
using Microsoft.AspNetCore.Mvc;

namespace Budget2024.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : GenericController<ArticleDTO, Core.DomainEntities.Article>
    {
        private readonly IArticleService _articleService;
        public ArticleController(IArticleService ArticleService)
            : base(ArticleService)
        {
            _articleService=ArticleService;
        }
        [HttpGet("by-chapitre/{chapitreId}")]
        public async Task<IActionResult> GetAllArticleByChapitre(int chapitreId)
        {
            var articles = await _articleService.GetAllArticleByChapitreAsync(chapitreId);
            return Ok(articles);
        }

    }
}
