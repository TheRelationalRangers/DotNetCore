using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using PizzaMario.Models;
using PizzaMario.Models.Import;
using PizzaMario.Services.ValidationService;

namespace PizzaMario.Services.ExcelReader
{
    public class ExcelImportService : IExcelImportService
    {
        private readonly IDataValidationService _dataValidationService;
        private readonly PizzaMarioContext _pizzaMarioContext;

        public ExcelImportService(IDataValidationService dataValidationService, PizzaMarioContext pizzaMarioContext)
        {
            _dataValidationService = dataValidationService;
            _pizzaMarioContext = pizzaMarioContext;
        }

        public async Task<ICollection<Crust>> ImportCrustFromExcelFile(IFormFile file)
        {
            try
            {
                if (file == null) return new List<Crust>();
                if (!Path.GetExtension(file.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
                    return new List<Crust>();

                await using var stream = new MemoryStream();
                await file.CopyToAsync(stream).ConfigureAwait(false);
                using var package = new ExcelPackage(stream);

                var worksheet = package.Workbook.Worksheets[1];
                var crustImportList = new List<CrustImport>();
                var totalRows = worksheet.Dimension.Rows;


                for (var i = 2; i <= totalRows; i++)
                {
                    crustImportList.Add(new CrustImport
                    {
                        Name = worksheet.Cells[$"A{i}"].Value?.ToString()?.Trim() ?? string.Empty,
                        Diameter = worksheet.Cells[$"B{i}"].Value?.ToString()?.Trim() ?? string.Empty,
                        Description = worksheet.Cells[$"C{i}"].Value?.ToString()?.Trim() ?? string.Empty,
                        Surcharge = worksheet.Cells[$"D{i}"].Value?.ToString()?.Trim() ?? string.Empty,
                        Availability = worksheet.Cells[$"E{i}"].Value?.ToString()?.Trim() ?? string.Empty
                    });
                }

                var validatedCrusts = _dataValidationService.ValidateImportedCrusts(crustImportList, out var failedItems);

                foreach (var crust in validatedCrusts)
                {
                    var result = await _pizzaMarioContext.Database.ExecuteSqlRawAsync(
                        $"InsertCrust @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7", crust.Name, crust.Description, crust.Diameter, crust.Availability, crust.Pricing.Price, crust.Pricing.StartDate, crust.Pricing.EndDate, crust.Pricing.Tax).ConfigureAwait(false);
                }

                return validatedCrusts;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<ICollection<Product>> ImportProductsFromExcelFile(IFormFile file)
        {
            if (file == null) return new List<Product>();
            if (!Path.GetExtension(file.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
                return new List<Product>();

            await using var stream = new MemoryStream();
            await file.CopyToAsync(stream).ConfigureAwait(false);
            using var package = new ExcelPackage(stream);

            var worksheet = package.Workbook.Worksheets[1];
            var productImportList = new List<ProductImport>();
            var totalRows = worksheet.Dimension.Rows;

            for (var i = 2; i <= totalRows; i++)
            {
                productImportList.Add(new ProductImport
                {
                    Category = worksheet.Cells[$"A{i}"].Value?.ToString()?.Trim() ?? string.Empty,
                    SubCategory = worksheet.Cells[$"B{i}"].Value?.ToString()?.Trim() ?? string.Empty,
                    ProductName = worksheet.Cells[$"C{i}"].Value?.ToString()?.Trim() ?? string.Empty,
                    Description = worksheet.Cells[$"D{i}"].Value?.ToString()?.Trim() ?? string.Empty,
                    Price = worksheet.Cells[$"E{i}"].Value?.ToString()?.Trim() ?? string.Empty,
                    Spicy = worksheet.Cells[$"F{i}"].Value?.ToString()?.Trim() ?? string.Empty
                });
            }

            var validatedProducts = _dataValidationService.ValidateImportedProducts(productImportList, out var failedProducts);

            return validatedProducts;
        }
    }
}
