using Budget2024.Application.MappingProfiles;
using Budget2024.Application.Services;
using Budget2024.Application.Services.Budget;
using Budget2024.Core.Abstract;
using Budget2024.Core.Abstract.Budget;
using Budget2024.Infrastructure.Concret;
using Budget2024.Infrastructure.Concret.Budget;
using Budget2024.Infrastructure.ModelEntity;
using Budget2024.Webass;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);



// Add configuration to load appsettings.json
var configuration = builder.Configuration;
var apiBaseUrl = configuration["ApiSettings:BaseUrl"];
// Register HttpClient with the API BaseUrl
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseUrl) });

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7076") });



builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register AutoMapper
builder.Services.AddAutoMapper(typeof(BudgetMappingProfile));

// Register DbContext (example with SQL Server)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register UnitOfWork and repositories (example)
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Register generic repository
builder.Services.AddScoped<IBudgetRepository, BudgetRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

// Register specific services
builder.Services.AddScoped<IBudgetService, BudgetService>();
//builder.Services.AddScoped<IBudgetService, BudgetService>();
//builder.Services.AddScoped<BudgetService>();

// Register GenericService for DTO/Entity pairs
builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
//builder.Services.AddScoped<IGenericService<BudgetDTO, Budget>, GenericService<BudgetDTO, Budget>>();

//Register Meditor
//builder.Services.AddMediatR(typeof(CreateBugetCommand).Assembly);

builder.Services.AddMudServices();

await builder.Build().RunAsync();
