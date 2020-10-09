﻿using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using PizzaMario.ImportCsv.Mappers;
using PizzaMario.ImportCsv.Model;

namespace PizzaMario.ImportCsv.Importer
{
    public interface IExtraIngredientImporter
    {
        void Import(string filePath);
    }

    public class ExtraIngredientImporter : IExtraIngredientImporter// make inteervace for get service!
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
                _context.ExtraIngredients.Add(_mapper.Map(ingredient)); //mapped data
                _context.SaveChanges();
            }
        }

        private static IEnumerable<CsvExtraIngredient> GetIngredients(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Configuration.Delimiter = ";";
            return csv.GetRecords<CsvExtraIngredient>().ToList();
        }
    }
}