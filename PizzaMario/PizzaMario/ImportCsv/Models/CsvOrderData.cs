using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace PizzaMario.ImportCsv.Models
{
    public class CsvOrderData
    {
        public IEnumerable<CsvOrderData> Orders { get; set; } = new List<CsvOrderData>();

        public string Winkelnaam { get; set; }
        public string Klantnaam { get; set; }
        public string TelefoonNr { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string Woonplaats { get; set; }
        public string Besteldatum { get; set; }
        public string AfleverType { get; set; }
        public string AfleverDatum { get; set; }
        public string AfleverMoment { get; set; }
        public string Product { get; set; }
        public string PizzaBodem { get; set; }
        public string PizzaSaus { get; set; }
        public string Prijs { get; set; }
        public string Bezorgkosten { get; set; }

        [Name("Extra Ingrediënten")]
        public string ExtraIngrediënten { get; set; }

        [Name("Prijs Extra Ingrediënten")]
        public string PrijsExtraIngrediënten { get; set; }

        public string Regelprijs { get; set; }
        public string Totaalprijs { get; set; }

        [Name("Gebruikte Coupon")]
        public string GebruikteCoupon { get; set; }

        [Name("Coupon Korting")]
        public string CouponKorting { get; set; }

        [Name("Te Betalen")]
        public string TeBetalen { get; set; }
    }

    public sealed class OrderDataHeaderMapper : ClassMap<CsvOrderData>
    {
        public OrderDataHeaderMapper()
        {
            Map(m => m.ExtraIngrediënten).Name("Extra Ingrediënten");
            Map(m => m.PrijsExtraIngrediënten).Name("Prijs Extra Ingrediënten");
            Map(m => m.GebruikteCoupon).Name("Gebruikte Coupon");
            Map(m => m.CouponKorting).Name("Coupon Korting");
            Map(m => m.TeBetalen).Name("Te Betalen");
        }
    }

    public class OrderDataCollector
    {
        public void GetOrderData()
        {
            var orderData = new CsvOrderData();

            using var reader = new StreamReader(@"C:\TestFiles\MarioOrderData01_10000.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Configuration.Delimiter = ";";
            csv.Configuration.PrepareHeaderForMatch = (header, index) => Regex.Replace(header, @"\s", string.Empty);
            csv.Configuration.RegisterClassMap<OrderDataHeaderMapper>();
            orderData.Orders = csv.GetRecords<CsvOrderData>();
        }
    }
}