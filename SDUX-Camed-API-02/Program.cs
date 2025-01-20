using Microsoft.EntityFrameworkCore;
using SDUX_Camed_API_02.Data;
using SDUX_Camed_API_02.Interfaces.Repositories;
using SDUX_Camed_API_02.Interfaces.Services;
using SDUX_Camed_API_02.Mapper;
using SDUX_Camed_API_02.Repositories;
using SDUX_Camed_API_02.Services;

var builder = WebApplication.CreateBuilder(args);

// Add connections to the dbo
builder.Services.AddDbContext<CamedDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("CamedConnection")));

// Add AutoMApperProfile
builder.Services.AddAutoMapper(typeof(ClienteMappingProfile));

// Add services to the container.
builder.Services.AddScoped<IClienteService, ClienteService>();

// Add repositories to the container.
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
