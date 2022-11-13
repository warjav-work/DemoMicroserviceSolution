using CustomerWebApi;
using JwtAuthenticationManager;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

/* Add Authentication to the customer project */
builder.Services.AddCustomJwtAuthentication();
/* ========================================== */

/* Database Context Dependency Injection */
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_SA_PASSWORD");
var connectionString = $"Data Source={dbHost};Initial Catalog={dbName};User ID=sa;Password={dbPassword}";
//var connectionString = $"Data Source=DESKTOP-UKDCDPL\\WAR;Initial Catalog={dbName};Integrated Security=True;MultipleActiveResultSets=True";
builder.Services.AddDbContext<CustomerDbContext>(options => options.UseSqlServer(connectionString));
/* ===================================== */

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
