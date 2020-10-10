using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace PizzaMario.ImportCsv.Models
{
    public class CsvOrderData
    {
        [Name("Winkelnaam")]
        public string Winkelnaam { get; set; }

        [Name("Klantnaam")]
        public string Klantnaam { get; set; }

        [Name("TelefoonNr")]
        public string TelefoonNr { get; set; }

        [Name("Email")]
        public string Email { get; set; }

        [Name("Adres")]
        public string Adres { get; set; }

        [Name("Woonplaats")]
        public string Woonplaats { get; set; }

        [Name("Besteldatum")]
        public string Besteldatum { get; set; }

        [Name("AfleverType")]
        public string AfleverType { get; set; }

        [Name("AfleverDatum")]
        public string AfleverDatum { get; set; }

        [Name("AfleverMoment")]
        public string AfleverMoment { get; set; }

        [Name("Product")]
        public string Product { get; set; }

        [Name("PizzaBodem")]
        public string PizzaBodem { get; set; }

        [Name("PizzaSaus")]
        public string PizzaSaus { get; set; }

        [Name("Prijs")]
        public string Prijs { get; set; }

        [Name("Bezorgkosten")]
        public string Bezorgkosten { get; set; }

        [Name("Aantal")]
        public string Aantal { get; set; }

        [Name("Extra Ingrediënten")]
        public string ExtraIngrediënten { get; set; }

        [Name("Prijs Extra Ingrediënten")]
        public string PrijsExtraIngrediënten { get; set; }

        [Name("Regelprijs")]
        public string Regelprijs { get; set; }

        [Name("Totaalprijs")]
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
            Map(m => m.Winkelnaam).Name("Winkelnaam");
            Map(m => m.Klantnaam).Name("Klantnaam");
            Map(m => m.TelefoonNr).Name("TelefoonNr");
            Map(m => m.Email).Name("Email");
            Map(m => m.Adres).Name("Adres");
            Map(m => m.Woonplaats).Name("Woonplaats");
            Map(m => m.Besteldatum).Name("Besteldatum");
            Map(m => m.AfleverType).Name("AfleverType");
            Map(m => m.AfleverDatum).Name("AfleverDatum");
            Map(m => m.AfleverMoment).Name("AfleverMoment");
            Map(m => m.Product).Name("Product");
            Map(m => m.PizzaBodem).Name("PizzaBodem");
            Map(m => m.PizzaSaus).Name("PizzaSaus");
            Map(m => m.Prijs).Name("Prijs");
            Map(m => m.Bezorgkosten).Name("Bezorgkosten");
            Map(m => m.Aantal).Name("Aantal");
            Map(m => m.ExtraIngrediënten).Name("Extra Ingrediënten");
            Map(m => m.PrijsExtraIngrediënten).Name("Prijs Extra Ingrediënten");
            Map(m => m.Regelprijs).Name("Regelprijs");
            Map(m => m.Totaalprijs).Name("Totaalprijs");
            Map(m => m.GebruikteCoupon).Name("Gebruikte Coupon");
            Map(m => m.CouponKorting).Name("Coupon Korting");
            Map(m => m.TeBetalen).Name("Te Betalen");
        }
    }
}