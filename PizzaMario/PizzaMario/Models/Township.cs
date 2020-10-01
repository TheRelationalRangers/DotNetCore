using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class Township : Entity
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}