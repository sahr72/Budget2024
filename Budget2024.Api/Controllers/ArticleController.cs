using Budget2024.Application.DTOs.Budget;
using Budget2024.Application.Services.Article;
using Microsoft.AspNetCore.Mvc;

namespace Budget2024.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : GenericController<ArticleDTO, Core.DomainEntities.Article>
    {
        public ArticleController(IArticleService ArticleService)
            : base(ArticleService)
        {

        }

    }
}
