using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public string SauceId { get; set; }
        public virtual Sauce Sauce { get; set; }
        public string CrustId { get; set; }
        public virtual Crust Crust { get; set; }
        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public string PricingId { get; set; }
        public virtual Pricing Pricing { get; set; }
        public ICollection<ProductIngredient> ProductIngredients { get; set; }
    }
}