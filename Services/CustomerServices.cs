using DataModel;
using DataModel.Models;
using IServices;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Validation;

namespace Services
{
    public class CustomerServices : ICustomerServices
    {        
        public void InsertCustomer(Customer model)
        {
            using (var db = new DataContext())
            {
                var customer = new Customer
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Profile = new Profile
                    {
                        RegistrationDate = DateTime.Now.Date.ToString(),
                        LastLoginDate = DateTime.Now.Date.ToString()
                    }
                };
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public void InsertOrder(Order model, int id)
        {
            using(var db = new DataContext())
            {
                var customer = db.Customers.Include(x => x.Orders).FirstOrDefault(x => x.CustomerId == id);
                var order = new Order
                {
                    ProductName = model.ProductName,
                    Quantity = model.Quantity,
                    Customer = customer
                };
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }
        public void InsertProduct(Product model, int id)
        {
            using (var db = new DataContext())
            {
                var customer = db.Customers.Include(x => x.Products).FirstOrDefault(x => x.CustomerId == id);
                var product = new Product
                {
                    ProductName = model.ProductName,
                    Cost = model.Cost,
                    Customer = new List<Customer> { customer }
                };
                db.Products.Add(product);
                db.SaveChanges();
            }
        }
        public void DeleteCustomer(int id)
        {
            using(var db = new DataContext())
            {
                var customer = db.Customers.FirstOrDefault(x => x.CustomerId == id);
                var profile = db.Profiles.FirstOrDefault(x => x.CustomerId == id);
                db.Profiles.Remove(profile);
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }
        public IEnumerable<Product> GetProducts()
        {
            using(var db = new DataContext())
            {
                var products = db.Products.Include(x => x.Customer);
                return products.ToList();
            }
        }


    }
}
