using AutoMapper;
using Budget2024.Application.DTOs.Budget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget2024.Application.DTOs.Budget;
using Budget2024.Core.DomainEntities;
using Budget2024.Infrastructure.Data;
namespace Budget2024.Application.MappingProfiles
{
    public class ArticleMappingProfile:Profile
    {
        public ArticleMappingProfile()
        {
            // Map between Domain entity and DTO
            CreateMap<Core.DomainEntities.Article, ArticleDTO>()
                    .ForMember(dest => dest.ChapitreDescription, opt => opt.Ignore()); // Domain entity doesn't have Chapitre

            CreateMap<ArticleDTO, Core.DomainEntities.Article>();

            // Map between Infrastructure model and DTO
            CreateMap<Infrastructure.Data.Article, ArticleDTO>()
                .ForMember(dest => dest.ChapitreDescription, opt => opt.MapFrom(src => src.Chapitre != null ? src.Chapitre.Chapitre1 : string.Empty));

            CreateMap<ArticleDTO, Infrastructure.Data.Article>();

            // Map between Domain entity and Infrastructure model
            CreateMap<Core.DomainEntities.Article, Infrastructure.Data.Article>()
                .ForMember(dest => dest.Chapitre, opt => opt.Ignore()) // Avoid direct mapping of navigation property
                .ReverseMap();
        }
       
    }
}
