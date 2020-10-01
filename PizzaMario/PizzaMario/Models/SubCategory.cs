namespace PizzaMario.Models
{
    public class SubCategory : Entity
    {
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}