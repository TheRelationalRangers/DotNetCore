using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class Address : Entity
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Addition { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public int SeriesIndicationStart { get; set; }
        public int SeriesIndicationEnd { get; set; }

        public Township Township { get; set; }
        public int TownshipId { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}