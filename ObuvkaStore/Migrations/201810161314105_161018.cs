namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _161018 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name_ru = c.String(),
                        price = c.Double(nullable: false),
                        color = c.String(),
                        availability = c.Boolean(nullable: false),
                        forWhom = c.String(),
                        category = c.String(),
                        producer = c.String(),
                        season = c.String(),
                        matherial = c.String(),
                        description_ru = c.String(),
                        Categories_id = c.Int(),
                        Colors_id = c.Int(),
                        Customers_id = c.Int(),
                        ForWhoms_id = c.Int(),
                        Matherials_id = c.Int(),
                        Producers_id = c.Int(),
                        ProductsDescriptions_id = c.Int(),
                        ProductSizes_id = c.Int(),
                        ProductsPictures_id = c.Int(),
                        Seasons_id = c.Int(),
                        UsersInfo_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.Categories_id)
                .ForeignKey("dbo.Colors", t => t.Colors_id)
                .ForeignKey("dbo.Customers", t => t.Customers_id)
                .ForeignKey("dbo.ForWhoms", t => t.ForWhoms_id)
                .ForeignKey("dbo.Matherials", t => t.Matherials_id)
                .ForeignKey("dbo.Producers", t => t.Producers_id)
                .ForeignKey("dbo.ProductsDescriptions", t => t.ProductsDescriptions_id)
                .ForeignKey("dbo.ProductSizes", t => t.ProductSizes_id)
                .ForeignKey("dbo.ProductsPictures", t => t.ProductsPictures_id)
                .ForeignKey("dbo.Seasons", t => t.Seasons_id)
                .ForeignKey("dbo.UsersInfo", t => t.UsersInfo_id)
                .Index(t => t.Categories_id)
                .Index(t => t.Colors_id)
                .Index(t => t.Customers_id)
                .Index(t => t.ForWhoms_id)
                .Index(t => t.Matherials_id)
                .Index(t => t.Producers_id)
                .Index(t => t.ProductsDescriptions_id)
                .Index(t => t.ProductSizes_id)
                .Index(t => t.ProductsPictures_id)
                .Index(t => t.Seasons_id)
                .Index(t => t.UsersInfo_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shoes", "UsersInfo_id", "dbo.UsersInfo");
            DropForeignKey("dbo.Shoes", "Seasons_id", "dbo.Seasons");
            DropForeignKey("dbo.Shoes", "ProductsPictures_id", "dbo.ProductsPictures");
            DropForeignKey("dbo.Shoes", "ProductSizes_id", "dbo.ProductSizes");
            DropForeignKey("dbo.Shoes", "ProductsDescriptions_id", "dbo.ProductsDescriptions");
            DropForeignKey("dbo.Shoes", "Producers_id", "dbo.Producers");
            DropForeignKey("dbo.Shoes", "Matherials_id", "dbo.Matherials");
            DropForeignKey("dbo.Shoes", "ForWhoms_id", "dbo.ForWhoms");
            DropForeignKey("dbo.Shoes", "Customers_id", "dbo.Customers");
            DropForeignKey("dbo.Shoes", "Colors_id", "dbo.Colors");
            DropForeignKey("dbo.Shoes", "Categories_id", "dbo.Categories");
            DropIndex("dbo.Shoes", new[] { "UsersInfo_id" });
            DropIndex("dbo.Shoes", new[] { "Seasons_id" });
            DropIndex("dbo.Shoes", new[] { "ProductsPictures_id" });
            DropIndex("dbo.Shoes", new[] { "ProductSizes_id" });
            DropIndex("dbo.Shoes", new[] { "ProductsDescriptions_id" });
            DropIndex("dbo.Shoes", new[] { "Producers_id" });
            DropIndex("dbo.Shoes", new[] { "Matherials_id" });
            DropIndex("dbo.Shoes", new[] { "ForWhoms_id" });
            DropIndex("dbo.Shoes", new[] { "Customers_id" });
            DropIndex("dbo.Shoes", new[] { "Colors_id" });
            DropIndex("dbo.Shoes", new[] { "Categories_id" });
            DropTable("dbo.Shoes");
        }
    }
}
