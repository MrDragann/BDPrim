using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Cost { get; set; }

        // Список покупателей, заказавших этот товар
        public List<Customer> Customer { get; set; }
    }
}
