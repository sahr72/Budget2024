using AutoMapper;
using Budget2024.Application.DTOs.Budget;
using Budget2024.Core.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.MappingProfiles
{
    public class ChapitreMappingProfile:Profile
    {
        public ChapitreMappingProfile()
        {
            // Map between Domain entity and DTO
            CreateMap<Chapitre, ChapitreDTO>()
                .ForMember(dest => dest.BudgetDescription, opt => opt.Ignore()); // Domain doesn't have Budget navigation property

            CreateMap<ChapitreDTO, Chapitre>();

            // Map between Infrastructure model and DTO
            CreateMap<Infrastructure.Data.Chapitre, ChapitreDTO>()
                .ForMember(dest => dest.BudgetDescription, opt => opt.MapFrom(src => src.Budget != null ? src.Budget.Budget1 : string.Empty));

            CreateMap<ChapitreDTO, Infrastructure.Data.Chapitre>();

            // Map between Domain entity and Infrastructure model
            //Ensures BudgetId is mapped directly, but Budget navigation is ignored to keep it domain-independent.
             CreateMap<Core.DomainEntities.Chapitre, Infrastructure.Data.Chapitre>()
                .ForMember(dest => dest.Budget, opt => opt.Ignore()) // Avoid mapping navigation properties automatically
                .ReverseMap()
                .ForMember(dest => dest.BudgetId, opt => opt.MapFrom(src => src.BudgetId));

        }
    }
}
