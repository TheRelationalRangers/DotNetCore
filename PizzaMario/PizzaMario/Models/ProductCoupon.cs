using System;

namespace PizzaMario.Models
{
    public class ProductCoupon : Entity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }
        public decimal DiscountValue { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}