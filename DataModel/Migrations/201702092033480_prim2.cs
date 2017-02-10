namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prim2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profiles", "RegistrationDate", c => c.String());
            AlterColumn("dbo.Profiles", "LastLoginDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profiles", "LastLoginDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Profiles", "RegistrationDate", c => c.DateTime(nullable: false));
        }
    }
}
