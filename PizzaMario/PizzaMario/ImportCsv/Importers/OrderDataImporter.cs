﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using PizzaMario.ImportCsv.Mappers;
using PizzaMario.ImportCsv.Models;

namespace PizzaMario.ImportCsv.Importers
{
    public interface IOrderDataImporter
    {
        void Import(string filePath);
    }

    public class OrderDataImporter : IOrderDataImporter
    {
        private readonly IOrderDataMapper _mapper;
        private readonly PizzaMarioContext _context;

        public OrderDataImporter(IOrderDataMapper mapper, PizzaMarioContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void Import(string filePath)
        {
            var orderData = GetOrderData(filePath);
            foreach (var order in orderData)
            {
                _context.OrderData.Add(_mapper.Map(order));
                _context.SaveChanges();
                Console.WriteLine($"Added order {order.Klantnaam}");
            }
        }

        private static IEnumerable<CsvOrderData> GetOrderData(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Configuration.ShouldSkipRecord = row => row[0].StartsWith("Mario bestllingen") ||
                                                        row[0].StartsWith("Let op!") ||
                                                        row.All(string.IsNullOrEmpty);
            csv.Configuration.RegisterClassMap<OrderDataHeaderMapper>();
            csv.Configuration.Delimiter = ";";
            return csv.GetRecords<CsvOrderData>().ToList();
        }
    }
}