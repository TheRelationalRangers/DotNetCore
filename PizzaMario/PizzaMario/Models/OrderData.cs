namespace PizzaMario.Models
{
    public class OrderData : Entity
    {
        public string StoreName { get; set; }
        public string CustomerName { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryType { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryMoment { get; set; }
        public string Product { get; set; }
        public string Crust { get; set; }
        public string Saus { get; set; }
        public string Price { get; set; }
        public string DeliveryCost { get; set; }
        public string Amount { get; set; }
        public string ExtraIngredient { get; set; }
        public string ExtraIngredientPrice { get; set; }
        public string OrderLinePrice { get; set; }
        public string TotalOrderLinePrice { get; set; }
        public string UserCoupon { get; set; }
        public string CouponDiscount { get; set; }
        public string TotalPrice { get; set; }
    }
}