using Budget2024.Application.DTOs.Budget;
using Budget2024.Application.MappingProfiles;
using Budget2024.Application.Services;
using Budget2024.Application.Services.Article;
using Budget2024.Application.Services.Budget;
using Budget2024.Application.Services.Chapitre;
using Budget2024.Application.Services.Indemnite;
using Budget2024.Core.Abstract;
using Budget2024.Core.Abstract.Budget;
using Budget2024.Infrastructure.Concret;
using Budget2024.Infrastructure.Concret.Budget;
using Budget2024.Infrastructure.ModelEntity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorApp",
        policy => policy.WithOrigins("https://localhost:7074") // Blazor app URL
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
});


// Add services to the container.
// Register AutoMapper
builder.Services.AddAutoMapper(typeof(BudgetMappingProfile));
builder.Services.AddAutoMapper(typeof(ChapitreMappingProfile));
builder.Services.AddAutoMapper(typeof(ArticleMappingProfile));
builder.Services.AddAutoMapper(typeof(IndemniteMappingProfile));

// Register DbContext (example with SQL Server)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register UnitOfWork and repositories (example)
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Register generic repository
builder.Services.AddScoped<IBudgetRepository, BudgetRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IGenericRepository<Budget2024.Infrastructure.Data.Budget>, GenericRepository<Budget2024.Infrastructure.Data.Budget>>();
builder.Services.AddScoped<IGenericRepository<Budget2024.Infrastructure.Data.Chapitre>, GenericRepository<Budget2024.Infrastructure.Data.Chapitre>>();
builder.Services.AddScoped<IGenericRepository<Budget2024.Infrastructure.Data.Article>, GenericRepository<Budget2024.Infrastructure.Data.Article>>();
builder.Services.AddScoped<IGenericRepository<Budget2024.Infrastructure.Data.Indemnite>, GenericRepository<Budget2024.Infrastructure.Data.Indemnite>>();
// Register specific services
//builder.Services.AddScoped<IGenericService<BudgetDTO>, BudgetService>();
builder.Services.AddScoped<IBudgetService,BudgetService>();
builder.Services.AddScoped<IChapitreService, ChapitreService>();
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<IIndemniteService, IndemniteService>();

// Register GenericService for DTO/Entity pairs
builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
//builder.Services.AddScoped<IGenericService<BudgetDTO, Budget2024.Core.DomainEntities.Budget>, GenericService<BudgetDTO, Budget2024.Core.DomainEntities.Budget>>();
//builder.Services.AddScoped<IGenericService<BudgetDTO, Budget2024.Infrastructure.Data.Budget>, GenericService<BudgetDTO, Budget2024.Infrastructure.Data.Budget>>();
//builder.Services.AddScoped<IGenericService<BudgetDTO, Budget2024.Core.DomainEntities.Budget>, GenericService<BudgetDTO, Budget2024.Core.DomainEntities.Budget>>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Register Meditor
//builder.Services.AddMediatR(typeof(CreateBugetCommand).Assembly);

//builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();


// Apply the CORS policy
app.UseCors("AllowBlazorApp");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();//Ce middleware permet le d�bogage du code Blazor WebAssembly.
}

app.UseHttpsRedirection();

/****/
app.UseBlazorFrameworkFiles(); //Ce middleware permet � l'API de servir l'application Blazor.      
app.UseStaticFiles();//Ce middleware permet aux fichiers statiques d'�tre servis par l'API.

app.UseAuthorization();

app.MapControllers();
app.MapFallbackToFile("index.html");//Si une requ�te ne correspond pas � un contr�leur, diffusez le fichier index.html du projet Blazor.

app.Run();
/*
 Les points cl�s � noter dans les modifications sont l'ajout du middleware UseWebAssemblyDebugging . Cela nous permet de continuer � d�boguer notre code Blazor WebAssembly une fois que nous avons commenc� � utiliser l'API comme projet de d�marrage.

Ensuite, nous avons ajout� les fichiers UseBlazorFrameworkFiles() et le middleware UseStaticFiles() . Ensemble, ils permettent � l'API de servir les fichiers d'application Blazor. Apr�s tout, une application Blazor WebAssembly, une fois compil�e, n'est qu'un ensemble de fichiers statiques.

L'autre changement � noter est l'ajout du point de terminaison MapFallbackToFile. Cela indique � l'API d'acheminer toutes les requ�tes qui ne correspondent pas � l'un de ses points de terminaison vers l'application Blazor afin qu'elle puisse essayer de les g�rer.

Nous allons maintenant revenir au fichier launchSettings.json. Ici, nous allons ajouter quelques lignes, comme indiqu� dans la liste suivante.
 */