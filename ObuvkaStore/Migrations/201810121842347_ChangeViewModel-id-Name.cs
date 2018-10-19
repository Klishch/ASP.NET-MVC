namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeViewModelidName : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.ProductsViewModels", "color", c => c.String());
            //AddColumn("dbo.ProductsViewModels", "forWhom", c => c.String());
            //AddColumn("dbo.ProductsViewModels", "category", c => c.String());
            //AddColumn("dbo.ProductsViewModels", "producer", c => c.String());
            //AddColumn("dbo.ProductsViewModels", "season", c => c.String());
            //AddColumn("dbo.ProductsViewModels", "matherial", c => c.String());
        }
        
        public override void Down()
        {
            //DropColumn("dbo.ProductsViewModels", "matherial");
            //DropColumn("dbo.ProductsViewModels", "season");
            //DropColumn("dbo.ProductsViewModels", "producer");
            //DropColumn("dbo.ProductsViewModels", "category");
            //DropColumn("dbo.ProductsViewModels", "forWhom");
            //DropColumn("dbo.ProductsViewModels", "color");
        }
    }
}
