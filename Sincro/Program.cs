// 1. Using para trabajar con EF
using Data.Interfaces;
using Data.Services;
using Microsoft.EntityFrameworkCore;
using Sincro.Context;

var builder = WebApplication.CreateBuilder(args);

// 2. agregar conexion a base de datos
const string CONNECTIONNAME = "ModelDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// 3. Add Context to Services of builder
builder.Services.AddDbContext<SincroDBContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// 4. Add Custom Services (folder services)
builder.Services.AddScoped<ISincroService, SincroService>(); 
builder.Services.AddScoped<IDataBaseService, DataBaseService>(); 
builder.Services.AddScoped<IUserService, UserService>(); 
builder.Services.AddScoped<ITablesServices, TablesServices>(); 

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
