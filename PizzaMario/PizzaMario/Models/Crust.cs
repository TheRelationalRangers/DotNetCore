namespace PizzaMario.Models
{
    public class Crust : Entity
    {
        public string Name { get; set; }
        public int Diameter { get; set; }
        public string Description { get; set; }
        public string PricingId { get; set; }
        public virtual Pricing Pricing { get; set; }
        public string Availability { get; set; }
    }
}