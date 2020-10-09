using PizzaMario.ImportCsv.Model;
using PizzaMario.Models;

namespace PizzaMario.ImportCsv.Mappers
{
    public interface IExtraIngredientMapper
    {
        ExtraIngredient Map(CsvExtraIngredient ingredient);
    }

    public class ExtraIngredientMapper : IExtraIngredientMapper
    {
        public ExtraIngredient Map(CsvExtraIngredient ingredient)
        {
            return new ExtraIngredient
            {
                Ingredient = ingredient.Ingredient,
                ExtraPrice = ingredient.ExtraPrice
            };
        }
    }
}