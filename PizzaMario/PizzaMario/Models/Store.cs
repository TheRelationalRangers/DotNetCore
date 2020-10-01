using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class Store : Entity
    {
        public string Name { get; set; }
        public int StoreNumber { get; set; }
        public string CountryCode { get; set; }

        public Address Address { get; set; }
        public int AddressId { get; set; }

        public virtual DeliveryRange DeliveryRange { get; set; }
        public int DeliveryRangeId { get; set; }

        public ICollection<OpeningHour> OpeningHours { get; set; }

        public ICollection<AlternateOpeningHour> AlternateOpeningHours { get; set; }
    }
}