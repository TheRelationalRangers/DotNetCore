namespace PizzaMario.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public Sauce Sauce { get; set; }
        public Crust Crust { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
        public Pricing Pricing { get; set; }
        public virtual OrderLine OrderLine { get; set; }
    }
}