using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Business.Services;
using ExcelsiorLuxury.Data.Context;
using ExcelsiorLuxury.Data.Repositories;
using ExcelsiorLuxury.Data.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


//Usa ExcelsiorLuxuryDbContext
//y conéctalo a SQL Server
builder.Services.AddDbContext<ExcelsiorLuxuryDbContext>(options =>    
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));


//repository
builder.Services.AddScoped<IZUsuarioRepository, ZUsuarioRepository>();
builder.Services.AddScoped<IZDireccionRepository, ZDireccionRepository>();
builder.Services.AddScoped<IZMarcaRepository, ZMarcaRepository>();
builder.Services.AddScoped<IZModeloRepository, ZModeloRepository>();
builder.Services.AddScoped<IZProductoRepository, ZProductoRepository>();
builder.Services.AddScoped<IZEnvioRepository, ZEnvioRepository>();
builder.Services.AddScoped<IZOrdenRepository, ZOrdenRepository>();
builder.Services.AddScoped<IZOrdenDetalleRepository, ZOrdenDetalleRepository>();


//Service
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IDireccionService, DireccionService>();
builder.Services.AddScoped<IMarcaService, MarcaService>();
builder.Services.AddScoped<IModeloService, ModeloService>();
builder.Services.AddScoped<IProductoService, ProductoService>();
builder.Services.AddScoped<IEnvioService, EnvioService>();
builder.Services.AddScoped<IOrdenService, OrdenService>();
builder.Services.AddScoped<IOrdenDetalleService, OrdenDetalleService>();



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();