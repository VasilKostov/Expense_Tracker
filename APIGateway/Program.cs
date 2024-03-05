using APIGateway.Singletons;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseKestrel(options =>
{
    options.ConfigureHttpsDefaults(httpsOptions =>
    {
        httpsOptions.AllowAnyClientCertificate();
    });
});

builder.Services.Configure<Configuration>(builder.Configuration.GetSection("Configuration"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

//builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
//    .AddJsonFile("ocelo.json", optional: false, reloadOnChange: true)
//    .AddEnvironmentVariables();

//builder.Services.AddTransient<IAuthenticationService, AuthenticationService>();
//builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting();

app.MapControllers();

//await app.UseOcelot();

app.Run();