namespace cacharSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class img2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.products", "img", c => c.Binary());
            DropColumn("dbo.products", "image2");
            DropColumn("dbo.products", "image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.products", "image", c => c.String());
            AddColumn("dbo.products", "image2", c => c.Binary());
            DropColumn("dbo.products", "img");
        }
    }
}
