namespace PizzaMario.Models
{
    public class Ingredient : Entity
    {
        public string Name { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsVegy { get; set; }
        public Pricing Pricing { get; set; }
    }
}