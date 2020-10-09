using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PizzaMario.ImportCsv.Importer;
using PizzaMario.ImportCsv.Services;
using PizzaMario.ImportCsv.Settings;

namespace PizzaMario
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
            services.AddDbContextPool<PizzaMarioContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PizzaMarioConnection")));
            services.AddControllers();
            services.AddScoped<IExtraIngredientImporter, ExtraIngredientImporter>();
            services.AddSingleton(_ => CreateImportSettings());
            services.AddHostedService<ImportService>();
        }

        private ImportSettings CreateImportSettings()
        {
            var importSettings = new ImportSettings();
            Configuration.GetSection("ImportSettings").Bind(importSettings);
            return importSettings;
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