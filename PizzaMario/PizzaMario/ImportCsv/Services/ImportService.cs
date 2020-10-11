using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaMario.ImportCsv.Importers;
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
            const string extraIngredients = "ExtraIngredienten";
            const string orderData = "MarioOrderData";
            var csvFiles = System.IO.Directory.GetFiles(_settings.ImportFolder, "*.csv");
            foreach (var csvFile in csvFiles)
            {
                if (csvFile.Contains(extraIngredients))
                {
                    using var scope = _provider.CreateScope();
                    var importer = scope.ServiceProvider.GetService<IImporter>();
                    importer.Import(csvFile);
                }
                else if (csvFile.Contains(orderData))
                {
                    using var scope = _provider.CreateScope();
                    var importer = scope.ServiceProvider.GetService<IImporter>();
                    importer.Import(csvFile);
                }
                else
                {
                    Console.WriteLine($"ScvFile {csvFile} could not be imported");
                }
            }
            return Task.CompletedTask;
        }
    }
}