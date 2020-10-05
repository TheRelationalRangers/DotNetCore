using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class OrderLine : Entity
    {
        public virtual Order Order { get; set; }
        public string OrderId { get; set; }

        public ICollection<Product> Products { get; set; }
        public string ProductId { get; set; }

        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}