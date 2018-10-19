namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddidforTableProductSizes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products");
            AddColumn("dbo.ProductSizes", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ProductSizes", "id");
            AddForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products");
            DropColumn("dbo.ProductSizes", "id");
            AddPrimaryKey("dbo.ProductSizes", new[] { "idProduct", "size", "quantity" });
            AddForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products", "id");
        }
    }
}
