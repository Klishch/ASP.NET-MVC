namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseGeneratedOptionNone : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductsInfo", "id", "dbo.Products");
            DropForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products");
            DropForeignKey("dbo.ProductsPictures", "idProduct", "dbo.Products");
            DropForeignKey("dbo.UserComments", "idProduct", "dbo.Products");
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Products", "id");
            AddForeignKey("dbo.ProductsInfo", "id", "dbo.Products", "id");
            AddForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products", "id");
            AddForeignKey("dbo.ProductsPictures", "idProduct", "dbo.Products", "id");
            AddForeignKey("dbo.UserComments", "idProduct", "dbo.Products", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserComments", "idProduct", "dbo.Products");
            DropForeignKey("dbo.ProductsPictures", "idProduct", "dbo.Products");
            DropForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products");
            DropForeignKey("dbo.ProductsInfo", "id", "dbo.Products");
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Products", "id");
            AddForeignKey("dbo.UserComments", "idProduct", "dbo.Products", "id");
            AddForeignKey("dbo.ProductsPictures", "idProduct", "dbo.Products", "id");
            AddForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products", "id");
            AddForeignKey("dbo.ProductsInfo", "id", "dbo.Products", "id");
        }
    }
}
