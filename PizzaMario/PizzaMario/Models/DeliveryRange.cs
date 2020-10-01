using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class DeliveryRange : Entity
    {
        public string MaxRange { get; set; }
        public string MinRange { get; set; }

        public ICollection<Store> Stores { get; set; }
    }
}