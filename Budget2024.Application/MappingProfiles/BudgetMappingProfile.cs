using AutoMapper;
using Budget2024.Application.DTOs.Budget;
using Budget2024.Core.DomainEntities;
using Budget2024.Infrastructure.Data;

namespace Budget2024.Application.MappingProfiles
{
    public class BudgetMappingProfile:Profile
    {
        public BudgetMappingProfile()
        {
            // Mappage entre les entités du domaine dans Core et le DTO
            CreateMap<Core.DomainEntities.Budget, BudgetDTO>().ReverseMap();
            CreateMap<Infrastructure.Data.Budget, BudgetDTO>().ReverseMap();
            // Mappage entre l'entité du modèle BD et l'entité du domaine Core
            //CreateMap<Infrastructure.Data.Budget, Infrastructure.Data.Budget>().ReverseMap();
            //CreateMap<Infrastructure.Data.Budget, Core.DomainEntities.Budget>();
            //CreateMap<Core.DomainEntities.Budget, Infrastructure.Data.Budget>();

        }
    }
}
