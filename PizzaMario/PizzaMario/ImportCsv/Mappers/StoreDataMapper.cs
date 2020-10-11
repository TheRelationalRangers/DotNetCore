using System.Collections.Generic;
using PizzaMario.ImportCsv.Importers;
using PizzaMario.Models;

namespace PizzaMario.ImportCsv.Mappers
{
    public interface IStoreDataMapper
    {
        StoreData Map(List<string> storeData);
    }

    public class StoreDataMapper : IStoreDataMapper
    {
        public StoreData Map(List<string> storeData)
        {
            return new StoreData
            {
                StoreName = storeData[0],
                Street = storeData[1],
                StreetNumber = storeData[2],
                City = storeData[3],
                Country = storeData[4],
                ZipCode = storeData[5],
                TelephoneNumber = storeData[6]
            };
        }
    }
}