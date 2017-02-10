using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            Services.Customers.InsertCustomer(
                new Customer
                {
                    FirstName = "Иван",
                    LastName = "Иванов"
                });
            Services.Customers.InsertOrder(
                new Order
                {
                    ProductName="Абрикосы",
                    Quantity=4
                },4);
            
            Services.Customers.InsertProduct(
                new Product
                {
                    ProductName="Масло",
                    Cost=25
                },3);
            
            return View();
        }
        
        public ActionResult About()
        {
            var products = Services.Customers.GetProducts();
            return View(products);
        }

        public ActionResult Contact()
        {
            Services.Customers.DeleteCustomer(20);
            return View();
        }
    }
}