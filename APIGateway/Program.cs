using APIGateway.Interfaces;
using APIGateway.Services;
using APIGateway.Singletons;
using GrpcAPIGatewayClient;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

//builder.WebHost.UseKestrel(options =>
//{
//    options.ConfigureHttpsDefaults(httpsOptions =>
//    {
//        httpsOptions.AllowAnyClientCertificate();
//    });
//});

builder.WebHost.UseKestrel(options =>
{
    options.ListenAnyIP(8080, configure =>
    {
        configure.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
    });
});

builder.Services.Configure<Configuration>(builder.Configuration.GetSection("Configuration"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddGrpc();
builder.Services
    .AddGrpcClient<Authentication.AuthenticationClient>((services, options) =>
    {
        options.Address = new Uri("http://localhost:8003");
    });
builder.Services.AddTransient<IAuthenticationService, AuthenticationService>();

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