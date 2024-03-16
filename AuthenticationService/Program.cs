using AuthenticationService.Services;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseKestrel(options =>
{
    options.ListenAnyIP(8082, configure =>
    {
        configure.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
    });
});
// Add services to the container.
builder.Services.AddGrpc();
//builder.Services
//    .AddGrpcClient<ProductGrpc.ProductGrpcClient>((services, options) =>
//    {
//        options.Address = new Uri("https://localhost:7087");
//    });

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<AuthenticationService.Services.AuthenticationService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
