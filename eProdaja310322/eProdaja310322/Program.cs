using eProdaja.Services;
using eProdaja.Services.Database;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProizvodiService, ProizvodiService>();
builder.Services.AddScoped<IKorisniciService, KorisniciService>();

builder.Services.AddScoped<IJediniceMjereService, JediniceMjereService>();
builder.Services.AddScoped<IVrsteProizvodumService, VrsteProizvodumService>();

builder.Services.AddAutoMapper(typeof(IKorisniciService));
builder.Services.AddDbContext<eProdajaContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("Default Connection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

    