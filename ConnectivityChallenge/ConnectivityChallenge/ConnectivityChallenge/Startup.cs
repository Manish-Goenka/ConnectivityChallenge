using System.Reflection;
using AutoMapper;
using ConnectivityChallenge.API.PokemonAPIService.Service;
using ConnectivityChallenge.API.TranslateAPIService.Service;
using ConnectivityChallenge.BLL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConnectivityChallengeWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            services.AddAutoMapper(Assembly.Load("ConnectivityChallenge.BLL"), Assembly.GetExecutingAssembly());
            services.AddScoped<ITranslateAPIService, TranslateAPIService>();
            services.AddScoped<IPokemonAPIService, PokemonAPIService>();
            services.AddScoped<IPokemonService, PokemonService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
