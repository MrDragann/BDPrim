namespace DataModel.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataModel.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataModel.DataContext context)
        {
            //var admin = new User { UserName = "Andrew Peters", Password = "123456" };
            //var user = new User { UserName = "Brice Lambson", Password = "123456" };
            //context.Customers.AddOrUpdate(
            //  p => p.Id,
            //  admin,
            //  user,
            //  new User { UserName = "Rowan Miller", Password = "123456" }
            //);

            //context.Orders.AddOrUpdate(p => p.Id,
            //    new Role { Id = TypeRoles.Admin, Name = "Admin", Users = new List<User> { admin } },
            //    new Role { Id = TypeRoles.User, Name = "User", Users = new List<User> { user } }
            //    );
        }
    }
}
