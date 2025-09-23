using ProyectoDeCero2.Datos;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Presentacion.Components;
using ProyectoDeCero2.Negocios;
using ProyectoDeCero2.Servicios;
using Servicios;
using Datos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Inyectar las dependencias de las capas
builder.Services.AddScoped<RepositorioCarrera>();
builder.Services.AddScoped<CarreraNegocios>();
builder.Services.AddScoped<ICarreraServicios, CarreraServicios>();

// Configurar y conectar a la base de datos
var connectionString = builder.Configuration.GetConnectionString("ConnectionToDb");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("La cadena de conexión 'ConnectionToDb' no se encontró.");
}

builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlServer(connectionString)
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
