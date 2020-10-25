namespace PizzaMario.Models
{
    public class ProductIngredient : Entity
    {
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string IngredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public int IngredientAmount { get; set; }
    }
}
