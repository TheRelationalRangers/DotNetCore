using PizzaMario.ImportCsv.Models;
using PizzaMario.Models;

namespace PizzaMario.ImportCsv.Mappers
{
    public interface IExtraIngredientMapper
    {
        ExtraIngredientData Map(CsvExtraIngredient ingredient);
    }

    public class ExtraIngredientMapper : IExtraIngredientMapper
    {
        public ExtraIngredientData Map(CsvExtraIngredient ingredient)
        {
            return new ExtraIngredientData
            {
                Ingredient = ingredient.Ingredient,
                ExtraPrice = ingredient.ExtraPrice
            };
        }
    }
}