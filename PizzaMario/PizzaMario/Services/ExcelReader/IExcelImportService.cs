using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PizzaMario.Models;

namespace PizzaMario.Services.ExcelReader
{
    public interface IExcelImportService
    {
        Task<ICollection<Crust>> ImportCrustFromExcelFile(IFormFile file);
        Task<ICollection<Product>> ImportProductsFromExcelFile(IFormFile file);
    }
}
