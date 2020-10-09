using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaMario.ImportCsv.Importer;
using PizzaMario.ImportCsv.Settings;

namespace PizzaMario.ImportCsv.Services
{
    public class ImportService : BackgroundService
    {
        private readonly ImportSettings _settings;
        private readonly IServiceProvider _provider;

        public ImportService(ImportSettings settings, IServiceProvider provider)
        {
            _settings = settings;
            _provider = provider;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var path = @"C:\TestFiles\ExtraIngredienten1.csv";
            // loopen door folder voor juist bestandnaam
            // in loop scope aanmaken
            using (var scope = _provider.CreateScope())
            {
                var importer = scope.ServiceProvider.GetService<ExtraIngredientImporter>();
                importer.Import(path);
            }

            // basis bestandsnaam importer kiezen
            // importer aanmaken binnen de scope

            // bestand afgeven -> importeren

            return Task.CompletedTask;
        }
    }
}