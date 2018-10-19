namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeContext : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductsPictures", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ProductsPictures", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsPictures", "idProduct", "dbo.Products");
            DropPrimaryKey("dbo.ProductsPictures");
            DropColumn("dbo.ProductsPictures", "picture");
            DropColumn("dbo.ProductsPictures", "id");
            AddPrimaryKey("dbo.ProductsPictures", "idProduct");
            AddForeignKey("dbo.ProductsPictures", "idProduct", "dbo.Products", "id");
        }
    }
}
