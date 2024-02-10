using APIGateway.Services;
using Grpc.Net.Client;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
//    .AddJsonFile("ocelo.json", optional: false, reloadOnChange: true)
//    .AddEnvironmentVariables();

//builder.Services.AddOcelot(builder.Configuration);

using var channel = GrpcChannel.ForAddress("https://localhost:7042");
var client = new 
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

var app = builder.Build();

await app.UseOcelot();

app.Run();