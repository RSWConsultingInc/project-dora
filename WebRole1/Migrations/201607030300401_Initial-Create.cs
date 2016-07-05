namespace ProjectDoraWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                {
                    CustomerID = c.Int(nullable: false, identity: true),
                    CustomerName = c.String(),
                })
                .PrimaryKey(t => t.CustomerID);
            CreateTable("dbo.Clients",
                c => new
                {
                    ID = c.Guid(nullable: false, identity: true),
                    ClientName = c.String(),
                })
                .PrimaryKey(t => t.ID);
        }

        public override void Down()
        {
            DropTable("dbo.Customers");
            DropTable("dbo.Clients");
        }
    }
}
