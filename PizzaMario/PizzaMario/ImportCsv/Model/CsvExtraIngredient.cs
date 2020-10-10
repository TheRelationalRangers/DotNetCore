using System.Collections.Generic;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace PizzaMario.ImportCsv.Model
{
    public class CsvExtraIngredient
    {
        [Name("Ingredient")]
        public string Ingredient { get; set; }

        [Name("Extra Price")]
        public string ExtraPrice { get; set; }
    }

    public sealed class ExtraIngredientHeaderMapper : ClassMap<CsvExtraIngredient>
    {
        public ExtraIngredientHeaderMapper()
        {
            Map(m => m.Ingredient).Name("Ingredient");
            Map(m => m.ExtraPrice).Name("Extra Price");
        }
    }
}