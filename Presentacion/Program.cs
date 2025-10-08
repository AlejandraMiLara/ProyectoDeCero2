using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Presentacion.Components;
using ProyectoDeCero2.Datos;
using ProyectoDeCero2.Negocios;
using ProyectoDeCero2.Servicios;
using Servicios;
using Negocios;
using Datos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Inyección de Docentes
builder.Services.AddScoped<RepositorioDocente>();
builder.Services.AddScoped<DocenteNegocios>();
builder.Services.AddScoped<IDocenteServicios, DocenteServicios>();

//Inyección Materias
builder.Services.AddScoped<RepositorioMateria>();
builder.Services.AddScoped<MateriaNegocios>();
builder.Services.AddScoped<IMateriaServicios, MateriaServicios>();


// Inyección Carrera
builder.Services.AddScoped<RepositorioCarrera>();
builder.Services.AddScoped<CarreraNegocios>();
builder.Services.AddScoped<ICarreraServicios, CarreraServicios>();

// Inyección PlanEstudio
builder.Services.AddScoped<RepositorioPlanEstudio>();
builder.Services.AddScoped<PlanEstudioNegocios>();
builder.Services.AddScoped<IPlanEstudioServicios, PlanEstudioServicios>();

// DBCONEX
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
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();