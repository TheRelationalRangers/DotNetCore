using CsvHelper;
using PizzaMario.ImportCsv.Mappers;
using PizzaMario.ImportCsv.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace PizzaMario.ImportCsv.Importers
{
    public interface IExtraIngredientImporter
    {
        void Import(string filePath);
    }

    public class ExtraIngredientImporter : IExtraIngredientImporter
    {
        private readonly IExtraIngredientMapper _mapper;
        private readonly PizzaMarioContext _context;

        public ExtraIngredientImporter(IExtraIngredientMapper mapper, PizzaMarioContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void Import(string filePath)
        {
            var ingredients = GetIngredients(filePath);
            foreach (var ingredient in ingredients)
            {
                _context.ExtraIngredientsData.Add(_mapper.Map(ingredient));
                _context.SaveChanges();
                Console.WriteLine($"Ingredient {ingredient.Ingredient} Added");
            }
        }

        private static IEnumerable<CsvExtraIngredient> GetIngredients(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Configuration.RegisterClassMap<ExtraIngredientHeaderMapper>();
            csv.Configuration.Delimiter = ";";
            return csv.GetRecords<CsvExtraIngredient>().ToList();
        }
    }
}