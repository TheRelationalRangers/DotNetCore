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