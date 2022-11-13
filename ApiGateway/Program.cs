using JwtAuthenticationManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("ocelot.json", optional:false,reloadOnChange:true)
    .AddEnvironmentVariables();
builder.Services.AddOcelot(builder.Configuration);

/* Add Authentication to the Ocelot Apigateway project */
builder.Services.AddCustomJwtAuthentication();
/* =================================================== */

var app = builder.Build();

await app.UseOcelot();

/* Add Authentication to the Ocelot Apigateway project */
app.UseAuthentication();
app.UseAuthorization();
/* =================================================== */

app.Run();
