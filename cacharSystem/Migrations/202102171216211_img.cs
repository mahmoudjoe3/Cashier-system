namespace cacharSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class img : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.products", "image2", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.products", "image2");
        }
    }
}
