using System;

namespace PizzaMario.Models
{
    public class Pricing : Entity
    {
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}