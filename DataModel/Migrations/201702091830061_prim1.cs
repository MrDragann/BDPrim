namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prim1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.Customers", new[] { "Product_ProductId" });
            CreateTable(
                "dbo.ProductCustomers",
                c => new
                    {
                        Product_ProductId = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ProductId, t.Customer_CustomerId })
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId, cascadeDelete: true)
                .Index(t => t.Product_ProductId)
                .Index(t => t.Customer_CustomerId);
            
            DropColumn("dbo.Customers", "Product_ProductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Product_ProductId", c => c.Int());
            DropForeignKey("dbo.ProductCustomers", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.ProductCustomers", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.ProductCustomers", new[] { "Customer_CustomerId" });
            DropIndex("dbo.ProductCustomers", new[] { "Product_ProductId" });
            DropTable("dbo.ProductCustomers");
            CreateIndex("dbo.Customers", "Product_ProductId");
            AddForeignKey("dbo.Customers", "Product_ProductId", "dbo.Products", "ProductId");
        }
    }
}
