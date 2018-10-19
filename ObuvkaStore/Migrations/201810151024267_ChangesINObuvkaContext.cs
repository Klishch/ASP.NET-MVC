namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesINObuvkaContext : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ProductsInfo", new[] { "id" });
            //DropPrimaryKey("dbo.ProductsInfo");
            AlterColumn("dbo.ProductsInfo", "id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Products", "name", c => c.String(nullable: false, maxLength: 50, unicode: false));
            //AddPrimaryKey("dbo.ProductsInfo", "id");
            CreateIndex("dbo.Products", "id");
            AddForeignKey("dbo.Products", "id", "dbo.ProductsInfo", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "id", "dbo.ProductsInfo");
            DropIndex("dbo.Products", new[] { "id" });
            DropPrimaryKey("dbo.ProductsInfo");
            AlterColumn("dbo.Products", "name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ProductsInfo", "id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ProductsInfo", "id");
            CreateIndex("dbo.ProductsInfo", "id");
        }
    }
}
