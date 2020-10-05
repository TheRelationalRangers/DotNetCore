namespace PizzaMario.Models
{
    public class Ingredient : Entity
    {
        public string Name { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsVeggy { get; set; }
        public Pricing Pricing { get; set; }
    }
}