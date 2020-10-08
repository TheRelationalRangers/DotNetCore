using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using PizzaMario.ImportCsv;

namespace PizzaMario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\TestFiles\ExtraIngredienten1.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<ExtraIngredients>();
                foreach (var record in records)
                {
                    Console.WriteLine($"Ingredient {record.Ingredient}, Price {record.ExtraPrice}");
                }
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}