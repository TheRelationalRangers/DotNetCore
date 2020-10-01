namespace PizzaMario.Models
{
    public class Crust : Entity
    {
        public string Name { get; set; }
        public int Diameter { get; set; }
        public Pricing Pricing { get; set; }
    }
}