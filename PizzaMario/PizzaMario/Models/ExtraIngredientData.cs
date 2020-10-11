using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PizzaMario.Models
{
    public class ExtraIngredientData : Entity
    {
        public string Ingredient { get; set; }
        public string ExtraPrice { get; set; }
    }
}