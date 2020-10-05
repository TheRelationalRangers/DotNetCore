using System;

namespace PizzaMario.Models
{
    public class CategoryCoupon : Entity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public decimal DiscountValue { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}