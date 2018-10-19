namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIdProductInfoFromProduct : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "idProductInfo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "idProductInfo", c => c.Int(nullable: false));
        }
    }
}
