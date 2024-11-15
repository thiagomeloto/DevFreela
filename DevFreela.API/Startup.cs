using DevFreela.API.Models;
using Microsoft.OpenApi.Models;

namespace DevFreela.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configuração de opções personalizadas
            services.Configure<OpeningTimeOption>(Configuration.GetSection("OpeningTime"));

            //Singleton mantém o mesmo objeto para toda a aplicação. Mantém a mesma instância (mesmos dados) enquanto estiver inicializada.
            //services.AddSingleton<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" });

            //Scoped tem um tempo de vida para cada requisição. Um objeto é inicializado a cada nova requisição. São objetos diferentes para requisições diferentes.
            //services.AddScoped<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" });

            //Semelhante ao Scoped em que cada contexto seria sua própria instância. É a que tem o menor tempo de vida.
            services.AddTransient<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" });

            // Adiciona suporte a controladores
            services.AddControllers();

            // Configura o Swagger/OpenAPI
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "DevFreela.API",
                    Version = "v1"
                });
            });
        }

        public void Configure(WebApplication app)
        {
            // Configura o pipeline de requisições HTTP
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DevFreela.API v1"));
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
