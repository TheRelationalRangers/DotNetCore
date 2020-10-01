using System;

namespace PizzaMario.Models
{
    public class OpeningHour : Entity
    {
        public int Weekday { get; set; }

        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public bool IsClosed { get; set; }

        public int StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}