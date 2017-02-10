using System.Collections.Generic;

namespace DataModel.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        // Ссылка на покупателя
        public Customer Customer { get; set; }
    }
}