namespace PizzaMario.Models
{
    public class Sauce : Entity
    {
        public string Name { get; set; }
        public string PricingId { get; set; }
        public virtual Pricing Pricing { get; set; }
        public bool IsSpicy { get; set; }
    }
}