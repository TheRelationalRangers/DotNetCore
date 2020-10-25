using System.Collections.Generic;
using PizzaMario.Models;
using PizzaMario.Models.Import;

namespace PizzaMario.Services.ValidationService
{
    public interface IDataValidationService
    {
        ICollection<Crust> ValidateImportedCrusts(ICollection<CrustImport> importedCrusts, out ICollection<CrustImport> failedItems);
        ICollection<Product> ValidateImportedProducts(ICollection<ProductImport> importedProducts, out ICollection<ProductImport> failedProducts);
    }
}
