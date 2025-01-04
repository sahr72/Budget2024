using AutoMapper;
using Budget2024.Application.DTOs.Budget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.MappingProfiles
{
    public class IndemniteMappingProfile:Profile
    {
        public IndemniteMappingProfile()
        {
            // Map between Domain entity and DTO
            CreateMap<Core.DomainEntities.Indemnite, IndemniteDTO>()
                .ForMember(dest => dest.ArticleDescription, opt => opt.Ignore()) // Domain does not contain navigation details
                .ForMember(dest => dest.ChapitreDescription, opt => opt.Ignore());

            CreateMap<IndemniteDTO, Core.DomainEntities.Indemnite>();

            // Map between Infrastructure model and DTO
            CreateMap<Infrastructure.Data.Indemnite, IndemniteDTO>()
                .ForMember(dest => dest.ArticleDescription, opt => opt.MapFrom(src => src.Article != null ? src.Article.Article1 : string.Empty))
                .ForMember(dest => dest.ChapitreDescription, opt => opt.MapFrom(src => src.Article.Chapitre != null ? src.Article.Chapitre.Chapitre1 : string.Empty));

            CreateMap<IndemniteDTO, Infrastructure.Data.Indemnite>();

            // Map between Domain entity and Infrastructure model
            CreateMap<Core.DomainEntities.Indemnite, Infrastructure.Data.Indemnite>()
                .ForMember(dest => dest.Article, opt => opt.Ignore()) // Ignore navigation property in mapping
                .ReverseMap()
                .ForMember(dest => dest.ArticleId, opt => opt.MapFrom(src => src.ArticleId));
        }
    }
}
