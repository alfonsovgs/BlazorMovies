using BlazorMovies.Client.Repositories;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorMovies.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ServicioSingleton>();
            services.AddTransient<ServicioTransient>();
            services.AddScoped<IMovieRepository, MovieRepository>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
