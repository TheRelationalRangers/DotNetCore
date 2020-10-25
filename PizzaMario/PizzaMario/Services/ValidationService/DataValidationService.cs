using System;
using System.Collections.Generic;
using PizzaMario.Helpers;
using PizzaMario.Models;
using PizzaMario.Models.Import;

namespace PizzaMario.Services.ValidationService
{
    public class DataValidationService : IDataValidationService
    {
        public ICollection<Crust> ValidateImportedCrusts(ICollection<CrustImport> importedCrusts, out ICollection<CrustImport> failedItems)
        {
            failedItems = new List<CrustImport>();
            var successList = new List<Crust>();
            foreach (var crust in importedCrusts)
            {
                try
                {
                    var isFlaggedAsFailed = false;
                    if (string.IsNullOrEmpty(crust.Name)) { crust.ValidationErrorDescription = $"{crust.ValidationErrorDescription} Name is empty;"; isFlaggedAsFailed = true; }
                    if (string.IsNullOrEmpty(crust.Description)) { crust.ValidationErrorDescription = $"{crust.ValidationErrorDescription} Description is empty;"; isFlaggedAsFailed = true; }
                    if (string.IsNullOrEmpty(crust.Diameter)) { crust.ValidationErrorDescription = $"{crust.ValidationErrorDescription} Diameter is empty;"; isFlaggedAsFailed = true; }
                    if (string.IsNullOrEmpty(crust.Availability)) { crust.ValidationErrorDescription = $"{crust.ValidationErrorDescription} Availability is empty;"; isFlaggedAsFailed = true; }
                    if (string.IsNullOrEmpty(crust.Surcharge)) { crust.ValidationErrorDescription = $"{crust.ValidationErrorDescription} Surcharge is empty;"; isFlaggedAsFailed = true; }

                    if (!decimal.TryParse(crust.Surcharge, out var price))
                    {
                        crust.ValidationErrorDescription = $"{crust.ValidationErrorDescription} Surcharge is not a valid number;"; isFlaggedAsFailed = true;
                    }

                    if (!int.TryParse(crust.Diameter, out var diameter))
                    {
                        crust.ValidationErrorDescription = $"{crust.ValidationErrorDescription} Diameter is not a valid number;"; isFlaggedAsFailed = true;
                    }

                    if (isFlaggedAsFailed)
                    {
                        failedItems.Add(crust);
                        continue;
                    };

                    successList.Add(new Crust
                    {
                       Name = crust.Name,
                       Diameter = diameter,
                       Description = crust.Description,
                       Availability = crust.Availability,
                       Pricing = new Pricing
                       {
                           Price = price,
                           StartDate = DateTime.MinValue,
                           EndDate = DateTime.MaxValue,
                           Tax = 0.21m
                       }
                    });
                }
                catch (Exception ex)
                {
                    failedItems.Add(crust);
                }
            }

            return successList;
        }

        public ICollection<Product> ValidateImportedProducts(ICollection<ProductImport> importedProducts, out ICollection<ProductImport> failedProducts)
        {
            failedProducts = new List<ProductImport>();
            //var successList = new List<Product>();
            //foreach (var product in importedProducts)
            //{
            //    try
            //    {
            //        var isFlaggedAsFailed = false;
            //        if (string.IsNullOrEmpty(product.ProductName)) { product.ValidationErrorDescription = $"{product.ValidationErrorDescription} Product name is empty;"; isFlaggedAsFailed = true; }
            //        if (string.IsNullOrEmpty(product.Category)) { product.ValidationErrorDescription = $"{product.ValidationErrorDescription} Category is empty;"; isFlaggedAsFailed = true; }
            //        if (string.IsNullOrEmpty(product.SubCategory)) { product.ValidationErrorDescription = $"{product.ValidationErrorDescription} Subcategory is empty;"; isFlaggedAsFailed = true; }
            //        if (string.IsNullOrEmpty(product.Description)) { product.ValidationErrorDescription = $"{product.ValidationErrorDescription} Description is empty;"; isFlaggedAsFailed = true; }
            //        if (string.IsNullOrEmpty(product.Price)) { product.ValidationErrorDescription = $"{product.ValidationErrorDescription} Price is empty;"; isFlaggedAsFailed = true; }
            //        if (string.IsNullOrEmpty(product.Spicy)) { product.ValidationErrorDescription = $"{product.ValidationErrorDescription} Spicy is empty;"; isFlaggedAsFailed = true; }

            //        if (!decimal.TryParse(product.Price, out var price))
            //        {
            //            product.ValidationErrorDescription = $"{product.ValidationErrorDescription} Price is not a valid number;"; isFlaggedAsFailed = true;
            //        }

            //        if (!bool.TryParse(DataValidationHelper.BoolValidator(product.Spicy), out var spicy))
            //        {
            //            product.ValidationErrorDescription = $"{product.ValidationErrorDescription} Spicy is not a valid bool;"; isFlaggedAsFailed = true;
            //        }

            //        if (isFlaggedAsFailed)
            //        {
            //            failedProducts.Add(product);
            //            continue;
            //        };

            //        successList.Add(new Product
            //        {
            //            Name = product.ProductName,
            //            Category = product.Category,
            //            SubCategory = product.SubCategory,
            //            Description = product.Description,
            //            Price = price,
            //            Spicy = spicy
            //        });
            //    }
            //    catch (Exception ex)
            //    {
            //        failedProducts.Add(product);
            //    }
            //}

            //return successList;
            return new List<Product>();
        }
    }
}
