namespace PizzaMario.Models
{
    public class StoreData : Entity
    {
        public string StoreName { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string TelephoneNumber { get; set; }
    }
}