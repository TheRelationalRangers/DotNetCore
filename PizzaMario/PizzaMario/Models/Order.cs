using System;
using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class Order : Entity
    {
        public virtual Store Store { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Status Status { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual ProductCoupon ProductCoupon { get; set; }
        public virtual CategoryCoupon CategoryCoupon { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }

        public string StoreNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerZipcode { get; set; }
        public string CustomerHouseNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Tax { get; set; }
        public string Comment { get; set; }
    }
}