using System;

namespace BIDash.API.Models {
    public class Order {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime Placed { get; set; }
        public DateTime? Created { get; set; }
    }
}