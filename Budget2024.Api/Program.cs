using Budget2024.Infrastructure.ModelEntity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen();

/****/
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();//Ce middleware permet le débogage du code Blazor WebAssembly.
}

app.UseHttpsRedirection();

/****/
app.UseBlazorFrameworkFiles(); //Ce middleware permet à l'API de servir l'application Blazor.      
app.UseStaticFiles();//Ce middleware permet aux fichiers statiques d'être servis par l'API.

app.UseAuthorization();

app.MapControllers();
app.MapFallbackToFile("index.html");//Si une requête ne correspond pas à un contrôleur, diffusez le fichier index.html du projet Blazor.

app.Run();
/*
 Les points clés à noter dans les modifications sont l'ajout du middleware UseWebAssemblyDebugging . Cela nous permet de continuer à déboguer notre code Blazor WebAssembly une fois que nous avons commencé à utiliser l'API comme projet de démarrage.

Ensuite, nous avons ajouté les fichiers UseBlazorFrameworkFiles() et le middleware UseStaticFiles() . Ensemble, ils permettent à l'API de servir les fichiers d'application Blazor. Après tout, une application Blazor WebAssembly, une fois compilée, n'est qu'un ensemble de fichiers statiques.

L'autre changement à noter est l'ajout du point de terminaison MapFallbackToFile. Cela indique à l'API d'acheminer toutes les requêtes qui ne correspondent pas à l'un de ses points de terminaison vers l'application Blazor afin qu'elle puisse essayer de les gérer.

Nous allons maintenant revenir au fichier launchSettings.json. Ici, nous allons ajouter quelques lignes, comme indiqué dans la liste suivante.
 */