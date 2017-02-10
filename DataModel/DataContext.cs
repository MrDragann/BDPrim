using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class DataContext:DbContext
    {
        public DataContext() 
        : base("BDPrim")
    { }


        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
