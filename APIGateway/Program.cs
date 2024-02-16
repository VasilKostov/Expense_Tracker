using APIGateway.Interfaces;
using APIGateway.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
//    .AddJsonFile("ocelo.json", optional: false, reloadOnChange: true)
//    .AddEnvironmentVariables();

builder.Services.AddTransient<IAuthenticationService, AuthenticationService>();
builder.Services.AddControllers();
//builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();
app.MapControllers();

//await app.UseOcelot();

app.Run();