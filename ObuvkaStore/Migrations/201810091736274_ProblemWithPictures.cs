namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProblemWithPictures : DbMigration
    {
        public override void Up()
        {

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsViewModels", "Seasons_id", "dbo.Seasons");
            DropForeignKey("dbo.ProductsViewModels", "idProduct", "dbo.ProductsPictures");
            DropForeignKey("dbo.ProductSizes", "ProductsViewModel_id", "dbo.ProductsViewModels");
            DropForeignKey("dbo.ProductsViewModels", "ProductsDescriptions_id", "dbo.ProductsDescriptions");
            DropForeignKey("dbo.ProductsViewModels", "Producers_id", "dbo.Producers");
            DropForeignKey("dbo.ProductsViewModels", "Matherials_id", "dbo.Matherials");
            DropForeignKey("dbo.ProductsViewModels", "ForWhoms_id", "dbo.ForWhoms");
            DropForeignKey("dbo.ProductsViewModels", "Colors_id", "dbo.Colors");
            DropForeignKey("dbo.ProductsViewModels", "Categories_id", "dbo.Categories");
            DropForeignKey("dbo.ProductsInfo", "idCategory", "dbo.Categories");
            DropForeignKey("dbo.ProductsInfo", "idSeason", "dbo.Seasons");
            DropForeignKey("dbo.ProductsInfo", "idProductDescriptions", "dbo.ProductsDescriptions");
            DropForeignKey("dbo.Products", "id", "dbo.ProductsInfo");
            DropForeignKey("dbo.UserComments", "idProduct", "dbo.Products");
            DropForeignKey("dbo.Customers", "id", "dbo.UsersInfo");
            DropForeignKey("dbo.UserComments", "idCustomer", "dbo.Customers");
            DropForeignKey("dbo.Orders", "idCustomer", "dbo.Customers");
            DropForeignKey("dbo.Orders", "deliveryAdress", "dbo.UsersAddress");
            DropForeignKey("dbo.Orders", "idOrderedProducts", "dbo.OrderProducts");
            DropForeignKey("dbo.ProductsPictures", "idProduct", "dbo.Products");
            DropForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products");
            DropForeignKey("dbo.ProductsInfo", "idProducer", "dbo.Producers");
            DropForeignKey("dbo.ProductsInfo", "idMatherial", "dbo.Matherials");
            DropForeignKey("dbo.ProductsInfo", "idForWhom", "dbo.ForWhoms");
            DropForeignKey("dbo.ProductsInfo", "idColor", "dbo.Colors");
            DropIndex("dbo.ProductsViewModels", new[] { "Seasons_id" });
            DropIndex("dbo.ProductsViewModels", new[] { "ProductsDescriptions_id" });
            DropIndex("dbo.ProductsViewModels", new[] { "Producers_id" });
            DropIndex("dbo.ProductsViewModels", new[] { "Matherials_id" });
            DropIndex("dbo.ProductsViewModels", new[] { "ForWhoms_id" });
            DropIndex("dbo.ProductsViewModels", new[] { "Colors_id" });
            DropIndex("dbo.ProductsViewModels", new[] { "Categories_id" });
            DropIndex("dbo.ProductsViewModels", new[] { "idProduct" });
            DropIndex("dbo.Orders", new[] { "deliveryAdress" });
            DropIndex("dbo.Orders", new[] { "idOrderedProducts" });
            DropIndex("dbo.Orders", new[] { "idCustomer" });
            DropIndex("dbo.Customers", new[] { "id" });
            DropIndex("dbo.UserComments", new[] { "idCustomer" });
            DropIndex("dbo.UserComments", new[] { "idProduct" });
            DropIndex("dbo.ProductsPictures", new[] { "idProduct" });
            DropIndex("dbo.ProductSizes", new[] { "ProductsViewModel_id" });
            DropIndex("dbo.ProductSizes", new[] { "idProduct" });
            DropIndex("dbo.Products", new[] { "id" });
            DropIndex("dbo.ProductsInfo", new[] { "idProductDescriptions" });
            DropIndex("dbo.ProductsInfo", new[] { "idMatherial" });
            DropIndex("dbo.ProductsInfo", new[] { "idSeason" });
            DropIndex("dbo.ProductsInfo", new[] { "idProducer" });
            DropIndex("dbo.ProductsInfo", new[] { "idCategory" });
            DropIndex("dbo.ProductsInfo", new[] { "idForWhom" });
            DropIndex("dbo.ProductsInfo", new[] { "idColor" });
            DropTable("dbo.ProductsViewModels");
            DropTable("dbo.Seasons");
            DropTable("dbo.ProductsDescriptions");
            DropTable("dbo.UsersInfo");
            DropTable("dbo.UsersAddress");
            DropTable("dbo.OrderProducts");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.UserComments");
            DropTable("dbo.ProductsPictures");
            DropTable("dbo.ProductSizes");
            DropTable("dbo.Products");
            DropTable("dbo.Producers");
            DropTable("dbo.Matherials");
            DropTable("dbo.ForWhoms");
            DropTable("dbo.Colors");
            DropTable("dbo.ProductsInfo");
            DropTable("dbo.Categories");
        }
    }
}
