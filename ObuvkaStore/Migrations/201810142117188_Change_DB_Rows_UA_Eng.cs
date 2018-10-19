namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_DB_Rows_UA_Eng : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "dbo.ProductsViewModels", newName: "AdminProducts");
            //DropForeignKey("dbo.Customers", "id", "dbo.UsersInfo");
            //DropForeignKey("dbo.Shoes", "Categories_id", "dbo.Categories");
            //DropForeignKey("dbo.Shoes", "Colors_id", "dbo.Colors");
            //DropForeignKey("dbo.Shoes", "Customers_id", "dbo.Customers");
            //DropForeignKey("dbo.Shoes", "ForWhoms_id", "dbo.ForWhoms");
            //DropForeignKey("dbo.Shoes", "Matherials_id", "dbo.Matherials");
            //DropForeignKey("dbo.Shoes", "Producers_id", "dbo.Producers");
            //DropForeignKey("dbo.Shoes", "ProductsDescriptions_id", "dbo.ProductsDescriptions");
            //DropForeignKey("dbo.Shoes", "ProductSizes_id", "dbo.ProductSizes");
            //DropForeignKey("dbo.Shoes", "ProductsPictures_id", "dbo.ProductsPictures");
            //DropForeignKey("dbo.Shoes", "Seasons_id", "dbo.Seasons");
            //DropForeignKey("dbo.UserComments", "Shoes_id", "dbo.Shoes");
            //DropForeignKey("dbo.Shoes", "UsersInfo_id", "dbo.UsersInfo");
            //DropForeignKey("dbo.ProductsInfo", "idSeason", "dbo.Seasons");
            //DropForeignKey("dbo.Products", "id", "dbo.ProductsInfo");
            //DropForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products");
            //DropForeignKey("dbo.ProductsPictures", "idProduct", "dbo.Products");
            //DropIndex("dbo.ProductsInfo", new[] { "idSeason" });
            //DropIndex("dbo.Products", new[] { "id" });
            //DropIndex("dbo.UserComments", new[] { "Shoes_id" });
            //DropIndex("dbo.Customers", new[] { "id" });
            //DropIndex("dbo.Orders", new[] { "idOrderedProducts" });
            //DropIndex("dbo.Shoes", new[] { "Categories_id" });
            //DropIndex("dbo.Shoes", new[] { "Colors_id" });
            //DropIndex("dbo.Shoes", new[] { "Customers_id" });
            //DropIndex("dbo.Shoes", new[] { "ForWhoms_id" });
            //DropIndex("dbo.Shoes", new[] { "Matherials_id" });
            //DropIndex("dbo.Shoes", new[] { "Producers_id" });
            //DropIndex("dbo.Shoes", new[] { "ProductsDescriptions_id" });
            //DropIndex("dbo.Shoes", new[] { "ProductSizes_id" });
            //DropIndex("dbo.Shoes", new[] { "ProductsPictures_id" });
            //DropIndex("dbo.Shoes", new[] { "Seasons_id" });
            //DropIndex("dbo.Shoes", new[] { "UsersInfo_id" });
            //DropColumn("dbo.OrderProducts", "idOrder");
            //RenameColumn(table: "dbo.OrderProducts", name: "idOrderedProducts", newName: "idOrder");
            //AddColumn("dbo.Categories", "category_name", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.Categories", "description", c => c.String(unicode: false, storeType: "text"));
            //AddColumn("dbo.ProductsInfo", "Seasons_id", c => c.Int());
            //AddColumn("dbo.Colors", "color_name", c => c.String(nullable: false, maxLength: 40));
            //AddColumn("dbo.ForWhoms", "whom", c => c.String(nullable: false, maxLength: 40));
            //AddColumn("dbo.Matherials", "matherial", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.Producers", "producerCountry", c => c.String(maxLength: 50));
            //AddColumn("dbo.Products", "name", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.Products", "ProductsInfo_id", c => c.Int());
            //AddColumn("dbo.ProductsDescriptions", "description", c => c.String(unicode: false, storeType: "text"));
            //AddColumn("dbo.Seasons", "season", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.AdminProducts", "Name", c => c.String());
            //AddColumn("dbo.AdminProducts", "description", c => c.String());
            //AddColumn("dbo.AdminProducts", "ProductsInfo_id", c => c.Int());
            //AlterColumn("dbo.UsersInfo", "name", c => c.String(nullable: false, maxLength: 20));
            //AlterColumn("dbo.UsersInfo", "surname", c => c.String(nullable: false, maxLength: 30));
            //AlterColumn("dbo.UsersInfo", "userLanguage", c => c.String(maxLength: 50));
            //AlterColumn("dbo.UsersInfo", "userStatus", c => c.String(maxLength: 50));
            //AlterColumn("dbo.UsersInfo", "idAdress", c => c.Int(nullable: false));
            //CreateIndex("dbo.AdminProducts", "ProductsInfo_id");
            //CreateIndex("dbo.ProductsInfo", "Seasons_id");
            //CreateIndex("dbo.Products", "ProductsInfo_id");
            //CreateIndex("dbo.OrderProducts", "idOrder");
            //CreateIndex("dbo.UsersInfo", "idAdress");
            //AddForeignKey("dbo.AdminProducts", "ProductsInfo_id", "dbo.ProductsInfo", "id");
            //AddForeignKey("dbo.UsersInfo", "idAdress", "dbo.UsersAddress", "id");
            //AddForeignKey("dbo.ProductsInfo", "Seasons_id", "dbo.Seasons", "id");
            //AddForeignKey("dbo.Products", "ProductsInfo_id", "dbo.ProductsInfo", "id");
            //AddForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products", "id");
            //AddForeignKey("dbo.ProductsPictures", "idProduct", "dbo.Products", "id");
            //DropColumn("dbo.Categories", "category_ua");
            //DropColumn("dbo.Categories", "description_ua");
            //DropColumn("dbo.Categories", "category_ru");
            //DropColumn("dbo.Categories", "description_ru");
            //DropColumn("dbo.Categories", "category_eng");
            //DropColumn("dbo.Categories", "description_eng");
            //DropColumn("dbo.Colors", "color_ua");
            //DropColumn("dbo.Colors", "color_ru");
            //DropColumn("dbo.Colors", "color_eng");
            //DropColumn("dbo.ForWhoms", "whom_ua");
            //DropColumn("dbo.ForWhoms", "whom_ru");
            //DropColumn("dbo.ForWhoms", "whom_eng");
            //DropColumn("dbo.Matherials", "matherial_ua");
            //DropColumn("dbo.Matherials", "matherial_ru");
            //DropColumn("dbo.Matherials", "matherial_eng");
            //DropColumn("dbo.Producers", "producerCountry_ua");
            //DropColumn("dbo.Producers", "producerCountry_ru");
            //DropColumn("dbo.Producers", "producerCountry_eng");
            //DropColumn("dbo.Products", "Name_ua");
            //DropColumn("dbo.Products", "Name_ru");
            //DropColumn("dbo.Products", "Name_eng");
            //DropColumn("dbo.UserComments", "Shoes_id");
            //DropColumn("dbo.ProductsDescriptions", "description_ua");
            //DropColumn("dbo.ProductsDescriptions", "description_ru");
            //DropColumn("dbo.ProductsDescriptions", "description_eng");
            //DropColumn("dbo.Seasons", "season_ua");
            //DropColumn("dbo.Seasons", "season_ru");
            //DropColumn("dbo.Seasons", "season_eng");
            //DropColumn("dbo.AdminProducts", "Name_ua");
            //DropColumn("dbo.AdminProducts", "Name_ru");
            //DropColumn("dbo.AdminProducts", "Name_eng");
            //DropColumn("dbo.AdminProducts", "description_ua");
            //DropColumn("dbo.AdminProducts", "description_ru");
            //DropColumn("dbo.AdminProducts", "description_eng");
            //DropTable("dbo.Shoes");
        }
        
        public override void Down()
        {
            //CreateTable(
            //    "dbo.Shoes",
            //    c => new
            //        {
            //            id = c.Int(nullable: false, identity: true),
            //            Name_ru = c.String(),
            //            price = c.Double(nullable: false),
            //            color = c.String(),
            //            availability = c.Boolean(nullable: false),
            //            forWhom = c.String(),
            //            category = c.String(),
            //            producer = c.String(),
            //            season = c.String(),
            //            matherial = c.String(),
            //            description_ru = c.String(),
            //            userComments = c.String(),
            //            Categories_id = c.Int(),
            //            Colors_id = c.Int(),
            //            Customers_id = c.Int(),
            //            ForWhoms_id = c.Int(),
            //            Matherials_id = c.Int(),
            //            Producers_id = c.Int(),
            //            ProductsDescriptions_id = c.Int(),
            //            ProductSizes_id = c.Int(),
            //            ProductsPictures_id = c.Int(),
            //            Seasons_id = c.Int(),
            //            UsersInfo_id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.id);
            
            //AddColumn("dbo.AdminProducts", "description_eng", c => c.String());
            //AddColumn("dbo.AdminProducts", "description_ru", c => c.String());
            //AddColumn("dbo.AdminProducts", "description_ua", c => c.String());
            //AddColumn("dbo.AdminProducts", "Name_eng", c => c.String());
            //AddColumn("dbo.AdminProducts", "Name_ru", c => c.String());
            //AddColumn("dbo.AdminProducts", "Name_ua", c => c.String());
            //AddColumn("dbo.Seasons", "season_eng", c => c.String(nullable: false, maxLength: 50, unicode: false));
            //AddColumn("dbo.Seasons", "season_ru", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.Seasons", "season_ua", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.ProductsDescriptions", "description_eng", c => c.String(unicode: false, storeType: "text"));
            //AddColumn("dbo.ProductsDescriptions", "description_ru", c => c.String(unicode: false, storeType: "text"));
            //AddColumn("dbo.ProductsDescriptions", "description_ua", c => c.String(unicode: false, storeType: "text"));
            //AddColumn("dbo.UserComments", "Shoes_id", c => c.Int());
            //AddColumn("dbo.Products", "Name_eng", c => c.String(nullable: false, maxLength: 50, unicode: false));
            //AddColumn("dbo.Products", "Name_ru", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.Products", "Name_ua", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.Producers", "producerCountry_eng", c => c.String(nullable: false, maxLength: 50, unicode: false));
            //AddColumn("dbo.Producers", "producerCountry_ru", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.Producers", "producerCountry_ua", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.Matherials", "matherial_eng", c => c.String(nullable: false, maxLength: 50, unicode: false));
            //AddColumn("dbo.Matherials", "matherial_ru", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.Matherials", "matherial_ua", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.ForWhoms", "whom_eng", c => c.String(nullable: false, maxLength: 40, unicode: false));
            //AddColumn("dbo.ForWhoms", "whom_ru", c => c.String(nullable: false, maxLength: 40));
            //AddColumn("dbo.ForWhoms", "whom_ua", c => c.String(nullable: false, maxLength: 40));
            //AddColumn("dbo.Colors", "color_eng", c => c.String(nullable: false, maxLength: 40, unicode: false));
            //AddColumn("dbo.Colors", "color_ru", c => c.String(nullable: false, maxLength: 40));
            //AddColumn("dbo.Colors", "color_ua", c => c.String(nullable: false, maxLength: 40));
            //AddColumn("dbo.Categories", "description_eng", c => c.String(unicode: false, storeType: "text"));
            //AddColumn("dbo.Categories", "category_eng", c => c.String(nullable: false, maxLength: 50, unicode: false));
            //AddColumn("dbo.Categories", "description_ru", c => c.String(unicode: false, storeType: "text"));
            //AddColumn("dbo.Categories", "category_ru", c => c.String(nullable: false, maxLength: 50));
            //AddColumn("dbo.Categories", "description_ua", c => c.String(unicode: false, storeType: "text"));
            //AddColumn("dbo.Categories", "category_ua", c => c.String(nullable: false, maxLength: 50));
            //DropForeignKey("dbo.ProductsPictures", "idProduct", "dbo.Products");
            //DropForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products");
            //DropForeignKey("dbo.Products", "ProductsInfo_id", "dbo.ProductsInfo");
            //DropForeignKey("dbo.ProductsInfo", "Seasons_id", "dbo.Seasons");
            //DropForeignKey("dbo.UsersInfo", "idAdress", "dbo.UsersAddress");
            //DropForeignKey("dbo.AdminProducts", "ProductsInfo_id", "dbo.ProductsInfo");
            //DropIndex("dbo.UsersInfo", new[] { "idAdress" });
            //DropIndex("dbo.OrderProducts", new[] { "idOrder" });
            //DropIndex("dbo.Products", new[] { "ProductsInfo_id" });
            //DropIndex("dbo.ProductsInfo", new[] { "Seasons_id" });
            //DropIndex("dbo.AdminProducts", new[] { "ProductsInfo_id" });
            //AlterColumn("dbo.UsersInfo", "idAdress", c => c.String(nullable: false, unicode: false, storeType: "text"));
            //AlterColumn("dbo.UsersInfo", "userStatus", c => c.String(nullable: false, maxLength: 50));
            //AlterColumn("dbo.UsersInfo", "userLanguage", c => c.String(nullable: false, maxLength: 50));
            //AlterColumn("dbo.UsersInfo", "surname", c => c.String(maxLength: 30));
            //AlterColumn("dbo.UsersInfo", "name", c => c.String(maxLength: 20));
            //DropColumn("dbo.AdminProducts", "ProductsInfo_id");
            //DropColumn("dbo.AdminProducts", "description");
            //DropColumn("dbo.AdminProducts", "Name");
            //DropColumn("dbo.Seasons", "season");
            //DropColumn("dbo.ProductsDescriptions", "description");
            //DropColumn("dbo.Products", "ProductsInfo_id");
            //DropColumn("dbo.Products", "name");
            //DropColumn("dbo.Producers", "producerCountry");
            //DropColumn("dbo.Matherials", "matherial");
            //DropColumn("dbo.ForWhoms", "whom");
            //DropColumn("dbo.Colors", "color_name");
            //DropColumn("dbo.ProductsInfo", "Seasons_id");
            //DropColumn("dbo.Categories", "description");
            //DropColumn("dbo.Categories", "category_name");
            //RenameColumn(table: "dbo.OrderProducts", name: "idOrder", newName: "idOrderedProducts");
            //AddColumn("dbo.OrderProducts", "idOrder", c => c.Int(nullable: false));
            //CreateIndex("dbo.Shoes", "UsersInfo_id");
            //CreateIndex("dbo.Shoes", "Seasons_id");
            //CreateIndex("dbo.Shoes", "ProductsPictures_id");
            //CreateIndex("dbo.Shoes", "ProductSizes_id");
            //CreateIndex("dbo.Shoes", "ProductsDescriptions_id");
            //CreateIndex("dbo.Shoes", "Producers_id");
            //CreateIndex("dbo.Shoes", "Matherials_id");
            //CreateIndex("dbo.Shoes", "ForWhoms_id");
            //CreateIndex("dbo.Shoes", "Customers_id");
            //CreateIndex("dbo.Shoes", "Colors_id");
            //CreateIndex("dbo.Shoes", "Categories_id");
            //CreateIndex("dbo.Orders", "idOrderedProducts");
            //CreateIndex("dbo.Customers", "id");
            //CreateIndex("dbo.UserComments", "Shoes_id");
            //CreateIndex("dbo.Products", "id");
            //CreateIndex("dbo.ProductsInfo", "idSeason");
            //AddForeignKey("dbo.ProductsPictures", "idProduct", "dbo.Products", "id", cascadeDelete: true);
            //AddForeignKey("dbo.ProductSizes", "idProduct", "dbo.Products", "id", cascadeDelete: true);
            //AddForeignKey("dbo.Products", "id", "dbo.ProductsInfo", "id");
            //AddForeignKey("dbo.ProductsInfo", "idSeason", "dbo.Seasons", "id");
            //AddForeignKey("dbo.Shoes", "UsersInfo_id", "dbo.UsersInfo", "id");
            //AddForeignKey("dbo.UserComments", "Shoes_id", "dbo.Shoes", "id");
            //AddForeignKey("dbo.Shoes", "Seasons_id", "dbo.Seasons", "id");
            //AddForeignKey("dbo.Shoes", "ProductsPictures_id", "dbo.ProductsPictures", "id");
            //AddForeignKey("dbo.Shoes", "ProductSizes_id", "dbo.ProductSizes", "id");
            //AddForeignKey("dbo.Shoes", "ProductsDescriptions_id", "dbo.ProductsDescriptions", "id");
            //AddForeignKey("dbo.Shoes", "Producers_id", "dbo.Producers", "id");
            //AddForeignKey("dbo.Shoes", "Matherials_id", "dbo.Matherials", "id");
            //AddForeignKey("dbo.Shoes", "ForWhoms_id", "dbo.ForWhoms", "id");
            //AddForeignKey("dbo.Shoes", "Customers_id", "dbo.Customers", "id");
            //AddForeignKey("dbo.Shoes", "Colors_id", "dbo.Colors", "id");
            //AddForeignKey("dbo.Shoes", "Categories_id", "dbo.Categories", "id");
            //AddForeignKey("dbo.Customers", "id", "dbo.UsersInfo", "id");
            //RenameTable(name: "dbo.AdminProducts", newName: "ProductsViewModels");
        }
    }
}
