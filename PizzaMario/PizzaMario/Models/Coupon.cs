using System;

namespace PizzaMario.Models
{
    public class Coupon : Entity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public decimal FlatDiscount { get; set; }
        public decimal PercentageDiscount { get; set; }
    }

    public class ProductCoupon : Entity
    {
        public Product Product { get; set; }
    }
}