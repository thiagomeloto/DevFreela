using DevFreela.API;

var builder = WebApplication.CreateBuilder(args);

// Instancia a classe Startup
var startup = new Startup(builder.Configuration);

// Configura os servi�os
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Configura o pipeline de requisi��es HTTP
startup.Configure(app);

app.Run();
