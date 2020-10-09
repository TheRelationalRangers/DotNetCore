using System.Collections.Generic;

namespace PizzaMario.ImportCsv.Model
{
    public abstract class CsvExtraIngredient
    {
        public IEnumerable<CsvExtraIngredient> Ingredients { get; private set; }

        public string Ingredient { get; set; }
        public string ExtraPrice { get; set; }
    }
}