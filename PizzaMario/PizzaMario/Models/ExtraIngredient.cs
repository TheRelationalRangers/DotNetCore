using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PizzaMario.Models
{
    public class ExtraIngredient : Entity
    {
        public string Ingredient { get; set; }
        public string ExtraPrice { get; set; }
    }
}