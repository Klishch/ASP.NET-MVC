namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTableProd : DbMigration
    {
        public override void Up()
        {

            AddPrimaryKey("dbo.ProductsInfo", "id");
            CreateIndex("dbo.ProductsInfo", "id");
        }

        public override void Down()
        {
            DropIndex("dbo.ProductsInfo", new[] { "id" });
            DropPrimaryKey("dbo.ProductsInfo");

        } 
    }
}
