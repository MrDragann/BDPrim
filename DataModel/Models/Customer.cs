using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataModel.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Ссылка на заказы
        public List<Order> Orders { get; set; }

        // Ссылка на профили
        public Profile Profile { get; set; }

        // Ссылка на продукты
        public List<Product> Products { get; set; }
    }
}