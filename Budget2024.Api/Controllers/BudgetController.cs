using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Budget2024.Application.Services.Budget;
using Budget2024.Application.DTOs;
using Budget2024.Application.DTOs.Budget;
using Budget2024.Core.Abstract;
using AutoMapper;

namespace Budget2024.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class BudgetController : GenericController<BudgetDTO, Core.DomainEntities.Budget>
    {
       // private readonly IBudgetService _budgetService;
        //private readonly IMapper _mapper;

        public BudgetController(IBudgetService budgetService)
            : base(budgetService)
        {
          //  _budgetService = budgetService;
           // _mapper = mapper;
        }

    }
}

