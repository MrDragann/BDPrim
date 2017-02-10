using DataModel.Models;
using System.Collections.Generic;

namespace IServices
{
    public interface ICustomerServices
    {
        void InsertCustomer(Customer model);
        void InsertOrder(Order model, int id);
        void InsertProduct(Product model, int id);
        void DeleteCustomer(int id);
        IEnumerable<Product> GetProducts();
    }
}
