namespace cacharSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        products_ids = c.String(),
                        cost = c.Single(nullable: false),
                        Discount = c.Single(nullable: false),
                        Cashier = c.String(),
                        Taxes = c.Single(nullable: false),
                        date = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        quantity = c.Int(nullable: false),
                        sellPrice = c.Single(nullable: false),
                        factoryPrice = c.Single(nullable: false),
                        image = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.products");
            DropTable("dbo.Bills");
        }
    }
}
