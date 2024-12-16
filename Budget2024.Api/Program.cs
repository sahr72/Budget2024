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