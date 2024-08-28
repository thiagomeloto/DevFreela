using DevFreela.API;

var builder = WebApplication.CreateBuilder(args);

// Instancia a classe Startup
var startup = new Startup(builder.Configuration);

// Configura os serviços
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Configura o pipeline de requisições HTTP
startup.Configure(app);

app.Run();
