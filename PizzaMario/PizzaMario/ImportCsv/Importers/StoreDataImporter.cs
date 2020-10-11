using System;
using System.Collections.Generic;
using System.IO;
using PizzaMario.ImportCsv.Mappers;

namespace PizzaMario.ImportCsv.Importers
{
    public interface IStoreDataImporter
    {
        void Import(string filePath);
    }

    public class StoreDataImporter : IStoreDataImporter
    {
        private readonly IStoreDataMapper _mapper;
        private readonly PizzaMarioContext _context;

        public StoreDataImporter(IStoreDataMapper mapper, PizzaMarioContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void Import(string filePath)
        {
            var storeData = GetStoreData(filePath);
            foreach (var store in storeData)
            {
                if (store.Count == 8)
                {
                    _context.StoreData.Add(_mapper.Map(store));
                    _context.SaveChanges();
                    Console.WriteLine($"{store[0]} added to database");
                }
            }
        }

        private static IEnumerable<List<string>> GetStoreData(string filePath)
        {
            using var reader = new StreamReader(filePath);
            var lines = new List<string>();
            var blocks = new List<List<string>>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                lines.Add(line);
                if (string.IsNullOrEmpty(line))
                {
                    blocks.Add(lines);
                    lines = new List<string>();
                }
            }

            return blocks;
        }
    }
}